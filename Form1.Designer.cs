
namespace File_encryption_decryption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TDES_file_select_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.Minimize_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TDES_encrypt_button = new System.Windows.Forms.Button();
            this.tDES_key_textBox = new System.Windows.Forms.TextBox();
            this.TDES_decrypt_button = new System.Windows.Forms.Button();
            this.TripleDES_panel = new System.Windows.Forms.Panel();
            this.keyTDesGenPicktureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DES_file_select_button = new System.Windows.Forms.Button();
            this.DES_panel = new System.Windows.Forms.Panel();
            this.keyDesGenPicktureBox = new System.Windows.Forms.PictureBox();
            this.DES_decrypt_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dES_key_textBox = new System.Windows.Forms.TextBox();
            this.DES_encrypt_button = new System.Windows.Forms.Button();
            this.path_textBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.keyAesGenPicktureBox = new System.Windows.Forms.PictureBox();
            this.select_public_key_button = new System.Windows.Forms.PictureBox();
            this.AES_panel = new System.Windows.Forms.Panel();
            this.AES_decrypt_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.aES_key_textBox = new System.Windows.Forms.TextBox();
            this.AES_encrypt_button = new System.Windows.Forms.Button();
            this.AES_file_select_button = new System.Windows.Forms.Button();
            this.RSA_panel = new System.Windows.Forms.Panel();
            this.select_private_key_button = new System.Windows.Forms.PictureBox();
            this.RSA_decrypt_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rSA_private_key_textBox = new System.Windows.Forms.TextBox();
            this.rSA_public_key_textBox = new System.Windows.Forms.TextBox();
            this.RSA_encrypt_button = new System.Windows.Forms.Button();
            this.RSA_file_select_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.TripleDES_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyTDesGenPicktureBox)).BeginInit();
            this.DES_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyDesGenPicktureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyAesGenPicktureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.select_public_key_button)).BeginInit();
            this.AES_panel.SuspendLayout();
            this.RSA_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.select_private_key_button)).BeginInit();
            this.SuspendLayout();
            // 
            // TDES_file_select_button
            // 
            this.TDES_file_select_button.AutoSize = true;
            this.TDES_file_select_button.BackColor = System.Drawing.SystemColors.Control;
            this.TDES_file_select_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TDES_file_select_button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.TDES_file_select_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TDES_file_select_button.Location = new System.Drawing.Point(199, 167);
            this.TDES_file_select_button.Name = "TDES_file_select_button";
            this.TDES_file_select_button.Size = new System.Drawing.Size(123, 30);
            this.TDES_file_select_button.TabIndex = 0;
            this.TDES_file_select_button.TabStop = false;
            this.TDES_file_select_button.Text = "Оберіть файл";
            this.TDES_file_select_button.UseVisualStyleBackColor = false;
            this.TDES_file_select_button.Click += new System.EventHandler(this.File_select_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit_button.BackColor = System.Drawing.Color.Transparent;
            this.Exit_button.BackgroundImage = global::File_encryption_decryption.Properties.Resources.delete_sign;
            this.Exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_button.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.Exit_button.ForeColor = System.Drawing.Color.White;
            this.Exit_button.Location = new System.Drawing.Point(1270, 4);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(30, 30);
            this.Exit_button.TabIndex = 3;
            this.Exit_button.UseVisualStyleBackColor = false;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // Minimize_button
            // 
            this.Minimize_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize_button.BackgroundImage = global::File_encryption_decryption.Properties.Resources.minus_math;
            this.Minimize_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Minimize_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Minimize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Minimize_button.ForeColor = System.Drawing.Color.Transparent;
            this.Minimize_button.Location = new System.Drawing.Point(1234, 3);
            this.Minimize_button.Name = "Minimize_button";
            this.Minimize_button.Size = new System.Drawing.Size(30, 30);
            this.Minimize_button.TabIndex = 4;
            this.Minimize_button.UseVisualStyleBackColor = true;
            this.Minimize_button.Click += new System.EventHandler(this.Minimize_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Exit_button);
            this.panel1.Controls.Add(this.Minimize_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1307, 37);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Encoder/Decoder";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.comboBox1.Items.AddRange(new object[] {
            "DES",
            "TripleDES",
            "AES",
            "RSA"});
            this.comboBox1.Location = new System.Drawing.Point(265, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // TDES_encrypt_button
            // 
            this.TDES_encrypt_button.AutoSize = true;
            this.TDES_encrypt_button.BackColor = System.Drawing.Color.Transparent;
            this.TDES_encrypt_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TDES_encrypt_button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.TDES_encrypt_button.Image = ((System.Drawing.Image)(resources.GetObject("TDES_encrypt_button.Image")));
            this.TDES_encrypt_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TDES_encrypt_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TDES_encrypt_button.Location = new System.Drawing.Point(6, 85);
            this.TDES_encrypt_button.Name = "TDES_encrypt_button";
            this.TDES_encrypt_button.Size = new System.Drawing.Size(149, 37);
            this.TDES_encrypt_button.TabIndex = 9;
            this.TDES_encrypt_button.Text = "Шифрувати";
            this.TDES_encrypt_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TDES_encrypt_button.UseVisualStyleBackColor = false;
            this.TDES_encrypt_button.Click += new System.EventHandler(this.TDES_encrypt_button_Click);
            // 
            // tDES_key_textBox
            // 
            this.tDES_key_textBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.tDES_key_textBox.Location = new System.Drawing.Point(59, 22);
            this.tDES_key_textBox.MaxLength = 16;
            this.tDES_key_textBox.Name = "tDES_key_textBox";
            this.tDES_key_textBox.Size = new System.Drawing.Size(191, 25);
            this.tDES_key_textBox.TabIndex = 10;
            this.tDES_key_textBox.Text = "tripleDES";
            // 
            // TDES_decrypt_button
            // 
            this.TDES_decrypt_button.AutoSize = true;
            this.TDES_decrypt_button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.TDES_decrypt_button.Image = global::File_encryption_decryption.Properties.Resources.unlock__1_;
            this.TDES_decrypt_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TDES_decrypt_button.Location = new System.Drawing.Point(183, 85);
            this.TDES_decrypt_button.Name = "TDES_decrypt_button";
            this.TDES_decrypt_button.Size = new System.Drawing.Size(149, 37);
            this.TDES_decrypt_button.TabIndex = 11;
            this.TDES_decrypt_button.Text = "Розшифрувати";
            this.TDES_decrypt_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TDES_decrypt_button.UseVisualStyleBackColor = true;
            this.TDES_decrypt_button.Click += new System.EventHandler(this.TDES_decrypt_button_Click);
            // 
            // TripleDES_panel
            // 
            this.TripleDES_panel.BackColor = System.Drawing.Color.Transparent;
            this.TripleDES_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TripleDES_panel.Controls.Add(this.keyTDesGenPicktureBox);
            this.TripleDES_panel.Controls.Add(this.TDES_decrypt_button);
            this.TripleDES_panel.Controls.Add(this.label2);
            this.TripleDES_panel.Controls.Add(this.tDES_key_textBox);
            this.TripleDES_panel.Controls.Add(this.TDES_encrypt_button);
            this.TripleDES_panel.Controls.Add(this.TDES_file_select_button);
            this.TripleDES_panel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.TripleDES_panel.Location = new System.Drawing.Point(425, 180);
            this.TripleDES_panel.Name = "TripleDES_panel";
            this.TripleDES_panel.Size = new System.Drawing.Size(345, 234);
            this.TripleDES_panel.TabIndex = 12;
            this.TripleDES_panel.Visible = false;
            // 
            // keyTDesGenPicktureBox
            // 
            this.keyTDesGenPicktureBox.BackColor = System.Drawing.SystemColors.Control;
            this.keyTDesGenPicktureBox.BackgroundImage = global::File_encryption_decryption.Properties.Resources.key_chain1;
            this.keyTDesGenPicktureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.keyTDesGenPicktureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyTDesGenPicktureBox.Location = new System.Drawing.Point(261, 20);
            this.keyTDesGenPicktureBox.Name = "keyTDesGenPicktureBox";
            this.keyTDesGenPicktureBox.Size = new System.Drawing.Size(30, 30);
            this.keyTDesGenPicktureBox.TabIndex = 15;
            this.keyTDesGenPicktureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.keyTDesGenPicktureBox, "Ключ представляє собою деякий пароль  для шифрування\r\nНатисніть для автоматичної " +
        "генерації ключа.");
            this.keyTDesGenPicktureBox.Click += new System.EventHandler(this.RandomKeyGenarator);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ключ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(30, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Оберіть метод шифрування:";
            // 
            // DES_file_select_button
            // 
            this.DES_file_select_button.AutoSize = true;
            this.DES_file_select_button.BackColor = System.Drawing.SystemColors.Control;
            this.DES_file_select_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DES_file_select_button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.DES_file_select_button.Location = new System.Drawing.Point(202, 141);
            this.DES_file_select_button.Name = "DES_file_select_button";
            this.DES_file_select_button.Size = new System.Drawing.Size(123, 30);
            this.DES_file_select_button.TabIndex = 0;
            this.DES_file_select_button.TabStop = false;
            this.DES_file_select_button.Text = "Оберіть файл";
            this.DES_file_select_button.UseVisualStyleBackColor = false;
            this.DES_file_select_button.Click += new System.EventHandler(this.File_select_button_Click);
            // 
            // DES_panel
            // 
            this.DES_panel.BackColor = System.Drawing.Color.Transparent;
            this.DES_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DES_panel.Controls.Add(this.keyDesGenPicktureBox);
            this.DES_panel.Controls.Add(this.DES_decrypt_button);
            this.DES_panel.Controls.Add(this.label7);
            this.DES_panel.Controls.Add(this.dES_key_textBox);
            this.DES_panel.Controls.Add(this.DES_encrypt_button);
            this.DES_panel.Controls.Add(this.DES_file_select_button);
            this.DES_panel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.DES_panel.Location = new System.Drawing.Point(384, 217);
            this.DES_panel.Name = "DES_panel";
            this.DES_panel.Size = new System.Drawing.Size(345, 234);
            this.DES_panel.TabIndex = 12;
            this.DES_panel.Visible = false;
            // 
            // keyDesGenPicktureBox
            // 
            this.keyDesGenPicktureBox.BackColor = System.Drawing.SystemColors.Control;
            this.keyDesGenPicktureBox.BackgroundImage = global::File_encryption_decryption.Properties.Resources.key_chain1;
            this.keyDesGenPicktureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.keyDesGenPicktureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyDesGenPicktureBox.Location = new System.Drawing.Point(261, 20);
            this.keyDesGenPicktureBox.Name = "keyDesGenPicktureBox";
            this.keyDesGenPicktureBox.Size = new System.Drawing.Size(30, 30);
            this.keyDesGenPicktureBox.TabIndex = 18;
            this.keyDesGenPicktureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.keyDesGenPicktureBox, "Ключ представляє собою деякий пароль  для шифрування\r\nНатисніть для автоматичної " +
        "генерації ключа.");
            this.keyDesGenPicktureBox.Click += new System.EventHandler(this.RandomKeyGenarator);
            // 
            // DES_decrypt_button
            // 
            this.DES_decrypt_button.AutoSize = true;
            this.DES_decrypt_button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.DES_decrypt_button.Image = global::File_encryption_decryption.Properties.Resources.unlock__1_;
            this.DES_decrypt_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DES_decrypt_button.Location = new System.Drawing.Point(183, 85);
            this.DES_decrypt_button.Name = "DES_decrypt_button";
            this.DES_decrypt_button.Size = new System.Drawing.Size(149, 37);
            this.DES_decrypt_button.TabIndex = 11;
            this.DES_decrypt_button.Text = "Розшифрувати";
            this.DES_decrypt_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DES_decrypt_button.UseVisualStyleBackColor = true;
            this.DES_decrypt_button.Click += new System.EventHandler(this.DES_decrypt_button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(3, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ключ:";
            // 
            // dES_key_textBox
            // 
            this.dES_key_textBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.dES_key_textBox.Location = new System.Drawing.Point(59, 22);
            this.dES_key_textBox.MaxLength = 8;
            this.dES_key_textBox.Name = "dES_key_textBox";
            this.dES_key_textBox.Size = new System.Drawing.Size(191, 25);
            this.dES_key_textBox.TabIndex = 10;
            this.dES_key_textBox.Text = "DES45678";
            // 
            // DES_encrypt_button
            // 
            this.DES_encrypt_button.AutoSize = true;
            this.DES_encrypt_button.BackColor = System.Drawing.Color.Transparent;
            this.DES_encrypt_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DES_encrypt_button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.DES_encrypt_button.Image = ((System.Drawing.Image)(resources.GetObject("DES_encrypt_button.Image")));
            this.DES_encrypt_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DES_encrypt_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DES_encrypt_button.Location = new System.Drawing.Point(6, 85);
            this.DES_encrypt_button.Name = "DES_encrypt_button";
            this.DES_encrypt_button.Size = new System.Drawing.Size(149, 37);
            this.DES_encrypt_button.TabIndex = 9;
            this.DES_encrypt_button.Text = "Шифрувати";
            this.DES_encrypt_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DES_encrypt_button.UseVisualStyleBackColor = false;
            this.DES_encrypt_button.Click += new System.EventHandler(this.DES_encrypt_button_Click);
            // 
            // path_textBox
            // 
            this.path_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.path_textBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.path_textBox.Location = new System.Drawing.Point(33, 148);
            this.path_textBox.Name = "path_textBox";
            this.path_textBox.ReadOnly = true;
            this.path_textBox.Size = new System.Drawing.Size(378, 25);
            this.path_textBox.TabIndex = 1;
            this.path_textBox.TabStop = false;
            this.path_textBox.WordWrap = false;
            // 
            // keyAesGenPicktureBox
            // 
            this.keyAesGenPicktureBox.BackColor = System.Drawing.SystemColors.Control;
            this.keyAesGenPicktureBox.BackgroundImage = global::File_encryption_decryption.Properties.Resources.key_chain1;
            this.keyAesGenPicktureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.keyAesGenPicktureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyAesGenPicktureBox.Location = new System.Drawing.Point(260, 20);
            this.keyAesGenPicktureBox.Name = "keyAesGenPicktureBox";
            this.keyAesGenPicktureBox.Size = new System.Drawing.Size(30, 30);
            this.keyAesGenPicktureBox.TabIndex = 18;
            this.keyAesGenPicktureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.keyAesGenPicktureBox, "Ключ представляє собою деякий пароль  для шифрування\r\nНатисніть для автоматичної " +
        "генерації ключа.");
            this.keyAesGenPicktureBox.Click += new System.EventHandler(this.RandomKeyGenarator);
            // 
            // select_public_key_button
            // 
            this.select_public_key_button.BackColor = System.Drawing.SystemColors.Control;
            this.select_public_key_button.BackgroundImage = global::File_encryption_decryption.Properties.Resources.key_chain1;
            this.select_public_key_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.select_public_key_button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.select_public_key_button.Location = new System.Drawing.Point(355, 19);
            this.select_public_key_button.Name = "select_public_key_button";
            this.select_public_key_button.Size = new System.Drawing.Size(30, 30);
            this.select_public_key_button.TabIndex = 18;
            this.select_public_key_button.TabStop = false;
            this.toolTip1.SetToolTip(this.select_public_key_button, "Ключ представляє собою деякий пароль  для шифрування");
            this.select_public_key_button.Click += new System.EventHandler(this.select_public_key_button_Click);
            // 
            // AES_panel
            // 
            this.AES_panel.BackColor = System.Drawing.Color.Transparent;
            this.AES_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AES_panel.Controls.Add(this.keyAesGenPicktureBox);
            this.AES_panel.Controls.Add(this.AES_decrypt_button);
            this.AES_panel.Controls.Add(this.label4);
            this.AES_panel.Controls.Add(this.aES_key_textBox);
            this.AES_panel.Controls.Add(this.AES_encrypt_button);
            this.AES_panel.Controls.Add(this.AES_file_select_button);
            this.AES_panel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.AES_panel.Location = new System.Drawing.Point(429, 164);
            this.AES_panel.Name = "AES_panel";
            this.AES_panel.Size = new System.Drawing.Size(345, 234);
            this.AES_panel.TabIndex = 16;
            this.AES_panel.Visible = false;
            // 
            // AES_decrypt_button
            // 
            this.AES_decrypt_button.AutoSize = true;
            this.AES_decrypt_button.BackColor = System.Drawing.Color.Transparent;
            this.AES_decrypt_button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.AES_decrypt_button.Image = global::File_encryption_decryption.Properties.Resources.unlock__1_;
            this.AES_decrypt_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AES_decrypt_button.Location = new System.Drawing.Point(183, 85);
            this.AES_decrypt_button.Name = "AES_decrypt_button";
            this.AES_decrypt_button.Size = new System.Drawing.Size(149, 37);
            this.AES_decrypt_button.TabIndex = 11;
            this.AES_decrypt_button.Text = "Розшифрувати";
            this.AES_decrypt_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AES_decrypt_button.UseVisualStyleBackColor = false;
            this.AES_decrypt_button.Click += new System.EventHandler(this.AES_decrypt_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ключ:";
            // 
            // aES_key_textBox
            // 
            this.aES_key_textBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.aES_key_textBox.Location = new System.Drawing.Point(59, 22);
            this.aES_key_textBox.MaxLength = 100;
            this.aES_key_textBox.Multiline = true;
            this.aES_key_textBox.Name = "aES_key_textBox";
            this.aES_key_textBox.Size = new System.Drawing.Size(191, 57);
            this.aES_key_textBox.TabIndex = 10;
            this.aES_key_textBox.Text = "aes45678";
            // 
            // AES_encrypt_button
            // 
            this.AES_encrypt_button.AutoSize = true;
            this.AES_encrypt_button.BackColor = System.Drawing.Color.Transparent;
            this.AES_encrypt_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AES_encrypt_button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.AES_encrypt_button.Image = ((System.Drawing.Image)(resources.GetObject("AES_encrypt_button.Image")));
            this.AES_encrypt_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AES_encrypt_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AES_encrypt_button.Location = new System.Drawing.Point(6, 85);
            this.AES_encrypt_button.Name = "AES_encrypt_button";
            this.AES_encrypt_button.Size = new System.Drawing.Size(149, 37);
            this.AES_encrypt_button.TabIndex = 9;
            this.AES_encrypt_button.Text = "Шифрувати";
            this.AES_encrypt_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AES_encrypt_button.UseVisualStyleBackColor = false;
            this.AES_encrypt_button.Click += new System.EventHandler(this.AES_encrypt_button_Click);
            // 
            // AES_file_select_button
            // 
            this.AES_file_select_button.AutoSize = true;
            this.AES_file_select_button.BackColor = System.Drawing.SystemColors.Control;
            this.AES_file_select_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AES_file_select_button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.AES_file_select_button.Location = new System.Drawing.Point(202, 141);
            this.AES_file_select_button.Name = "AES_file_select_button";
            this.AES_file_select_button.Size = new System.Drawing.Size(123, 30);
            this.AES_file_select_button.TabIndex = 0;
            this.AES_file_select_button.TabStop = false;
            this.AES_file_select_button.Text = "Оберіть файл";
            this.AES_file_select_button.UseVisualStyleBackColor = false;
            this.AES_file_select_button.Click += new System.EventHandler(this.File_select_button_Click);
            // 
            // RSA_panel
            // 
            this.RSA_panel.BackColor = System.Drawing.Color.Transparent;
            this.RSA_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RSA_panel.Controls.Add(this.select_private_key_button);
            this.RSA_panel.Controls.Add(this.select_public_key_button);
            this.RSA_panel.Controls.Add(this.RSA_decrypt_button);
            this.RSA_panel.Controls.Add(this.label5);
            this.RSA_panel.Controls.Add(this.label3);
            this.RSA_panel.Controls.Add(this.rSA_private_key_textBox);
            this.RSA_panel.Controls.Add(this.rSA_public_key_textBox);
            this.RSA_panel.Controls.Add(this.RSA_encrypt_button);
            this.RSA_panel.Controls.Add(this.RSA_file_select_button);
            this.RSA_panel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.RSA_panel.Location = new System.Drawing.Point(384, 197);
            this.RSA_panel.Name = "RSA_panel";
            this.RSA_panel.Size = new System.Drawing.Size(403, 336);
            this.RSA_panel.TabIndex = 16;
            this.RSA_panel.Visible = false;
            // 
            // select_private_key_button
            // 
            this.select_private_key_button.BackColor = System.Drawing.SystemColors.Control;
            this.select_private_key_button.BackgroundImage = global::File_encryption_decryption.Properties.Resources.key_chain1;
            this.select_private_key_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.select_private_key_button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.select_private_key_button.Location = new System.Drawing.Point(355, 129);
            this.select_private_key_button.Name = "select_private_key_button";
            this.select_private_key_button.Size = new System.Drawing.Size(30, 30);
            this.select_private_key_button.TabIndex = 18;
            this.select_private_key_button.TabStop = false;
            this.select_private_key_button.Click += new System.EventHandler(this.select_private_key_button_Click);
            // 
            // RSA_decrypt_button
            // 
            this.RSA_decrypt_button.AutoSize = true;
            this.RSA_decrypt_button.BackColor = System.Drawing.Color.Transparent;
            this.RSA_decrypt_button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.RSA_decrypt_button.Image = global::File_encryption_decryption.Properties.Resources.unlock__1_;
            this.RSA_decrypt_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RSA_decrypt_button.Location = new System.Drawing.Point(63, 179);
            this.RSA_decrypt_button.Name = "RSA_decrypt_button";
            this.RSA_decrypt_button.Size = new System.Drawing.Size(149, 37);
            this.RSA_decrypt_button.TabIndex = 11;
            this.RSA_decrypt_button.Text = "Розшифрувати";
            this.RSA_decrypt_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RSA_decrypt_button.UseVisualStyleBackColor = false;
            this.RSA_decrypt_button.Click += new System.EventHandler(this.RSA_decrypt_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(7, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ключ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(7, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ключ:";
            // 
            // rSA_private_key_textBox
            // 
            this.rSA_private_key_textBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.rSA_private_key_textBox.Location = new System.Drawing.Point(63, 131);
            this.rSA_private_key_textBox.MaxLength = 64;
            this.rSA_private_key_textBox.Name = "rSA_private_key_textBox";
            this.rSA_private_key_textBox.ReadOnly = true;
            this.rSA_private_key_textBox.Size = new System.Drawing.Size(286, 25);
            this.rSA_private_key_textBox.TabIndex = 10;
            this.rSA_private_key_textBox.Text = "RSA45678";
            // 
            // rSA_public_key_textBox
            // 
            this.rSA_public_key_textBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.rSA_public_key_textBox.Location = new System.Drawing.Point(63, 21);
            this.rSA_public_key_textBox.MaxLength = 64;
            this.rSA_public_key_textBox.Name = "rSA_public_key_textBox";
            this.rSA_public_key_textBox.ReadOnly = true;
            this.rSA_public_key_textBox.Size = new System.Drawing.Size(286, 25);
            this.rSA_public_key_textBox.TabIndex = 10;
            this.rSA_public_key_textBox.Text = "RSA45678";
            // 
            // RSA_encrypt_button
            // 
            this.RSA_encrypt_button.AutoSize = true;
            this.RSA_encrypt_button.BackColor = System.Drawing.Color.Transparent;
            this.RSA_encrypt_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RSA_encrypt_button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.RSA_encrypt_button.Image = ((System.Drawing.Image)(resources.GetObject("RSA_encrypt_button.Image")));
            this.RSA_encrypt_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RSA_encrypt_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RSA_encrypt_button.Location = new System.Drawing.Point(63, 67);
            this.RSA_encrypt_button.Name = "RSA_encrypt_button";
            this.RSA_encrypt_button.Size = new System.Drawing.Size(149, 37);
            this.RSA_encrypt_button.TabIndex = 9;
            this.RSA_encrypt_button.Text = "Шифрувати";
            this.RSA_encrypt_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RSA_encrypt_button.UseVisualStyleBackColor = false;
            this.RSA_encrypt_button.Click += new System.EventHandler(this.RSA_encrypt_button_Click);
            // 
            // RSA_file_select_button
            // 
            this.RSA_file_select_button.AutoSize = true;
            this.RSA_file_select_button.BackColor = System.Drawing.SystemColors.Control;
            this.RSA_file_select_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RSA_file_select_button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.RSA_file_select_button.Location = new System.Drawing.Point(222, 241);
            this.RSA_file_select_button.Name = "RSA_file_select_button";
            this.RSA_file_select_button.Size = new System.Drawing.Size(149, 30);
            this.RSA_file_select_button.TabIndex = 0;
            this.RSA_file_select_button.TabStop = false;
            this.RSA_file_select_button.Text = "Оберіть файл";
            this.RSA_file_select_button.UseVisualStyleBackColor = false;
            this.RSA_file_select_button.Click += new System.EventHandler(this.File_select_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = global::File_encryption_decryption.Properties.Resources.cryptographyBackground;
            this.ClientSize = new System.Drawing.Size(1307, 606);
            this.Controls.Add(this.RSA_panel);
            this.Controls.Add(this.AES_panel);
            this.Controls.Add(this.path_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DES_panel);
            this.Controls.Add(this.TripleDES_panel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Encriptor/Decriptor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.Form1_Layout);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TripleDES_panel.ResumeLayout(false);
            this.TripleDES_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyTDesGenPicktureBox)).EndInit();
            this.DES_panel.ResumeLayout(false);
            this.DES_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyDesGenPicktureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyAesGenPicktureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.select_public_key_button)).EndInit();
            this.AES_panel.ResumeLayout(false);
            this.AES_panel.PerformLayout();
            this.RSA_panel.ResumeLayout(false);
            this.RSA_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.select_private_key_button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TDES_file_select_button;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Button Minimize_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button TDES_encrypt_button;
        private System.Windows.Forms.TextBox tDES_key_textBox;
        private System.Windows.Forms.Button TDES_decrypt_button;
        private System.Windows.Forms.Panel TripleDES_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox keyTDesGenPicktureBox;
        private System.Windows.Forms.Button DES_file_select_button;
        private System.Windows.Forms.Panel DES_panel;
        private System.Windows.Forms.Button DES_decrypt_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dES_key_textBox;
        private System.Windows.Forms.Button DES_encrypt_button;
        private System.Windows.Forms.TextBox path_textBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel AES_panel;
        private System.Windows.Forms.Button AES_decrypt_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox aES_key_textBox;
        private System.Windows.Forms.Button AES_encrypt_button;
        private System.Windows.Forms.Button AES_file_select_button;
        private System.Windows.Forms.PictureBox keyDesGenPicktureBox;
        private System.Windows.Forms.PictureBox keyAesGenPicktureBox;
        private System.Windows.Forms.Panel RSA_panel;
        private System.Windows.Forms.PictureBox select_public_key_button;
        private System.Windows.Forms.Button RSA_decrypt_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rSA_public_key_textBox;
        private System.Windows.Forms.Button RSA_encrypt_button;
        private System.Windows.Forms.Button RSA_file_select_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rSA_private_key_textBox;
        private System.Windows.Forms.PictureBox select_private_key_button;
    }
}

