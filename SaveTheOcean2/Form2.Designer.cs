namespace SaveTheOcean2
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            exitButton = new Button();
            label1 = new Label();
            userRolComboBox = new ComboBox();
            userName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            userDataSaveButton = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitButton.Location = new Point(110, 327);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(93, 44);
            exitButton.TabIndex = 3;
            exitButton.Text = "Salir";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 37);
            label1.Name = "label1";
            label1.Size = new Size(237, 32);
            label1.TabIndex = 4;
            label1.Text = "Save The Ocean II";
            // 
            // userRolComboBox
            // 
            userRolComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            userRolComboBox.FormattingEnabled = true;
            userRolComboBox.Items.AddRange(new object[] { "", "Veterinario", "Técnico" });
            userRolComboBox.Location = new Point(78, 198);
            userRolComboBox.Name = "userRolComboBox";
            userRolComboBox.Size = new Size(167, 23);
            userRolComboBox.TabIndex = 5;
            // 
            // userName
            // 
            userName.Location = new Point(78, 123);
            userName.Name = "userName";
            userName.Size = new Size(167, 23);
            userName.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(78, 99);
            label2.Name = "label2";
            label2.Size = new Size(138, 21);
            label2.TabIndex = 7;
            label2.Text = "Ingresa tu nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(78, 174);
            label3.Name = "label3";
            label3.Size = new Size(99, 21);
            label3.TabIndex = 8;
            label3.Text = "Escoge tu rol";
            // 
            // userDataSaveButton
            // 
            userDataSaveButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userDataSaveButton.Location = new Point(110, 258);
            userDataSaveButton.Name = "userDataSaveButton";
            userDataSaveButton.Size = new Size(93, 44);
            userDataSaveButton.TabIndex = 9;
            userDataSaveButton.Text = "Adelante";
            userDataSaveButton.UseVisualStyleBackColor = true;
            userDataSaveButton.Click += userDataSaveButton_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 406);
            Controls.Add(userDataSaveButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(userName);
            Controls.Add(userRolComboBox);
            Controls.Add(label1);
            Controls.Add(exitButton);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitButton;
        private Label label1;
        private ComboBox userRolComboBox;
        private TextBox userName;
        private Label label2;
        private Label label3;
        private Button userDataSaveButton;
        private ErrorProvider errorProvider1;
    }
}