namespace WindowsFormsChat
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hisotyMessagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSendMessage = new System.Windows.Forms.Button();
            this.textBoxInputMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonConnectToServer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTest = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hisotyMessagesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxHistory
            // 
            this.listBoxHistory.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bindingSource1, "IsConnect", true));
            this.listBoxHistory.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.bindingSource1, "IsConnect", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.listBoxHistory.DataSource = this.hisotyMessagesBindingSource;
            this.listBoxHistory.FormattingEnabled = true;
            this.listBoxHistory.ItemHeight = 18;
            this.listBoxHistory.Location = new System.Drawing.Point(32, 32);
            this.listBoxHistory.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listBoxHistory.Name = "listBoxHistory";
            this.listBoxHistory.Size = new System.Drawing.Size(481, 220);
            this.listBoxHistory.TabIndex = 0;
            this.listBoxHistory.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(WindowsFormsChat.Model);
            // 
            // hisotyMessagesBindingSource
            // 
            this.hisotyMessagesBindingSource.DataMember = "HisotyMessages";
            this.hisotyMessagesBindingSource.DataSource = this.bindingSource1;
            // 
            // buttonSendMessage
            // 
            this.buttonSendMessage.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.bindingSource1, "IsConnect", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonSendMessage.Location = new System.Drawing.Point(680, 383);
            this.buttonSendMessage.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonSendMessage.Name = "buttonSendMessage";
            this.buttonSendMessage.Size = new System.Drawing.Size(134, 31);
            this.buttonSendMessage.TabIndex = 1;
            this.buttonSendMessage.Text = "Отправить";
            this.buttonSendMessage.UseVisualStyleBackColor = true;
            this.buttonSendMessage.Click += new System.EventHandler(this.buttonSendMessage_Click);
            // 
            // textBoxInputMessage
            // 
            this.textBoxInputMessage.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bindingSource1, "IsConnect", true));
            this.textBoxInputMessage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "InputMessage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxInputMessage.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.bindingSource1, "IsConnect", true));
            this.textBoxInputMessage.Location = new System.Drawing.Point(32, 289);
            this.textBoxInputMessage.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxInputMessage.Multiline = true;
            this.textBoxInputMessage.Name = "textBoxInputMessage";
            this.textBoxInputMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInputMessage.Size = new System.Drawing.Size(782, 86);
            this.textBoxInputMessage.TabIndex = 2;
            this.textBoxInputMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxInputMessage_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(570, 267);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Отправить сообщение Ctrl+Enter";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxServer
            // 
            this.textBoxServer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "ServerAddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxServer.Location = new System.Drawing.Point(144, 24);
            this.textBoxServer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(121, 24);
            this.textBoxServer.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Адрес сервера";
            // 
            // buttonConnectToServer
            // 
            this.buttonConnectToServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConnectToServer.Location = new System.Drawing.Point(110, 121);
            this.buttonConnectToServer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonConnectToServer.Name = "buttonConnectToServer";
            this.buttonConnectToServer.Size = new System.Drawing.Size(155, 27);
            this.buttonConnectToServer.TabIndex = 1;
            this.buttonConnectToServer.Text = "Подключиться";
            this.buttonConnectToServer.UseVisualStyleBackColor = true;
            this.buttonConnectToServer.Click += new System.EventHandler(this.buttonConnectToServer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "История";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxName.Location = new System.Drawing.Point(91, 89);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(174, 24);
            this.textBoxName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ваше имя";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "ServerPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.textBox1.Location = new System.Drawing.Point(144, 57);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 24);
            this.textBox1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Порт сервера";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxServer);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonConnectToServer);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(541, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 155);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры подключения";
            // 
            // buttonTest
            // 
            this.buttonTest.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bindingSource1, "IsConnect", true));
            this.buttonTest.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.bindingSource1, "IsConnect", true));
            this.buttonTest.Location = new System.Drawing.Point(206, 385);
            this.buttonTest.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(134, 31);
            this.buttonTest.TabIndex = 1;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(38, 385);
            this.buttonAbout.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(134, 31);
            this.buttonAbout.TabIndex = 1;
            this.buttonAbout.Text = "О программе";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(537, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Подключен";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "IsConnect", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label7.Location = new System.Drawing.Point(641, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "{Статус подключения}";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(826, 429);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInputMessage);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.buttonSendMessage);
            this.Controls.Add(this.listBoxHistory);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hisotyMessagesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxHistory;
        private System.Windows.Forms.Button buttonSendMessage;
        private System.Windows.Forms.TextBox textBoxInputMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonConnectToServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource hisotyMessagesBindingSource;
    }
}

