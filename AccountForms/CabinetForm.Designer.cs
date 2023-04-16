namespace AccountForms
{
    partial class CabinetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CabinetForm));
            label1 = new Label();
            accountLogin_lable = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(184, 85);
            label1.Name = "label1";
            label1.Size = new Size(445, 45);
            label1.TabIndex = 0;
            label1.Text = "Произведён вход в аккаунт";
            // 
            // accountLogin_lable
            // 
            accountLogin_lable.AutoSize = true;
            accountLogin_lable.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            accountLogin_lable.Location = new Point(319, 213);
            accountLogin_lable.Name = "accountLogin_lable";
            accountLogin_lable.Size = new Size(128, 50);
            accountLogin_lable.TabIndex = 1;
            accountLogin_lable.Text = "label2";
            // 
            // CabinetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(accountLogin_lable);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CabinetForm";
            Text = "CabinetForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label accountLogin_lable;
    }
}