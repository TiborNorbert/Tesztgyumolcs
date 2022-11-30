namespace Tesztgyumolcs
{
    partial class tablazat
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
            this.gyumolcsok = new System.Windows.Forms.DataGridView();
            this.kivalasztott = new System.Windows.Forms.GroupBox();
            this.azonosito = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.egyegnum = new System.Windows.Forms.NumericUpDown();
            this.mennyisegnum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.insert = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nevtxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gyumolcsok)).BeginInit();
            this.kivalasztott.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.egyegnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mennyisegnum)).BeginInit();
            this.SuspendLayout();
            // 
            // gyumolcsok
            // 
            this.gyumolcsok.AllowUserToAddRows = false;
            this.gyumolcsok.AllowUserToDeleteRows = false;
            this.gyumolcsok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gyumolcsok.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gyumolcsok.Location = new System.Drawing.Point(0, 334);
            this.gyumolcsok.Name = "gyumolcsok";
            this.gyumolcsok.ReadOnly = true;
            this.gyumolcsok.Size = new System.Drawing.Size(800, 116);
            this.gyumolcsok.TabIndex = 0;
            this.gyumolcsok.SelectionChanged += new System.EventHandler(this.gyumolcsok_SelectionChanged);
            // 
            // kivalasztott
            // 
            this.kivalasztott.Controls.Add(this.nevtxt);
            this.kivalasztott.Controls.Add(this.label4);
            this.kivalasztott.Controls.Add(this.delete);
            this.kivalasztott.Controls.Add(this.update);
            this.kivalasztott.Controls.Add(this.insert);
            this.kivalasztott.Controls.Add(this.label3);
            this.kivalasztott.Controls.Add(this.label2);
            this.kivalasztott.Controls.Add(this.mennyisegnum);
            this.kivalasztott.Controls.Add(this.egyegnum);
            this.kivalasztott.Controls.Add(this.label1);
            this.kivalasztott.Controls.Add(this.azonosito);
            this.kivalasztott.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kivalasztott.Location = new System.Drawing.Point(0, 0);
            this.kivalasztott.Name = "kivalasztott";
            this.kivalasztott.Size = new System.Drawing.Size(800, 334);
            this.kivalasztott.TabIndex = 1;
            this.kivalasztott.TabStop = false;
            this.kivalasztott.Text = "Kivalasztott gyumolcs adatai";
            // 
            // azonosito
            // 
            this.azonosito.Location = new System.Drawing.Point(133, 46);
            this.azonosito.Name = "azonosito";
            this.azonosito.ReadOnly = true;
            this.azonosito.Size = new System.Drawing.Size(112, 20);
            this.azonosito.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(22, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Azonosito";
            // 
            // egyegnum
            // 
            this.egyegnum.DecimalPlaces = 2;
            this.egyegnum.Location = new System.Drawing.Point(133, 130);
            this.egyegnum.Name = "egyegnum";
            this.egyegnum.Size = new System.Drawing.Size(112, 20);
            this.egyegnum.TabIndex = 2;
            this.egyegnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mennyisegnum
            // 
            this.mennyisegnum.DecimalPlaces = 2;
            this.mennyisegnum.Location = new System.Drawing.Point(133, 182);
            this.mennyisegnum.Name = "mennyisegnum";
            this.mennyisegnum.Size = new System.Drawing.Size(111, 20);
            this.mennyisegnum.TabIndex = 3;
            this.mennyisegnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(22, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "EgysegAr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(22, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mennyiseg";
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(341, 43);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(94, 23);
            this.insert.TabIndex = 6;
            this.insert.Text = "Új gyümölcs";
            this.insert.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(340, 88);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(95, 23);
            this.update.TabIndex = 7;
            this.update.Text = "Modositas";
            this.update.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(340, 134);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(91, 22);
            this.delete.TabIndex = 8;
            this.delete.Text = "Törlés";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(22, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nev";
            // 
            // nevtxt
            // 
            this.nevtxt.Location = new System.Drawing.Point(133, 90);
            this.nevtxt.Name = "nevtxt";
            this.nevtxt.Size = new System.Drawing.Size(112, 20);
            this.nevtxt.TabIndex = 10;
            // 
            // tablazat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kivalasztott);
            this.Controls.Add(this.gyumolcsok);
            this.Name = "tablazat";
            this.Text = "Tablazat";
            this.Load += new System.EventHandler(this.tablazat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gyumolcsok)).EndInit();
            this.kivalasztott.ResumeLayout(false);
            this.kivalasztott.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.egyegnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mennyisegnum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gyumolcsok;
        private System.Windows.Forms.GroupBox kivalasztott;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown mennyisegnum;
        private System.Windows.Forms.NumericUpDown egyegnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox azonosito;
        private System.Windows.Forms.TextBox nevtxt;
        private System.Windows.Forms.Label label4;
    }
}

