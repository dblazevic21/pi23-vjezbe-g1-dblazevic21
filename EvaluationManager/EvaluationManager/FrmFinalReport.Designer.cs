namespace EvaluationManager {
    partial class FrmFinalReport {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.btnGenReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(700, 349);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Zatvori";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(12, 12);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.Size = new System.Drawing.Size(763, 303);
            this.dgvResults.TabIndex = 1;
            // 
            // btnGenReport
            // 
            this.btnGenReport.Location = new System.Drawing.Point(12, 349);
            this.btnGenReport.Name = "btnGenReport";
            this.btnGenReport.Size = new System.Drawing.Size(129, 23);
            this.btnGenReport.TabIndex = 2;
            this.btnGenReport.Text = "Generiraj izvještaj";
            this.btnGenReport.UseVisualStyleBackColor = true;
            // 
            // FrmFinalReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 384);
            this.Controls.Add(this.btnGenReport);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.btnClose);
            this.Name = "FrmFinalReport";
            this.Text = "FrmFinalReport";
            this.Load += new System.EventHandler(this.FrmFinalReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Button btnGenReport;
    }
}