
namespace BMWCell
{
    partial class mainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inboundButton = new System.Windows.Forms.Button();
            this.outboundButton = new System.Windows.Forms.Button();
            this.buttonGenerateWarehouseReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inboundButton
            // 
            this.inboundButton.Location = new System.Drawing.Point(74, 44);
            this.inboundButton.Name = "inboundButton";
            this.inboundButton.Size = new System.Drawing.Size(355, 301);
            this.inboundButton.TabIndex = 0;
            this.inboundButton.Text = "INBOUND";
            this.inboundButton.UseVisualStyleBackColor = true;
            this.inboundButton.Click += new System.EventHandler(this.inboundButton_Click);
            // 
            // outboundButton
            // 
            this.outboundButton.Location = new System.Drawing.Point(523, 44);
            this.outboundButton.Name = "outboundButton";
            this.outboundButton.Size = new System.Drawing.Size(355, 301);
            this.outboundButton.TabIndex = 1;
            this.outboundButton.Text = "OUTBOUND";
            this.outboundButton.UseVisualStyleBackColor = true;
            this.outboundButton.Click += new System.EventHandler(this.outboundButton_Click);
            // 
            // buttonGenerateWarehouseReport
            // 
            this.buttonGenerateWarehouseReport.Location = new System.Drawing.Point(74, 409);
            this.buttonGenerateWarehouseReport.Name = "buttonGenerateWarehouseReport";
            this.buttonGenerateWarehouseReport.Size = new System.Drawing.Size(274, 103);
            this.buttonGenerateWarehouseReport.TabIndex = 2;
            this.buttonGenerateWarehouseReport.Text = "RAPORT STANU MAGAZYNU";
            this.buttonGenerateWarehouseReport.UseVisualStyleBackColor = true;
            this.buttonGenerateWarehouseReport.Click += new System.EventHandler(this.buttonGenerateWarehouseReport_Click);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 685);
            this.Controls.Add(this.buttonGenerateWarehouseReport);
            this.Controls.Add(this.outboundButton);
            this.Controls.Add(this.inboundButton);
            this.Name = "mainMenu";
            this.Text = "BMW Cell MS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button inboundButton;
        private System.Windows.Forms.Button outboundButton;
        private System.Windows.Forms.Button buttonGenerateWarehouseReport;
    }
}

