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
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 515);
            Controls.Add(label1);
            Controls.Add(exitButton);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitButton;
        private Label label1;
    }
}