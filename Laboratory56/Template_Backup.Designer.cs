
namespace Laboratory56
{
    partial class Template_Backup
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
            this.bBackup = new System.Windows.Forms.Button();
            this.bRestore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bBackup
            // 
            this.bBackup.Location = new System.Drawing.Point(12, 21);
            this.bBackup.Name = "bBackup";
            this.bBackup.Size = new System.Drawing.Size(75, 23);
            this.bBackup.TabIndex = 0;
            this.bBackup.Text = "Backup";
            this.bBackup.UseVisualStyleBackColor = true;
            // 
            // bRestore
            // 
            this.bRestore.Location = new System.Drawing.Point(226, 21);
            this.bRestore.Name = "bRestore";
            this.bRestore.Size = new System.Drawing.Size(75, 23);
            this.bRestore.TabIndex = 1;
            this.bRestore.Text = "Restore";
            this.bRestore.UseVisualStyleBackColor = true;
            // 
            // Template_Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 56);
            this.Controls.Add(this.bRestore);
            this.Controls.Add(this.bBackup);
            this.Name = "Template_Backup";
            this.Text = "Template_Backup";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bBackup;
        private System.Windows.Forms.Button bRestore;
    }
}