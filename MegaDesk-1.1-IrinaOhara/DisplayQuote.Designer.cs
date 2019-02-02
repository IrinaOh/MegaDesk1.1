namespace MegaDesk_1_IrinaOhara
{
    partial class DisplayQuote
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveQuote = new System.Windows.Forms.Button();
            this.btnCancelQuote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total";
            // 
            // btnSaveQuote
            // 
            this.btnSaveQuote.Location = new System.Drawing.Point(213, 186);
            this.btnSaveQuote.Name = "btnSaveQuote";
            this.btnSaveQuote.Size = new System.Drawing.Size(145, 102);
            this.btnSaveQuote.TabIndex = 1;
            this.btnSaveQuote.Text = "Save Quote";
            this.btnSaveQuote.UseVisualStyleBackColor = true;
            // 
            // btnCancelQuote
            // 
            this.btnCancelQuote.Location = new System.Drawing.Point(477, 186);
            this.btnCancelQuote.Name = "btnCancelQuote";
            this.btnCancelQuote.Size = new System.Drawing.Size(161, 102);
            this.btnCancelQuote.TabIndex = 2;
            this.btnCancelQuote.Text = "Cancel Quote";
            this.btnCancelQuote.UseVisualStyleBackColor = true;
            this.btnCancelQuote.Click += new System.EventHandler(this.btnCancelQuote_Click);
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelQuote);
            this.Controls.Add(this.btnSaveQuote);
            this.Controls.Add(this.label1);
            this.Name = "DisplayQuote";
            this.Text = "DisplayQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveQuote;
        private System.Windows.Forms.Button btnCancelQuote;
    }
}