namespace DOAN
{
    partial class ThongKeKho
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
            this.grvKho = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grvKho)).BeginInit();
            this.SuspendLayout();
            // 
            // grvKho
            // 
            this.grvKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvKho.Location = new System.Drawing.Point(12, 73);
            this.grvKho.Name = "grvKho";
            this.grvKho.Size = new System.Drawing.Size(648, 150);
            this.grvKho.TabIndex = 0;
            // 
            // ThongKeKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 438);
            this.Controls.Add(this.grvKho);
            this.Name = "ThongKeKho";
            this.Text = "Thống kê kho";
            this.Load += new System.EventHandler(this.ThongKeKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grvKho;
    }
}