namespace SaveTheOcean2
{
    partial class Form3
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
            exitButton = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            localizacionLabel = new Label();
            label10 = new Label();
            gaResLabel = new Label();
            label8 = new Label();
            superfamiliaResLabel = new Label();
            label6 = new Label();
            fechaLabel = new Label();
            label4 = new Label();
            idLabel = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitButton.Location = new Point(684, 459);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(93, 44);
            exitButton.TabIndex = 4;
            exitButton.Text = "Salir";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(255, 27);
            label1.Name = "label1";
            label1.Size = new Size(237, 32);
            label1.TabIndex = 5;
            label1.Text = "Save The Ocean II";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(localizacionLabel);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(gaResLabel);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(superfamiliaResLabel);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(fechaLabel);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(idLabel);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(46, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(621, 405);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "RESCATE";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(462, 304);
            button2.Name = "button2";
            button2.Size = new Size(116, 53);
            button2.TabIndex = 11;
            button2.Text = "Trasladarlo al CRAM";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(306, 304);
            button1.Name = "button1";
            button1.Size = new Size(116, 53);
            button1.TabIndex = 8;
            button1.Text = "Tratarlo al momento";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(288, 246);
            label3.Name = "label3";
            label3.Size = new Size(310, 55);
            label3.TabIndex = 10;
            label3.Text = "¿Deseas tratar el ejemplar en el momento actual o trasladarlo al CRAM?";
            // 
            // localizacionLabel
            // 
            localizacionLabel.BackColor = SystemColors.HotTrack;
            localizacionLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            localizacionLabel.ForeColor = SystemColors.HighlightText;
            localizacionLabel.Location = new Point(37, 253);
            localizacionLabel.Name = "localizacionLabel";
            localizacionLabel.Size = new Size(196, 34);
            localizacionLabel.TabIndex = 9;
            localizacionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(37, 232);
            label10.Name = "label10";
            label10.Size = new Size(148, 21);
            label10.TabIndex = 8;
            label10.Text = "LOCALIZACIÓN";
            // 
            // gaResLabel
            // 
            gaResLabel.BackColor = SystemColors.HotTrack;
            gaResLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gaResLabel.ForeColor = SystemColors.HighlightText;
            gaResLabel.Location = new Point(315, 160);
            gaResLabel.Name = "gaResLabel";
            gaResLabel.Size = new Size(196, 34);
            gaResLabel.TabIndex = 7;
            gaResLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(315, 139);
            label8.Name = "label8";
            label8.Size = new Size(198, 21);
            label8.TabIndex = 6;
            label8.Text = "GRADO AFECTACIÓN";
            // 
            // superfamiliaResLabel
            // 
            superfamiliaResLabel.BackColor = SystemColors.HotTrack;
            superfamiliaResLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            superfamiliaResLabel.ForeColor = SystemColors.HighlightText;
            superfamiliaResLabel.Location = new Point(41, 160);
            superfamiliaResLabel.Name = "superfamiliaResLabel";
            superfamiliaResLabel.Size = new Size(196, 34);
            superfamiliaResLabel.TabIndex = 5;
            superfamiliaResLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(41, 139);
            label6.Name = "label6";
            label6.Size = new Size(144, 21);
            label6.TabIndex = 4;
            label6.Text = "SUPERFAMÍLIA";
            // 
            // fechaLabel
            // 
            fechaLabel.BackColor = SystemColors.HotTrack;
            fechaLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fechaLabel.ForeColor = SystemColors.HighlightText;
            fechaLabel.Location = new Point(315, 64);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new Size(196, 30);
            fechaLabel.TabIndex = 3;
            fechaLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(317, 43);
            label4.Name = "label4";
            label4.Size = new Size(196, 21);
            label4.TabIndex = 2;
            label4.Text = "FECHA DEL RESCATE";
            // 
            // idLabel
            // 
            idLabel.BackColor = SystemColors.HotTrack;
            idLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idLabel.ForeColor = SystemColors.HighlightText;
            idLabel.Location = new Point(41, 64);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(196, 30);
            idLabel.TabIndex = 1;
            idLabel.TextAlign = ContentAlignment.MiddleLeft;
            idLabel.Click += idLabel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 43);
            label2.Name = "label2";
            label2.Size = new Size(29, 21);
            label2.TabIndex = 0;
            label2.Text = "ID";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 515);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(exitButton);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitButton;
        private Label label1;
        private GroupBox groupBox1;
        private Label idLabel;
        private Label label2;
        private Label superfamiliaResLabel;
        private Label label6;
        private Label fechaLabel;
        private Label label4;
        private Label localizacionLabel;
        private Label label10;
        private Label gaResLabel;
        private Label label8;
        private Label label3;
        private Button button2;
        private Button button1;
    }
}