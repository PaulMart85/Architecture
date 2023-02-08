namespace ClinicDesctop
{
    partial class MainForm
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
            this.listViewClients = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSurName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPatronymic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonLoadClients = new System.Windows.Forms.Button();
            this.tabPets = new System.Windows.Forms.TabControl();
            this.tabClients = new System.Windows.Forms.TabPage();
            this.dateTimePickerClient = new System.Windows.Forms.DateTimePicker();
            this.labelClientBirth = new System.Windows.Forms.Label();
            this.labelClientPatron = new System.Windows.Forms.Label();
            this.textBoxClientPatron = new System.Windows.Forms.TextBox();
            this.labelClientName = new System.Windows.Forms.Label();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.textBoxClientSurName = new System.Windows.Forms.TextBox();
            this.labelClientSurName = new System.Windows.Forms.Label();
            this.labelClientId = new System.Windows.Forms.Label();
            this.buttonCreateClient = new System.Windows.Forms.Button();
            this.buttonUpdateClient = new System.Windows.Forms.Button();
            this.buttonDelClient = new System.Windows.Forms.Button();
            this.buttonClientIdOK = new System.Windows.Forms.Button();
            this.textBoxClientId = new System.Windows.Forms.TextBox();
            this.buttonLoadById = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listViewPets = new System.Windows.Forms.ListView();
            this.columnHeaderPetId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPetName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPetBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonLoadPets = new System.Windows.Forms.Button();
            this.tabPets.SuspendLayout();
            this.tabClients.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewClients
            // 
            this.listViewClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderSurName,
            this.columnHeaderName,
            this.columnHeaderPatronymic});
            this.listViewClients.GridLines = true;
            this.listViewClients.HideSelection = false;
            this.listViewClients.Location = new System.Drawing.Point(6, 6);
            this.listViewClients.Name = "listViewClients";
            this.listViewClients.Size = new System.Drawing.Size(756, 205);
            this.listViewClients.TabIndex = 0;
            this.listViewClients.UseCompatibleStateImageBehavior = false;
            this.listViewClients.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "#";
            // 
            // columnHeaderSurName
            // 
            this.columnHeaderSurName.Text = "Фамилия";
            this.columnHeaderSurName.Width = 200;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Имя";
            this.columnHeaderName.Width = 150;
            // 
            // columnHeaderPatronymic
            // 
            this.columnHeaderPatronymic.Text = "Отчество";
            this.columnHeaderPatronymic.Width = 200;
            // 
            // buttonLoadClients
            // 
            this.buttonLoadClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadClients.BackColor = System.Drawing.Color.Transparent;
            this.buttonLoadClients.Location = new System.Drawing.Point(595, 217);
            this.buttonLoadClients.Name = "buttonLoadClients";
            this.buttonLoadClients.Size = new System.Drawing.Size(134, 41);
            this.buttonLoadClients.TabIndex = 1;
            this.buttonLoadClients.Text = "Получить всех";
            this.buttonLoadClients.UseVisualStyleBackColor = false;
            this.buttonLoadClients.Click += new System.EventHandler(this.buttonLoadClients_Click);
            // 
            // tabPets
            // 
            this.tabPets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPets.Controls.Add(this.tabClients);
            this.tabPets.Controls.Add(this.tabPage2);
            this.tabPets.Location = new System.Drawing.Point(12, 12);
            this.tabPets.Name = "tabPets";
            this.tabPets.SelectedIndex = 0;
            this.tabPets.Size = new System.Drawing.Size(776, 426);
            this.tabPets.TabIndex = 2;
            // 
            // tabClients
            // 
            this.tabClients.Controls.Add(this.dateTimePickerClient);
            this.tabClients.Controls.Add(this.labelClientBirth);
            this.tabClients.Controls.Add(this.labelClientPatron);
            this.tabClients.Controls.Add(this.textBoxClientPatron);
            this.tabClients.Controls.Add(this.labelClientName);
            this.tabClients.Controls.Add(this.textBoxClientName);
            this.tabClients.Controls.Add(this.textBoxClientSurName);
            this.tabClients.Controls.Add(this.labelClientSurName);
            this.tabClients.Controls.Add(this.labelClientId);
            this.tabClients.Controls.Add(this.buttonCreateClient);
            this.tabClients.Controls.Add(this.buttonUpdateClient);
            this.tabClients.Controls.Add(this.buttonDelClient);
            this.tabClients.Controls.Add(this.buttonClientIdOK);
            this.tabClients.Controls.Add(this.textBoxClientId);
            this.tabClients.Controls.Add(this.buttonLoadById);
            this.tabClients.Controls.Add(this.listViewClients);
            this.tabClients.Controls.Add(this.buttonLoadClients);
            this.tabClients.Location = new System.Drawing.Point(4, 25);
            this.tabClients.Name = "tabClients";
            this.tabClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabClients.Size = new System.Drawing.Size(768, 397);
            this.tabClients.TabIndex = 0;
            this.tabClients.Text = "Клиенты";
            this.tabClients.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerClient
            // 
            this.dateTimePickerClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerClient.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerClient.Location = new System.Drawing.Point(595, 264);
            this.dateTimePickerClient.Name = "dateTimePickerClient";
            this.dateTimePickerClient.Size = new System.Drawing.Size(134, 22);
            this.dateTimePickerClient.TabIndex = 17;
            this.dateTimePickerClient.Visible = false;
            // 
            // labelClientBirth
            // 
            this.labelClientBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClientBirth.AutoSize = true;
            this.labelClientBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClientBirth.Location = new System.Drawing.Point(449, 266);
            this.labelClientBirth.Name = "labelClientBirth";
            this.labelClientBirth.Size = new System.Drawing.Size(140, 20);
            this.labelClientBirth.TabIndex = 16;
            this.labelClientBirth.Text = "дата рождения";
            this.labelClientBirth.Visible = false;
            // 
            // labelClientPatron
            // 
            this.labelClientPatron.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClientPatron.AutoSize = true;
            this.labelClientPatron.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClientPatron.Location = new System.Drawing.Point(221, 338);
            this.labelClientPatron.Name = "labelClientPatron";
            this.labelClientPatron.Size = new System.Drawing.Size(88, 20);
            this.labelClientPatron.TabIndex = 14;
            this.labelClientPatron.Text = "отчество";
            this.labelClientPatron.Visible = false;
            // 
            // textBoxClientPatron
            // 
            this.textBoxClientPatron.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientPatron.Location = new System.Drawing.Point(315, 338);
            this.textBoxClientPatron.Name = "textBoxClientPatron";
            this.textBoxClientPatron.Size = new System.Drawing.Size(100, 22);
            this.textBoxClientPatron.TabIndex = 13;
            this.textBoxClientPatron.Visible = false;
            // 
            // labelClientName
            // 
            this.labelClientName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClientName.AutoSize = true;
            this.labelClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClientName.Location = new System.Drawing.Point(268, 302);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(41, 20);
            this.labelClientName.TabIndex = 12;
            this.labelClientName.Text = "имя";
            this.labelClientName.Visible = false;
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientName.Location = new System.Drawing.Point(315, 302);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(100, 22);
            this.textBoxClientName.TabIndex = 11;
            this.textBoxClientName.Visible = false;
            // 
            // textBoxClientSurName
            // 
            this.textBoxClientSurName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientSurName.Location = new System.Drawing.Point(315, 264);
            this.textBoxClientSurName.Name = "textBoxClientSurName";
            this.textBoxClientSurName.Size = new System.Drawing.Size(100, 22);
            this.textBoxClientSurName.TabIndex = 10;
            this.textBoxClientSurName.Visible = false;
            // 
            // labelClientSurName
            // 
            this.labelClientSurName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClientSurName.AutoSize = true;
            this.labelClientSurName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClientSurName.Location = new System.Drawing.Point(222, 264);
            this.labelClientSurName.Name = "labelClientSurName";
            this.labelClientSurName.Size = new System.Drawing.Size(87, 20);
            this.labelClientSurName.TabIndex = 9;
            this.labelClientSurName.Text = "фамилия";
            this.labelClientSurName.Visible = false;
            // 
            // labelClientId
            // 
            this.labelClientId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClientId.AutoSize = true;
            this.labelClientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClientId.Location = new System.Drawing.Point(41, 264);
            this.labelClientId.Name = "labelClientId";
            this.labelClientId.Size = new System.Drawing.Size(22, 20);
            this.labelClientId.TabIndex = 8;
            this.labelClientId.Text = "id";
            this.labelClientId.Visible = false;
            // 
            // buttonCreateClient
            // 
            this.buttonCreateClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreateClient.Location = new System.Drawing.Point(35, 217);
            this.buttonCreateClient.Name = "buttonCreateClient";
            this.buttonCreateClient.Size = new System.Drawing.Size(134, 41);
            this.buttonCreateClient.TabIndex = 7;
            this.buttonCreateClient.Text = "Создать";
            this.buttonCreateClient.UseVisualStyleBackColor = true;
            this.buttonCreateClient.Click += new System.EventHandler(this.buttonCreateClient_Click);
            // 
            // buttonUpdateClient
            // 
            this.buttonUpdateClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdateClient.Location = new System.Drawing.Point(175, 217);
            this.buttonUpdateClient.Name = "buttonUpdateClient";
            this.buttonUpdateClient.Size = new System.Drawing.Size(134, 41);
            this.buttonUpdateClient.TabIndex = 6;
            this.buttonUpdateClient.Text = "Обновить";
            this.buttonUpdateClient.UseVisualStyleBackColor = true;
            this.buttonUpdateClient.Click += new System.EventHandler(this.buttonUpdateClient_Click);
            // 
            // buttonDelClient
            // 
            this.buttonDelClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelClient.Location = new System.Drawing.Point(315, 217);
            this.buttonDelClient.Name = "buttonDelClient";
            this.buttonDelClient.Size = new System.Drawing.Size(134, 41);
            this.buttonDelClient.TabIndex = 5;
            this.buttonDelClient.Text = "Удалить по id";
            this.buttonDelClient.UseVisualStyleBackColor = true;
            this.buttonDelClient.Click += new System.EventHandler(this.buttonDelClient_Click);
            // 
            // buttonClientIdOK
            // 
            this.buttonClientIdOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClientIdOK.Location = new System.Drawing.Point(6, 368);
            this.buttonClientIdOK.Name = "buttonClientIdOK";
            this.buttonClientIdOK.Size = new System.Drawing.Size(756, 23);
            this.buttonClientIdOK.TabIndex = 4;
            this.buttonClientIdOK.Text = "OK";
            this.buttonClientIdOK.UseVisualStyleBackColor = true;
            this.buttonClientIdOK.Visible = false;
            this.buttonClientIdOK.Click += new System.EventHandler(this.buttonClientIdOK_Click);
            // 
            // textBoxClientId
            // 
            this.textBoxClientId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientId.Location = new System.Drawing.Point(69, 264);
            this.textBoxClientId.Name = "textBoxClientId";
            this.textBoxClientId.Size = new System.Drawing.Size(100, 22);
            this.textBoxClientId.TabIndex = 3;
            this.textBoxClientId.Visible = false;
            this.textBoxClientId.TextChanged += new System.EventHandler(this.textBoxClientId_TextChanged);
            // 
            // buttonLoadById
            // 
            this.buttonLoadById.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadById.Location = new System.Drawing.Point(455, 217);
            this.buttonLoadById.Name = "buttonLoadById";
            this.buttonLoadById.Size = new System.Drawing.Size(134, 41);
            this.buttonLoadById.TabIndex = 2;
            this.buttonLoadById.Text = "Получить по id";
            this.buttonLoadById.UseVisualStyleBackColor = true;
            this.buttonLoadById.Click += new System.EventHandler(this.buttonLoadById_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonLoadPets);
            this.tabPage2.Controls.Add(this.listViewPets);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Питомцы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listViewPets
            // 
            this.listViewPets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewPets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderPetId,
            this.columnHeaderPetName,
            this.columnHeaderPetBirth});
            this.listViewPets.GridLines = true;
            this.listViewPets.HideSelection = false;
            this.listViewPets.Location = new System.Drawing.Point(6, 6);
            this.listViewPets.Name = "listViewPets";
            this.listViewPets.Size = new System.Drawing.Size(756, 296);
            this.listViewPets.TabIndex = 0;
            this.listViewPets.UseCompatibleStateImageBehavior = false;
            this.listViewPets.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderPetId
            // 
            this.columnHeaderPetId.Text = "#";
            // 
            // columnHeaderPetName
            // 
            this.columnHeaderPetName.Text = "Имя";
            this.columnHeaderPetName.Width = 200;
            // 
            // columnHeaderPetBirth
            // 
            this.columnHeaderPetBirth.Text = "Дата рождения";
            this.columnHeaderPetBirth.Width = 100;
            // 
            // buttonLoadPets
            // 
            this.buttonLoadPets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadPets.Location = new System.Drawing.Point(6, 345);
            this.buttonLoadPets.Name = "buttonLoadPets";
            this.buttonLoadPets.Size = new System.Drawing.Size(756, 46);
            this.buttonLoadPets.TabIndex = 1;
            this.buttonLoadPets.Text = "Список всех питомцев";
            this.buttonLoadPets.UseVisualStyleBackColor = true;
            this.buttonLoadPets.Click += new System.EventHandler(this.buttonLoadPets_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabPets);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Моя клиника";
            this.tabPets.ResumeLayout(false);
            this.tabClients.ResumeLayout(false);
            this.tabClients.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewClients;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderSurName;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderPatronymic;
        private System.Windows.Forms.Button buttonLoadClients;
        private System.Windows.Forms.TabControl tabPets;
        private System.Windows.Forms.TabPage tabClients;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonLoadById;
        private System.Windows.Forms.TextBox textBoxClientId;
        private System.Windows.Forms.Button buttonClientIdOK;
        private System.Windows.Forms.Button buttonDelClient;
        private System.Windows.Forms.Button buttonCreateClient;
        private System.Windows.Forms.Button buttonUpdateClient;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.TextBox textBoxClientSurName;
        private System.Windows.Forms.Label labelClientSurName;
        private System.Windows.Forms.Label labelClientId;
        private System.Windows.Forms.Label labelClientPatron;
        private System.Windows.Forms.TextBox textBoxClientPatron;
        private System.Windows.Forms.Label labelClientBirth;
        private System.Windows.Forms.DateTimePicker dateTimePickerClient;
        private System.Windows.Forms.ListView listViewPets;
        private System.Windows.Forms.ColumnHeader columnHeaderPetId;
        private System.Windows.Forms.ColumnHeader columnHeaderPetName;
        private System.Windows.Forms.ColumnHeader columnHeaderPetBirth;
        private System.Windows.Forms.Button buttonLoadPets;
    }
}

