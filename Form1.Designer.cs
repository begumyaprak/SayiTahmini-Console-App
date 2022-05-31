namespace SayiTahmini
{
    partial class Form1
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
            this.btnEstimation = new System.Windows.Forms.Button();
            this.tbxNumberInput = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEstimation
            // 
            this.btnEstimation.Location = new System.Drawing.Point(195, 188);
            this.btnEstimation.Name = "btnEstimation";
            this.btnEstimation.Size = new System.Drawing.Size(75, 23);
            this.btnEstimation.TabIndex = 0;
            this.btnEstimation.Text = "Tahmin Et";
            this.btnEstimation.UseVisualStyleBackColor = true;
            this.btnEstimation.Click += new System.EventHandler(this.btnEstimation_Click);
            // 
            // tbxNumberInput
            // 
            this.tbxNumberInput.Location = new System.Drawing.Point(164, 143);
            this.tbxNumberInput.Name = "tbxNumberInput";
            this.tbxNumberInput.PlaceholderText = "Sayı Girin";
            this.tbxNumberInput.Size = new System.Drawing.Size(136, 23);
            this.tbxNumberInput.TabIndex = 1;
            this.tbxNumberInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNumberInput_KeyPress);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumber.Location = new System.Drawing.Point(184, 71);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(97, 21);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "Sayı Tahmini";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(147, 110);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(171, 15);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "0 ile 20 arasında bir sayı seçiniz.";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 317);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.tbxNumberInput);
            this.Controls.Add(this.btnEstimation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEstimation;
        private System.Windows.Forms.TextBox tbxNumberInput;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblInfo;
    }
}
