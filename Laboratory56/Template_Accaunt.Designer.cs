
namespace Laboratory56
{
    partial class Template_Accaunt
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bEdit = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            this.inPassword = new System.Windows.Forms.TextBox();
            this.inLogin = new System.Windows.Forms.TextBox();
            this.inNum_accaunt = new System.Windows.Forms.TextBox();
            this.TableAccaunt = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TableAccaunt)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Num_Accaunt";
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(689, 329);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(75, 23);
            this.bEdit.TabIndex = 18;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(608, 329);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 17;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bNew
            // 
            this.bNew.Location = new System.Drawing.Point(527, 329);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(75, 23);
            this.bNew.TabIndex = 16;
            this.bNew.Text = "New";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // inPassword
            // 
            this.inPassword.Location = new System.Drawing.Point(527, 132);
            this.inPassword.Name = "inPassword";
            this.inPassword.Size = new System.Drawing.Size(237, 23);
            this.inPassword.TabIndex = 15;
            // 
            // inLogin
            // 
            this.inLogin.Location = new System.Drawing.Point(527, 87);
            this.inLogin.Name = "inLogin";
            this.inLogin.Size = new System.Drawing.Size(237, 23);
            this.inLogin.TabIndex = 14;
            // 
            // inNum_accaunt
            // 
            this.inNum_accaunt.Location = new System.Drawing.Point(527, 42);
            this.inNum_accaunt.Name = "inNum_accaunt";
            this.inNum_accaunt.Size = new System.Drawing.Size(237, 23);
            this.inNum_accaunt.TabIndex = 13;
            // 
            // TableAccaunt
            // 
            this.TableAccaunt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableAccaunt.Location = new System.Drawing.Point(21, 24);
            this.TableAccaunt.Name = "TableAccaunt";
            this.TableAccaunt.ReadOnly = true;
            this.TableAccaunt.RowTemplate.Height = 25;
            this.TableAccaunt.Size = new System.Drawing.Size(378, 328);
            this.TableAccaunt.TabIndex = 22;
            // 
            // Template_Accaunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 386);
            this.Controls.Add(this.TableAccaunt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.inPassword);
            this.Controls.Add(this.inLogin);
            this.Controls.Add(this.inNum_accaunt);
            this.Name = "Template_Accaunt";
            this.Text = "Template_Accaunt";
            ((System.ComponentModel.ISupportInitialize)(this.TableAccaunt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.TextBox inPassword;
        private System.Windows.Forms.TextBox inLogin;
        private System.Windows.Forms.TextBox inNum_accaunt;
        private System.Windows.Forms.DataGridView TableAccaunt;
    }
}