
namespace Laboratory56
{
    partial class Template_Reception
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
            this.TablePriem_nakl = new System.Windows.Forms.DataGridView();
            this.inId_priem_nakl = new System.Windows.Forms.TextBox();
            this.inDate = new System.Windows.Forms.TextBox();
            this.inInventar = new System.Windows.Forms.TextBox();
            this.inKolich_yedinitsa = new System.Windows.Forms.TextBox();
            this.inSotrudnik = new System.Windows.Forms.TextBox();
            this.bNew = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableWarehouse_has_Reception = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.idPriem_nakl_sec = new System.Windows.Forms.TextBox();
            this.idNomer_sklad_sec = new System.Windows.Forms.TextBox();
            this.bDelWhR = new System.Windows.Forms.Button();
            this.bNewWhR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TablePriem_nakl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableWarehouse_has_Reception)).BeginInit();
            this.SuspendLayout();
            // 
            // TablePriem_nakl
            // 
            this.TablePriem_nakl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablePriem_nakl.Location = new System.Drawing.Point(32, 29);
            this.TablePriem_nakl.Name = "TablePriem_nakl";
            this.TablePriem_nakl.RowTemplate.Height = 25;
            this.TablePriem_nakl.Size = new System.Drawing.Size(378, 328);
            this.TablePriem_nakl.TabIndex = 0;
            // 
            // inId_priem_nakl
            // 
            this.inId_priem_nakl.Location = new System.Drawing.Point(531, 47);
            this.inId_priem_nakl.Name = "inId_priem_nakl";
            this.inId_priem_nakl.Size = new System.Drawing.Size(237, 23);
            this.inId_priem_nakl.TabIndex = 1;
            // 
            // inDate
            // 
            this.inDate.Location = new System.Drawing.Point(531, 92);
            this.inDate.Name = "inDate";
            this.inDate.Size = new System.Drawing.Size(237, 23);
            this.inDate.TabIndex = 2;
            // 
            // inInventar
            // 
            this.inInventar.Location = new System.Drawing.Point(531, 184);
            this.inInventar.Name = "inInventar";
            this.inInventar.Size = new System.Drawing.Size(237, 23);
            this.inInventar.TabIndex = 4;
            // 
            // inKolich_yedinitsa
            // 
            this.inKolich_yedinitsa.Location = new System.Drawing.Point(531, 229);
            this.inKolich_yedinitsa.Name = "inKolich_yedinitsa";
            this.inKolich_yedinitsa.Size = new System.Drawing.Size(237, 23);
            this.inKolich_yedinitsa.TabIndex = 5;
            // 
            // inSotrudnik
            // 
            this.inSotrudnik.Location = new System.Drawing.Point(531, 273);
            this.inSotrudnik.Name = "inSotrudnik";
            this.inSotrudnik.Size = new System.Drawing.Size(237, 23);
            this.inSotrudnik.TabIndex = 6;
            // 
            // bNew
            // 
            this.bNew.Location = new System.Drawing.Point(531, 334);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(75, 23);
            this.bNew.TabIndex = 7;
            this.bNew.Text = "New";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(612, 334);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 8;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(693, 334);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(75, 23);
            this.bEdit.TabIndex = 9;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "id_priem_nakl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Inventar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kolich_yed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(429, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Sotrudnik";
            // 
            // tableWarehouse_has_Reception
            // 
            this.tableWarehouse_has_Reception.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableWarehouse_has_Reception.Location = new System.Drawing.Point(32, 439);
            this.tableWarehouse_has_Reception.Name = "tableWarehouse_has_Reception";
            this.tableWarehouse_has_Reception.RowTemplate.Height = 25;
            this.tableWarehouse_has_Reception.Size = new System.Drawing.Size(378, 150);
            this.tableWarehouse_has_Reception.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 487);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Priem_nakl";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(429, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Nomer_sklad";
            // 
            // idPriem_nakl_sec
            // 
            this.idPriem_nakl_sec.Location = new System.Drawing.Point(531, 484);
            this.idPriem_nakl_sec.Name = "idPriem_nakl_sec";
            this.idPriem_nakl_sec.Size = new System.Drawing.Size(237, 23);
            this.idPriem_nakl_sec.TabIndex = 18;
            // 
            // idNomer_sklad_sec
            // 
            this.idNomer_sklad_sec.Location = new System.Drawing.Point(531, 439);
            this.idNomer_sklad_sec.Name = "idNomer_sklad_sec";
            this.idNomer_sklad_sec.Size = new System.Drawing.Size(237, 23);
            this.idNomer_sklad_sec.TabIndex = 17;
            // 
            // bDelWhR
            // 
            this.bDelWhR.Location = new System.Drawing.Point(612, 566);
            this.bDelWhR.Name = "bDelWhR";
            this.bDelWhR.Size = new System.Drawing.Size(75, 23);
            this.bDelWhR.TabIndex = 22;
            this.bDelWhR.Text = "Delete";
            this.bDelWhR.UseVisualStyleBackColor = true;
            this.bDelWhR.Click += new System.EventHandler(this.bDelWhR_Click);
            // 
            // bNewWhR
            // 
            this.bNewWhR.Location = new System.Drawing.Point(531, 566);
            this.bNewWhR.Name = "bNewWhR";
            this.bNewWhR.Size = new System.Drawing.Size(75, 23);
            this.bNewWhR.TabIndex = 21;
            this.bNewWhR.Text = "New";
            this.bNewWhR.UseVisualStyleBackColor = true;
            this.bNewWhR.Click += new System.EventHandler(this.bNewWhR_Click);
            // 
            // Template_Reception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 637);
            this.Controls.Add(this.bDelWhR);
            this.Controls.Add(this.bNewWhR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.idPriem_nakl_sec);
            this.Controls.Add(this.idNomer_sklad_sec);
            this.Controls.Add(this.tableWarehouse_has_Reception);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.inSotrudnik);
            this.Controls.Add(this.inKolich_yedinitsa);
            this.Controls.Add(this.inInventar);
            this.Controls.Add(this.inDate);
            this.Controls.Add(this.inId_priem_nakl);
            this.Controls.Add(this.TablePriem_nakl);
            this.Name = "Template_Reception";
            this.Text = "Template_Reception";
            ((System.ComponentModel.ISupportInitialize)(this.TablePriem_nakl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableWarehouse_has_Reception)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TablePriem_nakl;
        private System.Windows.Forms.TextBox inId_priem_nakl;
        private System.Windows.Forms.TextBox inDate;
        private System.Windows.Forms.TextBox inInventar;
        private System.Windows.Forms.TextBox inKolich_yedinitsa;
        private System.Windows.Forms.TextBox inSotrudnik;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView tableWarehouse_has_Reception;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox idPriem_nakl_sec;
        private System.Windows.Forms.TextBox idNomer_sklad_sec;
        private System.Windows.Forms.Button bDelWhR;
        private System.Windows.Forms.Button bNewWhR;
    }
}