namespace QYWXAppPush
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_mediaid = new System.Windows.Forms.TextBox();
            this.bt_Send = new System.Windows.Forms.Button();
            this.bt_Upload = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.cb_msgtype = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_mediaid
            // 
            this.tb_mediaid.Location = new System.Drawing.Point(106, 44);
            this.tb_mediaid.Multiline = true;
            this.tb_mediaid.Name = "tb_mediaid";
            this.tb_mediaid.Size = new System.Drawing.Size(239, 95);
            this.tb_mediaid.TabIndex = 2;
            // 
            // bt_Send
            // 
            this.bt_Send.Location = new System.Drawing.Point(353, 113);
            this.bt_Send.Name = "bt_Send";
            this.bt_Send.Size = new System.Drawing.Size(90, 23);
            this.bt_Send.TabIndex = 3;
            this.bt_Send.Text = "推送";
            this.bt_Send.UseVisualStyleBackColor = true;
            this.bt_Send.Click += new System.EventHandler(this.bt_Send_Click);
            // 
            // bt_Upload
            // 
            this.bt_Upload.Location = new System.Drawing.Point(449, 113);
            this.bt_Upload.Name = "bt_Upload";
            this.bt_Upload.Size = new System.Drawing.Size(90, 23);
            this.bt_Upload.TabIndex = 4;
            this.bt_Upload.Text = "选择文件";
            this.bt_Upload.UseVisualStyleBackColor = true;
            this.bt_Upload.Click += new System.EventHandler(this.bt_Upload_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(106, 174);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(433, 300);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // cb_msgtype
            // 
            this.cb_msgtype.FormattingEnabled = true;
            this.cb_msgtype.Items.AddRange(new object[] {
            "text",
            "image",
            "voice",
            "file"});
            this.cb_msgtype.Location = new System.Drawing.Point(446, 49);
            this.cb_msgtype.Name = "cb_msgtype";
            this.cb_msgtype.Size = new System.Drawing.Size(93, 20);
            this.cb_msgtype.TabIndex = 7;
            this.cb_msgtype.SelectedIndexChanged += new System.EventHandler(this.cb_msgtype_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "选择推送方式：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_msgtype);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.bt_Upload);
            this.Controls.Add(this.bt_Send);
            this.Controls.Add(this.tb_mediaid);
            this.Name = "Form1";
            this.Text = "微信应用消息推送";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_mediaid;
        private System.Windows.Forms.Button bt_Send;
        private System.Windows.Forms.Button bt_Upload;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox cb_msgtype;
        private System.Windows.Forms.Label label1;
    }
}

