namespace KugouSkinRead
{
    partial class frmKGSkinExtract
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtResFile = new System.Windows.Forms.TextBox();
            this.btnResFile = new System.Windows.Forms.Button();
            this.btnSavePath = new System.Windows.Forms.Button();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.btnExtract = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResFile
            // 
            this.txtResFile.Location = new System.Drawing.Point(70, 52);
            this.txtResFile.Name = "txtResFile";
            this.txtResFile.Size = new System.Drawing.Size(288, 21);
            this.txtResFile.TabIndex = 0;
            // 
            // btnResFile
            // 
            this.btnResFile.Location = new System.Drawing.Point(364, 52);
            this.btnResFile.Name = "btnResFile";
            this.btnResFile.Size = new System.Drawing.Size(73, 23);
            this.btnResFile.TabIndex = 1;
            this.btnResFile.Text = "浏览";
            this.btnResFile.UseVisualStyleBackColor = true;
            this.btnResFile.Click += new System.EventHandler(this.btnResFile_Click);
            // 
            // btnSavePath
            // 
            this.btnSavePath.Location = new System.Drawing.Point(364, 88);
            this.btnSavePath.Name = "btnSavePath";
            this.btnSavePath.Size = new System.Drawing.Size(75, 23);
            this.btnSavePath.TabIndex = 3;
            this.btnSavePath.Text = "浏览";
            this.btnSavePath.UseVisualStyleBackColor = true;
            this.btnSavePath.Click += new System.EventHandler(this.btnSavePath_Click);
            // 
            // txtSavePath
            // 
            this.txtSavePath.Location = new System.Drawing.Point(70, 88);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(288, 21);
            this.txtSavePath.TabIndex = 2;
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(12, 124);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(427, 37);
            this.btnExtract.TabIndex = 4;
            this.btnExtract.Text = "提取";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "资源文件:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "保存路径:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(11, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(429, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "本程序没有自动排错功能，如提取过程中造成的一切问题自行承担。";
            // 
            // frmKGSkinExtract
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 172);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.btnSavePath);
            this.Controls.Add(this.txtSavePath);
            this.Controls.Add(this.btnResFile);
            this.Controls.Add(this.txtResFile);
            this.Name = "frmKGSkinExtract";
            this.Text = "酷狗kugou.skn资源提取";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmKGSkinExtract_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmKGSkinExtract_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResFile;
        private System.Windows.Forms.Button btnResFile;
        private System.Windows.Forms.Button btnSavePath;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

