
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
            this.labelPalletList = new System.Windows.Forms.Label();
            this.buttonPreparePalletList = new System.Windows.Forms.Button();
            this.palletToFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFindPallet = new System.Windows.Forms.Button();
            this.labelRow = new System.Windows.Forms.Label();
            this.labelLine = new System.Windows.Forms.Label();
            this.labelPalletID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // givenPalletList
            // 
            this.givenPalletList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.givenPalletList.Location = new System.Drawing.Point(54, 52);
            this.givenPalletList.Multiline = true;
            this.givenPalletList.Name = "givenPalletList";
            this.givenPalletList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.givenPalletList.Size = new System.Drawing.Size(680, 211);
            this.givenPalletList.TabIndex = 0;
            // 
            // labelPalletList
            // 
            this.labelPalletList.AutoSize = true;
            this.labelPalletList.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPalletList.Location = new System.Drawing.Point(54, 21);
            this.labelPalletList.Name = "labelPalletList";
            this.labelPalletList.Size = new System.Drawing.Size(233, 28);
            this.labelPalletList.TabIndex = 1;
            this.labelPalletList.Text = "LISTA PALET DO WYSYŁKI";
            // 
            // buttonPreparePalletList
            // 
            this.buttonPreparePalletList.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPreparePalletList.Location = new System.Drawing.Point(54, 269);
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
            this.palletToFind.Location = new System.Drawing.Point(54, 412);
            this.palletToFind.Name = "palletToFind";
            this.palletToFind.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.palletToFind.Size = new System.Drawing.Size(680, 29);
            this.palletToFind.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "ZNAJDŹ PALETĘ PO PALLET ID";
            // 
            // buttonFindPallet
            // 
            this.buttonFindPallet.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFindPallet.Location = new System.Drawing.Point(54, 447);
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
            this.labelRow.Location = new System.Drawing.Point(54, 549);
            this.labelRow.Name = "labelRow";
            this.labelRow.Size = new System.Drawing.Size(62, 25);
            this.labelRow.TabIndex = 6;
            this.labelRow.Text = "Rząd: ";
            // 
            // labelLine
            // 
            this.labelLine.AutoSize = true;
            this.labelLine.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLine.Location = new System.Drawing.Point(167, 549);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(84, 25);
            this.labelLine.TabIndex = 7;
            this.labelLine.Text = "Pozycja: ";
            // 
            // labelPalletID
            // 
            this.labelPalletID.AutoSize = true;
            this.labelPalletID.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPalletID.Location = new System.Drawing.Point(445, 549);
            this.labelPalletID.Name = "labelPalletID";
            this.labelPalletID.Size = new System.Drawing.Size(77, 25);
            this.labelPalletID.TabIndex = 8;
            this.labelPalletID.Text = "Paleta:  ";
            // 
            // outboundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 621);
            this.Controls.Add(this.labelPalletID);
            this.Controls.Add(this.labelLine);
            this.Controls.Add(this.labelRow);
            this.Controls.Add(this.buttonFindPallet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.palletToFind);
            this.Controls.Add(this.buttonPreparePalletList);
            this.Controls.Add(this.labelPalletList);
            this.Controls.Add(this.givenPalletList);
            this.Name = "outboundForm";
            this.Text = "WYSYŁKA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox givenPalletList;
        private System.Windows.Forms.Label labelPalletList;
        private System.Windows.Forms.Button buttonPreparePalletList;
        private System.Windows.Forms.TextBox palletToFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFindPallet;
        private System.Windows.Forms.Label labelRow;
        private System.Windows.Forms.Label labelLine;
        private System.Windows.Forms.Label labelPalletID;
    }
}