namespace CreatingTextFile
{
    partial class FrmFileName
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
            label1 = new Label();
            txtFileName = new TextBox();
            btnOkay = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 64, 0);
            label1.Location = new Point(6, 17);
            label1.Name = "label1";
            label1.Size = new Size(187, 23);
            label1.TabIndex = 0;
            label1.Text = "Enter File Name:";
            // 
            // txtFileName
            // 
            txtFileName.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtFileName.Location = new Point(12, 57);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(397, 32);
            txtFileName.TabIndex = 1;
            // 
            // btnOkay
            // 
            btnOkay.BackColor = Color.FromArgb(255, 128, 0);
            btnOkay.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnOkay.ForeColor = Color.FromArgb(255, 224, 192);
            btnOkay.Location = new Point(143, 106);
            btnOkay.Name = "btnOkay";
            btnOkay.Size = new Size(128, 51);
            btnOkay.TabIndex = 2;
            btnOkay.Text = "Okay";
            btnOkay.UseVisualStyleBackColor = false;
            btnOkay.Click += btnOkay_Click;
            // 
            // FrmFileName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(421, 169);
            Controls.Add(btnOkay);
            Controls.Add(txtFileName);
            Controls.Add(label1);
            Name = "FrmFileName";
            Text = "FrmFileName";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFileName;
        private Button btnOkay;
    }
}