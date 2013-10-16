using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBQ
{
    public partial class Form1 : Form
    {        
        string xmlConfig = "config.xml";

        string Server = "";
        string DB = "";
        string User = "";
        string Password = "";
        string Value = "";
        string Parameter = "";
        string Table = "";

        SqlCommand sCommand;
        SqlDataAdapter sAdapter;
        SqlCommandBuilder sBuilder;
        DataSet sDs;
        DataTable sTable;

        CancellationTokenSource cts = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            DisposeAllTables();
            Close();
        }

        void MakeConnectString()
        {            
            Server = tServer.Text;
            DB = tBD.Text;
            Table = tTable.Text;
            User = tUser.Text;
            Password = tPassword.Text;
            Value = tValue.Text;

            bool flag = false;
            foreach (var el in cbParameter.Items)
            {
                if (cbParameter.Text == el.ToString())
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
                Parameter = cbParameter.Text;
            else
            {
                Parameter = "";
                cbParameter.Text = "";
            }
        }

        void MakeDisConnectString()
        {
            Server = "";
            DB = "";
            Table = "";
            User = "";
            Password = "";
            Value = "";
            Parameter = "";
        }

        private void MakeDefaultConnect()
        {
            try
            {
                ReadXml xml = new ReadXml();
                string server = "";
                string bd = "";
                string table = "";
                string user = "";
                string password = "";
                xml.GetParameters(xmlConfig,
                                  ref server,
                                  ref bd,
                                  ref table,
                                  ref user,
                                  ref password);
                tServer.Text = server;
                tBD.Text = bd;
                tTable.Text = table;
                tUser.Text = user;
                tPassword.Text = password;        
            }
            catch(Exception)
            {
                tServer.Text = "beta";
                tBD.Text = "DF_12_DEV";
                tTable.Text = "dbo.df_buffer_request";
                tUser.Text = "sa";
                tPassword.Text = "";
            }
        }

        private void bDefault_Click(object sender, EventArgs e)
        {
            MakeDefaultConnect();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var t = dataGridView1.SelectedRows[0].Index;
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите строку для удаления.",
                                "Информационое сообщение",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Удалить запись с почтой: " + Value + "?",
                                "Информационое сообщение",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Information) ==
                                DialogResult.No)
            {
                return;
            }

            try
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                sAdapter.Update(sTable);
            }
            catch (Exception err)
            {
                MessageBox.Show("Произошла ошибка во время удаления записи: \n\n" +
                                err.Message, "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetConnectionString()
        {
            string connectionString =
                "Data Source=" + Server + ";" +
                "Initial Catalog=" + DB + ";" +
                "User ID=" + User + ";" +
                "Password=" + Password + ";" +
                "Connect Timeout=" + (int)TimeOut.Value + ";";
            return connectionString;
        }

        private async void bFind_Click(object sender, EventArgs e)
        {
            InitializeStartData();
            
            if (Parameter == "" || Value == "")
            {
                MessageBox.Show("Введите данные для поиска.",
                                 "Информационое сообщение",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                DeInitializeData();
                return;
            }
            
            string sql = "select " + "*" + " from " + Table +
                         " where " + Parameter + " = '" + Value + "'";

            int tmp = await Task<int>.Run(() =>
            {
                int result = 0;
                GetData(sql);
                return
                    result;
            });

            DeInitializeData();
        }

        delegate void SetListCallback(List<string> list);

        private void SetList(List<string> list)
        {
            if (this.cbParameter.InvokeRequired)
            {
                SetListCallback d = new SetListCallback(SetList);
                this.Invoke(d, new object[] { list });
            }
            else
            {
                this.cbParameter.Items.Clear();
                int N = list.Count;
                foreach (var el in list)
                {
                    cbParameter.Items.Add(el);
                }
            }
        }

        delegate void SetDataGridCallback(DataTableCollection data);

        private void SetDataGrid(DataTableCollection data)
        {
            if (this.cbParameter.InvokeRequired)
            {
                SetDataGridCallback d = new SetDataGridCallback(SetDataGrid);
                this.Invoke(d, new object[] { data });
            }
            else
            {
                if (data != null)
                    dataGridView1.DataSource = data[0];
                else
                    dataGridView1.DataSource = data;
            }
        }

        private void GetData(string sql)
        {
            try
            {
                try
                {
                    SetDataGrid(null);

                    SqlConnection connection = new SqlConnection(GetConnectionString());
                    connection.Open();
                    sCommand = new SqlCommand(sql, connection);
                    sAdapter = new SqlDataAdapter(sCommand);
                    sBuilder = new SqlCommandBuilder(sAdapter);
                    sDs = new DataSet();
                    sAdapter.Fill(sDs);
                    sTable = sDs.Tables[0];
                    connection.Close();

                    cts.Token.ThrowIfCancellationRequested();

                    SetDataGrid(sDs.Tables);

                    var list = new List<string>();
                    int N = sTable.Columns.Count;
                    for(int i = 0; i < N; ++i)
                    {
                        list.Add(sTable.Columns[i].ColumnName);
                    }
                    SetList(list);
                }
                catch (SqlException)
                {
                    throw;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Произошла ошибка во время работы программы: \n\n" +
                                err.Message, "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeInitializeData()
        {
            ProgressBar.Visible = false;
            MakeDisConnectString();
            bCancel.Visible = false;
            if (cts != null)
            {
                cts.Dispose();
                cts = null;
            }

            //DisposeAllTables();
        }

        private void DisposeAllTables()
        {
            ClearTables(sCommand);
            ClearTables(sAdapter);
            ClearTables(sBuilder);
            ClearTables(sDs);
            ClearTables(sTable);
        }

        private void ClearTables(IDisposable o)
        {
            if (o != null)
            {
                o.Dispose();
                o = null;
            }
        }

        private void InitializeStartData()
        {
            SetUnlockTrue();
            MakeConnectString();
            ProgressBar.Visible = true;
            bCancel.Visible = true;
            cts = new CancellationTokenSource();
            
            /*dataGridView1.DataSource = null;
            DisposeAllTables();*/
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            InitializeStartData();
            string sql = "select " + "*" + " from " + Table;

            int tmp = await Task<int>.Run(() =>
            {
                int result = 0;
                GetData(sql);
                return
                    result;
            });

            DeInitializeData();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (isDataSource())
            {
                if (MessageBox.Show("Внести изменения в БД? ",
                                    "Информационое сообщение",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) ==
                                    DialogResult.No)
                {
                    SetUnlockTrue();
                    button1_Click(sender, e);
                    return;
                }

                try
                {
                    sAdapter.Update(sTable);
                }
                catch (Exception err)
                {
                    MessageBox.Show("Произошла ошибка во время удаления записи: \n\n" +
                                    err.Message, "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    SetUnlockTrue();
                }
            }
        }

        private void SetUnlockTrue()
        {
            bUnlock.Visible = true;
            bSave.Visible = false;
            dataGridView1.ReadOnly = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MakeDefaultConnect();
            button1_Click(sender, e);
        }

        private void bUnlock_Click(object sender, EventArgs e)
        {
            if (isDataSource())
            {
                bUnlock.Visible = false;
                bSave.Visible = true;
                dataGridView1.ReadOnly = false;
            }
        }

        private bool isDataSource()
        {
            if(dataGridView1.DataSource != null)
                return true;
            else
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cts.Cancel();
        }
    }
}
