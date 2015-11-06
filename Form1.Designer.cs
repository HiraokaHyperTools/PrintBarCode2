namespace PrintBarCode2 {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.TextBox();
            this.bPrint = new System.Windows.Forms.Button();
            this.bTIF = new System.Windows.Forms.Button();
            this.bPDF = new System.Windows.Forms.Button();
            this.cbb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "バーコード番号 (両端*なし)：";
            // 
            // tb
            // 
            this.tb.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tb.Location = new System.Drawing.Point(12, 33);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(249, 28);
            this.tb.TabIndex = 1;
            // 
            // bPrint
            // 
            this.bPrint.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bPrint.Location = new System.Drawing.Point(12, 123);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(150, 46);
            this.bPrint.TabIndex = 3;
            this.bPrint.Text = "印刷";
            this.bPrint.UseVisualStyleBackColor = true;
            this.bPrint.Click += new System.EventHandler(this.bPrint_Click);
            // 
            // bTIF
            // 
            this.bTIF.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bTIF.Location = new System.Drawing.Point(168, 123);
            this.bTIF.Name = "bTIF";
            this.bTIF.Size = new System.Drawing.Size(150, 46);
            this.bTIF.TabIndex = 4;
            this.bTIF.Text = "&TIF";
            this.bTIF.UseVisualStyleBackColor = true;
            this.bTIF.Click += new System.EventHandler(this.bTIF_Click);
            // 
            // bPDF
            // 
            this.bPDF.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bPDF.Location = new System.Drawing.Point(324, 123);
            this.bPDF.Name = "bPDF";
            this.bPDF.Size = new System.Drawing.Size(150, 46);
            this.bPDF.TabIndex = 5;
            this.bPDF.Text = "&PDF";
            this.bPDF.UseVisualStyleBackColor = true;
            this.bPDF.Click += new System.EventHandler(this.bPDF_Click);
            // 
            // cbb
            // 
            this.cbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbb.FormattingEnabled = true;
            this.cbb.Location = new System.Drawing.Point(12, 67);
            this.cbb.Name = "cbb";
            this.cbb.Size = new System.Drawing.Size(462, 29);
            this.cbb.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(498, 186);
            this.Controls.Add(this.cbb);
            this.Controls.Add(this.bPDF);
            this.Controls.Add(this.bTIF);
            this.Controls.Add(this.bPrint);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "バーコード印刷2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Button bPrint;
        private System.Windows.Forms.Button bTIF;
        private System.Windows.Forms.Button bPDF;
        private System.Windows.Forms.ComboBox cbb;
    }
}

