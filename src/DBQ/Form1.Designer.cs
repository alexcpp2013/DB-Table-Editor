﻿namespace DBQ
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tTable = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.tUser = new System.Windows.Forms.TextBox();
            this.tBD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bDefault = new System.Windows.Forms.Button();
            this.tServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.bUnlock = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbParameter = new System.Windows.Forms.ComboBox();
            this.bSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bFind = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.tValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new DBQ.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.TimeOut = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeOut)).BeginInit();
            this.SuspendLayout();
            // 
            // bClose
            // 
            this.bClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bClose.Location = new System.Drawing.Point(659, 442);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 23);
            this.bClose.TabIndex = 0;
            this.bClose.Text = "Выход";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TimeOut);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tTable);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tPassword);
            this.groupBox1.Controls.Add(this.tUser);
            this.groupBox1.Controls.Add(this.tBD);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.bDefault);
            this.groupBox1.Controls.Add(this.tServer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 117);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "База Данных";
            // 
            // tTable
            // 
            this.tTable.Location = new System.Drawing.Point(117, 81);
            this.tTable.Name = "tTable";
            this.tTable.Size = new System.Drawing.Size(201, 20);
            this.tTable.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Таблица";
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(490, 49);
            this.tPassword.Name = "tPassword";
            this.tPassword.Size = new System.Drawing.Size(201, 20);
            this.tPassword.TabIndex = 8;
            // 
            // tUser
            // 
            this.tUser.Location = new System.Drawing.Point(490, 20);
            this.tUser.Name = "tUser";
            this.tUser.Size = new System.Drawing.Size(201, 20);
            this.tUser.TabIndex = 7;
            // 
            // tBD
            // 
            this.tBD.Location = new System.Drawing.Point(117, 49);
            this.tBD.Name = "tBD";
            this.tBD.Size = new System.Drawing.Size(201, 20);
            this.tBD.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Пользователь";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "БД";
            // 
            // bDefault
            // 
            this.bDefault.Location = new System.Drawing.Point(369, 81);
            this.bDefault.Name = "bDefault";
            this.bDefault.Size = new System.Drawing.Size(100, 23);
            this.bDefault.TabIndex = 2;
            this.bDefault.Text = "По умолчанию";
            this.bDefault.UseVisualStyleBackColor = true;
            this.bDefault.Click += new System.EventHandler(this.bDefault_Click);
            // 
            // tServer
            // 
            this.tServer.Location = new System.Drawing.Point(117, 19);
            this.tServer.Name = "tServer";
            this.tServer.Size = new System.Drawing.Size(201, 20);
            this.tServer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сервер";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bCancel);
            this.groupBox2.Controls.Add(this.bUnlock);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbParameter);
            this.groupBox2.Controls.Add(this.bSave);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.bFind);
            this.groupBox2.Controls.Add(this.ProgressBar);
            this.groupBox2.Controls.Add(this.tValue);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.bDelete);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(731, 302);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат Запроса";
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(583, 65);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(123, 23);
            this.bCancel.TabIndex = 47;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Visible = false;
            this.bCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // bUnlock
            // 
            this.bUnlock.Location = new System.Drawing.Point(443, 65);
            this.bUnlock.Name = "bUnlock";
            this.bUnlock.Size = new System.Drawing.Size(123, 23);
            this.bUnlock.TabIndex = 46;
            this.bUnlock.Text = "Изменить";
            this.bUnlock.UseVisualStyleBackColor = true;
            this.bUnlock.Click += new System.EventHandler(this.bUnlock_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Значение";
            // 
            // cbParameter
            // 
            this.cbParameter.FormattingEnabled = true;
            this.cbParameter.Location = new System.Drawing.Point(111, 21);
            this.cbParameter.Name = "cbParameter";
            this.cbParameter.Size = new System.Drawing.Size(201, 21);
            this.cbParameter.TabIndex = 44;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(442, 64);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(123, 23);
            this.bSave.TabIndex = 43;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Visible = false;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "Найти Все";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bFind
            // 
            this.bFind.Location = new System.Drawing.Point(164, 64);
            this.bFind.Name = "bFind";
            this.bFind.Size = new System.Drawing.Size(123, 23);
            this.bFind.TabIndex = 41;
            this.bFind.Text = "Найти Указанную";
            this.bFind.UseVisualStyleBackColor = true;
            this.bFind.Click += new System.EventHandler(this.bFind_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProgressBar.Location = new System.Drawing.Point(3, 94);
            this.ProgressBar.MarqueeAnimationSpeed = 10;
            this.ProgressBar.Maximum = 25;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(725, 22);
            this.ProgressBar.Step = 20;
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.ProgressBar.TabIndex = 5;
            this.ProgressBar.Visible = false;
            // 
            // tValue
            // 
            this.tValue.Location = new System.Drawing.Point(484, 17);
            this.tValue.Name = "tValue";
            this.tValue.Size = new System.Drawing.Size(201, 20);
            this.tValue.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Столбец";
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(304, 65);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(123, 23);
            this.bDelete.TabIndex = 2;
            this.bDelete.Text = "Удалить";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(725, 183);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(487, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Таймаут (сек.)";
            // 
            // TimeOut
            // 
            this.TimeOut.Location = new System.Drawing.Point(611, 79);
            this.TimeOut.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.TimeOut.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TimeOut.Name = "TimeOut";
            this.TimeOut.Size = new System.Drawing.Size(80, 20);
            this.TimeOut.TabIndex = 19;
            this.TimeOut.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bClose;
            this.ClientSize = new System.Drawing.Size(746, 474);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с БД";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Button bDefault;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.TextBox tUser;
        private System.Windows.Forms.TextBox tBD;
        private System.Windows.Forms.Button bFind;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbParameter;
        private System.Windows.Forms.TextBox tTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bUnlock;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.NumericUpDown TimeOut;
        private System.Windows.Forms.Label label8;
    }
}

