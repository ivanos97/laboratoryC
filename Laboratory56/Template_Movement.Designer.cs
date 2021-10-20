
namespace Laboratory56
{
    partial class Template_Movement
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
            this.TableMovement = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bEdit = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            this.inRaskhod_nakl = new System.Windows.Forms.TextBox();
            this.inPriem_Nakl = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TableMovement)).BeginInit();
            this.SuspendLayout();
            // 
            // TableMovement
            // 
            this.TableMovement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableMovement.Location = new System.Drawing.Point(12, 21);
            this.TableMovement.Name = "TableMovement";
            this.TableMovement.RowTemplate.Height = 25;
            this.TableMovement.Size = new System.Drawing.Size(378, 328);
            this.TableMovement.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Raskhod_Nakl";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Priem_Nakl";
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(680, 326);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(75, 23);
            this.bEdit.TabIndex = 28;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = true;
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(599, 326);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 27;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            // 
            // bNew
            // 
            this.bNew.Location = new System.Drawing.Point(518, 326);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(75, 23);
            this.bNew.TabIndex = 26;
            this.bNew.Text = "New";
            this.bNew.UseVisualStyleBackColor = true;
            // 
            // inRaskhod_nakl
            // 
            this.inRaskhod_nakl.Location = new System.Drawing.Point(518, 84);
            this.inRaskhod_nakl.Name = "inRaskhod_nakl";
            this.inRaskhod_nakl.Size = new System.Drawing.Size(237, 23);
            this.inRaskhod_nakl.TabIndex = 24;
            // 
            // inPriem_Nakl
            // 
            this.inPriem_Nakl.Location = new System.Drawing.Point(518, 39);
            this.inPriem_Nakl.Name = "inPriem_Nakl";
            this.inPriem_Nakl.Size = new System.Drawing.Size(237, 23);
            this.inPriem_Nakl.TabIndex = 23;
            // 
            // Template_Movement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 364);
            this.Controls.Add(this.TableMovement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.inRaskhod_nakl);
            this.Controls.Add(this.inPriem_Nakl);
            this.Name = "Template_Movement";
            this.Text = "Template_Movement";
            ((System.ComponentModel.ISupportInitialize)(this.TableMovement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TableMovement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.TextBox inRaskhod_nakl;
        private System.Windows.Forms.TextBox inPriem_Nakl;
    }
}