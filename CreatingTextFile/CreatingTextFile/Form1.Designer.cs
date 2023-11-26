namespace CreatingTextFile
{
    partial class FrmLab1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtInput = new TextBox();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtInput.Location = new Point(47, 39);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(277, 113);
            txtInput.TabIndex = 0;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(255, 128, 0);
            btnCreate.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.FromArgb(255, 224, 192);
            btnCreate.Location = new Point(111, 180);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(145, 51);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // FrmLab1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(378, 269);
            Controls.Add(btnCreate);
            Controls.Add(txtInput);
            ForeColor = Color.FromArgb(255, 128, 128);
            Name = "FrmLab1";
            Text = "FrmLab1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button btnCreate;
    }
}