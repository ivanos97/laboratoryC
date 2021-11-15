
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
            this.bDelWhR = new System.Windows.Forms.Button();
            this.bNewWhR = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.idPriem_nakl_sec = new System.Windows.Forms.TextBox();
            this.idNomer_sklad_sec = new System.Windows.Forms.TextBox();
            this.tableWarehouse_has_Reception = new System.Windows.Forms.DataGridView();
            this.bDelWhE = new System.Windows.Forms.Button();
            this.bNewWhE = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.idRashod_nakl = new System.Windows.Forms.TextBox();
            this.idNomer_sklad_thi = new System.Windows.Forms.TextBox();
            this.tableWarehouse_has_Extendable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TableSklad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableWarehouse_has_Reception)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableWarehouse_has_Extendable)).BeginInit();
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
            this.bEdit.Location = new System.Drawing.Point(673, 159);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(75, 23);
            this.bEdit.TabIndex = 41;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(592, 159);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 40;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bNew
            // 
            this.bNew.Location = new System.Drawing.Point(511, 159);
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
            this.TableSklad.Size = new System.Drawing.Size(378, 170);
            this.TableSklad.TabIndex = 32;
            // 
            // bDelWhR
            // 
            this.bDelWhR.Location = new System.Drawing.Point(592, 496);
            this.bDelWhR.Name = "bDelWhR";
            this.bDelWhR.Size = new System.Drawing.Size(75, 23);
            this.bDelWhR.TabIndex = 51;
            this.bDelWhR.Text = "Delete";
            this.bDelWhR.UseVisualStyleBackColor = true;
            this.bDelWhR.Click += new System.EventHandler(this.bDelWhR_Click);
            // 
            // bNewWhR
            // 
            this.bNewWhR.Location = new System.Drawing.Point(511, 496);
            this.bNewWhR.Name = "bNewWhR";
            this.bNewWhR.Size = new System.Drawing.Size(75, 23);
            this.bNewWhR.TabIndex = 50;
            this.bNewWhR.Text = "New";
            this.bNewWhR.UseVisualStyleBackColor = true;
            this.bNewWhR.Click += new System.EventHandler(this.bNewWhR_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 49;
            this.label4.Text = "Priem_nakl";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(409, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 15);
            this.label7.TabIndex = 48;
            this.label7.Text = "Nomer_sklad";
            // 
            // idPriem_nakl_sec
            // 
            this.idPriem_nakl_sec.Location = new System.Drawing.Point(511, 414);
            this.idPriem_nakl_sec.Name = "idPriem_nakl_sec";
            this.idPriem_nakl_sec.Size = new System.Drawing.Size(237, 23);
            this.idPriem_nakl_sec.TabIndex = 47;
            // 
            // idNomer_sklad_sec
            // 
            this.idNomer_sklad_sec.Location = new System.Drawing.Point(511, 369);
            this.idNomer_sklad_sec.Name = "idNomer_sklad_sec";
            this.idNomer_sklad_sec.Size = new System.Drawing.Size(237, 23);
            this.idNomer_sklad_sec.TabIndex = 46;
            // 
            // tableWarehouse_has_Reception
            // 
            this.tableWarehouse_has_Reception.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableWarehouse_has_Reception.Location = new System.Drawing.Point(12, 369);
            this.tableWarehouse_has_Reception.Name = "tableWarehouse_has_Reception";
            this.tableWarehouse_has_Reception.RowTemplate.Height = 25;
            this.tableWarehouse_has_Reception.Size = new System.Drawing.Size(378, 150);
            this.tableWarehouse_has_Reception.TabIndex = 45;
            // 
            // bDelWhE
            // 
            this.bDelWhE.Location = new System.Drawing.Point(592, 326);
            this.bDelWhE.Name = "bDelWhE";
            this.bDelWhE.Size = new System.Drawing.Size(75, 23);
            this.bDelWhE.TabIndex = 58;
            this.bDelWhE.Text = "Delete";
            this.bDelWhE.UseVisualStyleBackColor = true;
            this.bDelWhE.Click += new System.EventHandler(this.bDelWhE_Click);
            // 
            // bNewWhE
            // 
            this.bNewWhE.Location = new System.Drawing.Point(511, 326);
            this.bNewWhE.Name = "bNewWhE";
            this.bNewWhE.Size = new System.Drawing.Size(75, 23);
            this.bNewWhE.TabIndex = 57;
            this.bNewWhE.Text = "New";
            this.bNewWhE.UseVisualStyleBackColor = true;
            this.bNewWhE.Click += new System.EventHandler(this.bNewWhE_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 56;
            this.label5.Text = "Rashod_nakl";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(409, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 55;
            this.label6.Text = "Nomer_sklad";
            // 
            // idRashod_nakl
            // 
            this.idRashod_nakl.Location = new System.Drawing.Point(511, 244);
            this.idRashod_nakl.Name = "idRashod_nakl";
            this.idRashod_nakl.Size = new System.Drawing.Size(237, 23);
            this.idRashod_nakl.TabIndex = 54;
            // 
            // idNomer_sklad_thi
            // 
            this.idNomer_sklad_thi.Location = new System.Drawing.Point(511, 199);
            this.idNomer_sklad_thi.Name = "idNomer_sklad_thi";
            this.idNomer_sklad_thi.Size = new System.Drawing.Size(237, 23);
            this.idNomer_sklad_thi.TabIndex = 53;
            // 
            // tableWarehouse_has_Extendable
            // 
            this.tableWarehouse_has_Extendable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableWarehouse_has_Extendable.Location = new System.Drawing.Point(12, 199);
            this.tableWarehouse_has_Extendable.Name = "tableWarehouse_has_Extendable";
            this.tableWarehouse_has_Extendable.RowTemplate.Height = 25;
            this.tableWarehouse_has_Extendable.Size = new System.Drawing.Size(378, 150);
            this.tableWarehouse_has_Extendable.TabIndex = 52;
            // 
            // Template_Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 552);
            this.Controls.Add(this.bDelWhE);
            this.Controls.Add(this.bNewWhE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.idRashod_nakl);
            this.Controls.Add(this.idNomer_sklad_thi);
            this.Controls.Add(this.tableWarehouse_has_Extendable);
            this.Controls.Add(this.bDelWhR);
            this.Controls.Add(this.bNewWhR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.idPriem_nakl_sec);
            this.Controls.Add(this.idNomer_sklad_sec);
            this.Controls.Add(this.tableWarehouse_has_Reception);
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
            ((System.ComponentModel.ISupportInitialize)(this.tableWarehouse_has_Reception)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableWarehouse_has_Extendable)).EndInit();
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
        private System.Windows.Forms.Button bDelWhR;
        private System.Windows.Forms.Button bNewWhR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox idPriem_nakl_sec;
        private System.Windows.Forms.TextBox idNomer_sklad_sec;
        private System.Windows.Forms.DataGridView tableWarehouse_has_Reception;
        private System.Windows.Forms.Button bDelWhE;
        private System.Windows.Forms.Button bNewWhE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox idRashod_nakl;
        private System.Windows.Forms.TextBox idNomer_sklad_thi;
        private System.Windows.Forms.DataGridView tableWarehouse_has_Extendable;
    }
}