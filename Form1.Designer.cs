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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbHorz = new System.Windows.Forms.RadioButton();
            this.rbVert = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "バーコード番号 (両端*なし)：";
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(12, 33);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(249, 28);
            this.tb.TabIndex = 1;
            // 
            // bPrint
            // 
            this.bPrint.Location = new System.Drawing.Point(12, 230);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(150, 46);
            this.bPrint.TabIndex = 3;
            this.bPrint.Text = "印刷";
            this.bPrint.UseVisualStyleBackColor = true;
            this.bPrint.Click += new System.EventHandler(this.bPrint_Click);
            // 
            // bTIF
            // 
            this.bTIF.Location = new System.Drawing.Point(168, 230);
            this.bTIF.Name = "bTIF";
            this.bTIF.Size = new System.Drawing.Size(150, 46);
            this.bTIF.TabIndex = 4;
            this.bTIF.Text = "&TIF";
            this.bTIF.UseVisualStyleBackColor = true;
            this.bTIF.Click += new System.EventHandler(this.bTIF_Click);
            // 
            // bPDF
            // 
            this.bPDF.Location = new System.Drawing.Point(324, 230);
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
            this.cbb.FormattingEnabled = true;
            this.cbb.Location = new System.Drawing.Point(12, 67);
            this.cbb.Name = "cbb";
            this.cbb.Size = new System.Drawing.Size(462, 29);
            this.cbb.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbVert);
            this.groupBox1.Controls.Add(this.rbHorz);
            this.groupBox1.Location = new System.Drawing.Point(12, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 102);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "バーコードの配置";
            // 
            // rbHorz
            // 
            this.rbHorz.AutoSize = true;
            this.rbHorz.Checked = true;
            this.rbHorz.Location = new System.Drawing.Point(6, 27);
            this.rbHorz.Name = "rbHorz";
            this.rbHorz.Size = new System.Drawing.Size(93, 25);
            this.rbHorz.TabIndex = 0;
            this.rbHorz.TabStop = true;
            this.rbHorz.Text = "横 2 列";
            this.rbHorz.UseVisualStyleBackColor = true;
            // 
            // rbVert
            // 
            this.rbVert.AutoSize = true;
            this.rbVert.Location = new System.Drawing.Point(6, 58);
            this.rbVert.Name = "rbVert";
            this.rbVert.Size = new System.Drawing.Size(93, 25);
            this.rbVert.TabIndex = 1;
            this.rbVert.Text = "縦 2 行";
            this.rbVert.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(498, 288);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbb);
            this.Controls.Add(this.bPDF);
            this.Controls.Add(this.bTIF);
            this.Controls.Add(this.bPrint);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS UI Gothic", 15.75F);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "バーコード印刷2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbVert;
        private System.Windows.Forms.RadioButton rbHorz;
    }
}

