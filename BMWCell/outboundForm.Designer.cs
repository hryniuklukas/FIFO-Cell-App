
namespace BMWCell
{
    partial class outboundForm
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
            this.givenPalletList = new System.Windows.Forms.TextBox();
            this.buttonPreparePalletList = new System.Windows.Forms.Button();
            this.palletToFind = new System.Windows.Forms.TextBox();
            this.buttonFindPallet = new System.Windows.Forms.Button();
            this.labelRow = new System.Windows.Forms.Label();
            this.labelLine = new System.Windows.Forms.Label();
            this.labelPalletID = new System.Windows.Forms.Label();
            this.buttonReleasePallets = new System.Windows.Forms.Button();
            this.buttonFifoPicklist = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // givenPalletList
            // 
            this.givenPalletList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.givenPalletList.Location = new System.Drawing.Point(17, 54);
            this.givenPalletList.Multiline = true;
            this.givenPalletList.Name = "givenPalletList";
            this.givenPalletList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.givenPalletList.Size = new System.Drawing.Size(680, 234);
            this.givenPalletList.TabIndex = 0;
            // 
            // buttonPreparePalletList
            // 
            this.buttonPreparePalletList.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPreparePalletList.Location = new System.Drawing.Point(17, 294);
            this.buttonPreparePalletList.Name = "buttonPreparePalletList";
            this.buttonPreparePalletList.Size = new System.Drawing.Size(680, 82);
            this.buttonPreparePalletList.TabIndex = 2;
            this.buttonPreparePalletList.Text = "PRZYGOTUJ PICKLISTĘ";
            this.buttonPreparePalletList.UseVisualStyleBackColor = true;
            this.buttonPreparePalletList.Click += new System.EventHandler(this.buttonPreparePalletList_Click);
            // 
            // palletToFind
            // 
            this.palletToFind.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.palletToFind.Location = new System.Drawing.Point(17, 55);
            this.palletToFind.Name = "palletToFind";
            this.palletToFind.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.palletToFind.Size = new System.Drawing.Size(680, 29);
            this.palletToFind.TabIndex = 3;
            // 
            // buttonFindPallet
            // 
            this.buttonFindPallet.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFindPallet.Location = new System.Drawing.Point(17, 90);
            this.buttonFindPallet.Name = "buttonFindPallet";
            this.buttonFindPallet.Size = new System.Drawing.Size(680, 82);
            this.buttonFindPallet.TabIndex = 5;
            this.buttonFindPallet.Text = "SZUKAJ";
            this.buttonFindPallet.UseVisualStyleBackColor = true;
            this.buttonFindPallet.Click += new System.EventHandler(this.buttonFindPallet_Click);
            // 
            // labelRow
            // 
            this.labelRow.AutoSize = true;
            this.labelRow.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRow.Location = new System.Drawing.Point(17, 192);
            this.labelRow.Name = "labelRow";
            this.labelRow.Size = new System.Drawing.Size(62, 25);
            this.labelRow.TabIndex = 6;
            this.labelRow.Text = "Rząd: ";
            // 
            // labelLine
            // 
            this.labelLine.AutoSize = true;
            this.labelLine.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLine.Location = new System.Drawing.Point(130, 192);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(84, 25);
            this.labelLine.TabIndex = 7;
            this.labelLine.Text = "Pozycja: ";
            // 
            // labelPalletID
            // 
            this.labelPalletID.AutoSize = true;
            this.labelPalletID.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPalletID.Location = new System.Drawing.Point(296, 192);
            this.labelPalletID.Name = "labelPalletID";
            this.labelPalletID.Size = new System.Drawing.Size(77, 25);
            this.labelPalletID.TabIndex = 8;
            this.labelPalletID.Text = "Paleta:  ";
            // 
            // buttonReleasePallets
            // 
            this.buttonReleasePallets.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonReleasePallets.Location = new System.Drawing.Point(17, 382);
            this.buttonReleasePallets.Name = "buttonReleasePallets";
            this.buttonReleasePallets.Size = new System.Drawing.Size(680, 80);
            this.buttonReleasePallets.TabIndex = 9;
            this.buttonReleasePallets.Text = "WYDAJ PALETY Z PICKLISTY";
            this.buttonReleasePallets.UseVisualStyleBackColor = true;
            this.buttonReleasePallets.Click += new System.EventHandler(this.buttonReleasePallets_Click);
            // 
            // buttonFifoPicklist
            // 
            this.buttonFifoPicklist.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFifoPicklist.Location = new System.Drawing.Point(17, 47);
            this.buttonFifoPicklist.Name = "buttonFifoPicklist";
            this.buttonFifoPicklist.Size = new System.Drawing.Size(680, 82);
            this.buttonFifoPicklist.TabIndex = 10;
            this.buttonFifoPicklist.Text = "PRZYGOTUJ PICKLISTĘ";
            this.buttonFifoPicklist.UseVisualStyleBackColor = true;
            this.buttonFifoPicklist.Click += new System.EventHandler(this.buttonFifoPicklist_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonReleasePallets);
            this.groupBox1.Controls.Add(this.buttonPreparePalletList);
            this.groupBox1.Controls.Add(this.givenPalletList);
            this.groupBox1.Location = new System.Drawing.Point(37, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 470);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista Palet do wysyłki";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonFifoPicklist);
            this.groupBox2.Location = new System.Drawing.Point(37, 488);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(720, 173);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FIFO";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.labelPalletID);
            this.groupBox3.Controls.Add(this.labelLine);
            this.groupBox3.Controls.Add(this.labelRow);
            this.groupBox3.Controls.Add(this.buttonFindPallet);
            this.groupBox3.Controls.Add(this.palletToFind);
            this.groupBox3.Location = new System.Drawing.Point(37, 667);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(719, 233);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Znajdź paletę po PALLET ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "PalletID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lista PalletID:";
            // 
            // outboundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 939);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "outboundForm";
            this.Text = "WYSYŁKA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox givenPalletList;
        private System.Windows.Forms.Button buttonPreparePalletList;
        private System.Windows.Forms.TextBox palletToFind;
        private System.Windows.Forms.Button buttonFindPallet;
        private System.Windows.Forms.Label labelRow;
        private System.Windows.Forms.Label labelLine;
        private System.Windows.Forms.Label labelPalletID;
        private System.Windows.Forms.Button buttonReleasePallets;
        private System.Windows.Forms.Button buttonFifoPicklist;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}