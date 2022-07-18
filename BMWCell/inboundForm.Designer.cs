
namespace BMWCell
{
    partial class inboundForm
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
            this.palletIDText = new System.Windows.Forms.TextBox();
            this.palletDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelPallet = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelPalletSpace = new System.Windows.Forms.Label();
            this.displayPalletSpace = new System.Windows.Forms.Label();
            this.buttonFindPalletSpace = new System.Windows.Forms.Button();
            this.buttonSavePallet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // palletIDText
            // 
            this.palletIDText.Location = new System.Drawing.Point(27, 187);
            this.palletIDText.Name = "palletIDText";
            this.palletIDText.Size = new System.Drawing.Size(805, 23);
            this.palletIDText.TabIndex = 0;
            // 
            // palletDateTime
            // 
            this.palletDateTime.CalendarFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.palletDateTime.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.palletDateTime.Location = new System.Drawing.Point(272, 85);
            this.palletDateTime.Name = "palletDateTime";
            this.palletDateTime.Size = new System.Drawing.Size(353, 34);
            this.palletDateTime.TabIndex = 1;
            // 
            // labelPallet
            // 
            this.labelPallet.AutoSize = true;
            this.labelPallet.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPallet.Location = new System.Drawing.Point(27, 142);
            this.labelPallet.Name = "labelPallet";
            this.labelPallet.Size = new System.Drawing.Size(83, 28);
            this.labelPallet.TabIndex = 2;
            this.labelPallet.Text = "Pallet ID";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDate.Location = new System.Drawing.Point(27, 90);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(150, 28);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "Data paletyzacji";
            // 
            // labelPalletSpace
            // 
            this.labelPalletSpace.AutoSize = true;
            this.labelPalletSpace.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPalletSpace.Location = new System.Drawing.Point(27, 403);
            this.labelPalletSpace.Name = "labelPalletSpace";
            this.labelPalletSpace.Size = new System.Drawing.Size(390, 54);
            this.labelPalletSpace.TabIndex = 4;
            this.labelPalletSpace.Text = "MIEJSCE PALETOWE: ";
            // 
            // displayPalletSpace
            // 
            this.displayPalletSpace.AutoSize = true;
            this.displayPalletSpace.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.displayPalletSpace.Location = new System.Drawing.Point(516, 403);
            this.displayPalletSpace.Name = "displayPalletSpace";
            this.displayPalletSpace.Size = new System.Drawing.Size(77, 54);
            this.displayPalletSpace.TabIndex = 5;
            this.displayPalletSpace.Text = "<>";
            // 
            // buttonFindPalletSpace
            // 
            this.buttonFindPalletSpace.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFindPalletSpace.Location = new System.Drawing.Point(69, 238);
            this.buttonFindPalletSpace.Name = "buttonFindPalletSpace";
            this.buttonFindPalletSpace.Size = new System.Drawing.Size(720, 131);
            this.buttonFindPalletSpace.TabIndex = 6;
            this.buttonFindPalletSpace.Text = "WSKAŻ MIEJSCE PALETOWE";
            this.buttonFindPalletSpace.UseVisualStyleBackColor = true;
            this.buttonFindPalletSpace.Click += new System.EventHandler(this.buttonFindPalletSpace_Click);
            // 
            // buttonSavePallet
            // 
            this.buttonSavePallet.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSavePallet.Location = new System.Drawing.Point(69, 476);
            this.buttonSavePallet.Name = "buttonSavePallet";
            this.buttonSavePallet.Size = new System.Drawing.Size(720, 131);
            this.buttonSavePallet.TabIndex = 7;
            this.buttonSavePallet.Text = "ZAPISZ PALETĘ W MAGAZYNIE";
            this.buttonSavePallet.UseVisualStyleBackColor = true;
            this.buttonSavePallet.Click += new System.EventHandler(this.buttonSavePallet_Click);
            // 
            // inboundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 640);
            this.Controls.Add(this.buttonSavePallet);
            this.Controls.Add(this.buttonFindPalletSpace);
            this.Controls.Add(this.displayPalletSpace);
            this.Controls.Add(this.labelPalletSpace);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelPallet);
            this.Controls.Add(this.palletDateTime);
            this.Controls.Add(this.palletIDText);
            this.Name = "inboundForm";
            this.Text = "PRZYJĘCIE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox palletIDText;
        private System.Windows.Forms.DateTimePicker palletDateTime;
        private System.Windows.Forms.Label labelPallet;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelPalletSpace;
        private System.Windows.Forms.Label displayPalletSpace;
        private System.Windows.Forms.Button buttonFindPalletSpace;
        private System.Windows.Forms.Button buttonSavePallet;
    }
}