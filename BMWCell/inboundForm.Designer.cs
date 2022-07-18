
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
            this.components = new System.ComponentModel.Container();
            this.palletIDText = new System.Windows.Forms.TextBox();
            this.palletDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelPallet = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelComm = new System.Windows.Forms.Label();
            this.buttonSavePallet = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // palletIDText
            // 
            this.palletIDText.Location = new System.Drawing.Point(154, 190);
            this.palletIDText.Name = "palletIDText";
            this.palletIDText.Size = new System.Drawing.Size(678, 23);
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
            this.labelPallet.Location = new System.Drawing.Point(27, 182);
            this.labelPallet.Name = "labelPallet";
            this.labelPallet.Size = new System.Drawing.Size(87, 28);
            this.labelPallet.TabIndex = 2;
            this.labelPallet.Text = "Pallet ID:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDate.Location = new System.Drawing.Point(27, 90);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(135, 28);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "Data dostawy:";
            // 
            // labelComm
            // 
            this.labelComm.AutoSize = true;
            this.labelComm.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelComm.Location = new System.Drawing.Point(27, 507);
            this.labelComm.Name = "labelComm";
            this.labelComm.Size = new System.Drawing.Size(77, 54);
            this.labelComm.TabIndex = 5;
            this.labelComm.Text = "<>";
            // 
            // buttonSavePallet
            // 
            this.buttonSavePallet.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSavePallet.Location = new System.Drawing.Point(27, 285);
            this.buttonSavePallet.Name = "buttonSavePallet";
            this.buttonSavePallet.Size = new System.Drawing.Size(805, 178);
            this.buttonSavePallet.TabIndex = 7;
            this.buttonSavePallet.Text = "ZAPISZ PALETĘ W MAGAZYNIE";
            this.buttonSavePallet.UseVisualStyleBackColor = true;
            this.buttonSavePallet.Click += new System.EventHandler(this.buttonSavePallet_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 500;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(154, 239);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(133, 23);
            this.locationTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lokalizacja:";
            // 
            // inboundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 595);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.buttonSavePallet);
            this.Controls.Add(this.labelComm);
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
        private System.Windows.Forms.Label labelComm;
        private System.Windows.Forms.Button buttonSavePallet;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Label label1;
    }
}