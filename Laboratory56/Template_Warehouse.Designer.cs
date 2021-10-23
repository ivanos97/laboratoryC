
namespace Laboratory56
{
    partial class Template_Warehouse
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
            this.inNum_phone_sklad = new System.Windows.Forms.TextBox();
            this.inName_sklada = new System.Windows.Forms.TextBox();
            this.inNomer_sklada = new System.Windows.Forms.TextBox();
            this.TableSklad = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TableSklad)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 44;
            this.label3.Text = "Num_phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 43;
            this.label2.Text = "Name_sklada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "Nomer_sklada";
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(673, 317);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(75, 23);
            this.bEdit.TabIndex = 41;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(592, 317);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 40;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bNew
            // 
            this.bNew.Location = new System.Drawing.Point(511, 317);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(75, 23);
            this.bNew.TabIndex = 39;
            this.bNew.Text = "New";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // inNum_phone_sklad
            // 
            this.inNum_phone_sklad.Location = new System.Drawing.Point(511, 120);
            this.inNum_phone_sklad.Name = "inNum_phone_sklad";
            this.inNum_phone_sklad.Size = new System.Drawing.Size(237, 23);
            this.inNum_phone_sklad.TabIndex = 35;
            // 
            // inName_sklada
            // 
            this.inName_sklada.Location = new System.Drawing.Point(511, 75);
            this.inName_sklada.Name = "inName_sklada";
            this.inName_sklada.Size = new System.Drawing.Size(237, 23);
            this.inName_sklada.TabIndex = 34;
            // 
            // inNomer_sklada
            // 
            this.inNomer_sklada.Location = new System.Drawing.Point(511, 30);
            this.inNomer_sklada.Name = "inNomer_sklada";
            this.inNomer_sklada.Size = new System.Drawing.Size(237, 23);
            this.inNomer_sklada.TabIndex = 33;
            // 
            // TableSklad
            // 
            this.TableSklad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableSklad.Location = new System.Drawing.Point(12, 12);
            this.TableSklad.Name = "TableSklad";
            this.TableSklad.RowTemplate.Height = 25;
            this.TableSklad.Size = new System.Drawing.Size(378, 328);
            this.TableSklad.TabIndex = 32;
            // 
            // Template_Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 377);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.inNum_phone_sklad);
            this.Controls.Add(this.inName_sklada);
            this.Controls.Add(this.inNomer_sklada);
            this.Controls.Add(this.TableSklad);
            this.Name = "Template_Warehouse";
            this.Text = "Template_Warehouse";
            ((System.ComponentModel.ISupportInitialize)(this.TableSklad)).EndInit();
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
        private System.Windows.Forms.TextBox inNum_phone_sklad;
        private System.Windows.Forms.TextBox inName_sklada;
        private System.Windows.Forms.TextBox inNomer_sklada;
        private System.Windows.Forms.DataGridView TableSklad;
    }
}