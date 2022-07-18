
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
            this.SuspendLayout();
            // 
            // givenPalletList
            // 
            this.givenPalletList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.givenPalletList.Location = new System.Drawing.Point(54, 52);
            this.givenPalletList.Multiline = true;
            this.givenPalletList.Name = "givenPalletList";
            this.givenPalletList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.givenPalletList.Size = new System.Drawing.Size(680, 444);
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
            this.buttonPreparePalletList.Location = new System.Drawing.Point(54, 502);
            this.buttonPreparePalletList.Name = "buttonPreparePalletList";
            this.buttonPreparePalletList.Size = new System.Drawing.Size(680, 82);
            this.buttonPreparePalletList.TabIndex = 2;
            this.buttonPreparePalletList.Text = "PRZYGOTUJ PICKLISTĘ";
            this.buttonPreparePalletList.UseVisualStyleBackColor = true;
            this.buttonPreparePalletList.Click += new System.EventHandler(this.buttonPreparePalletList_Click);
            // 
            // outboundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 621);
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
    }
}