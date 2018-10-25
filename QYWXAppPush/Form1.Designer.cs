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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_mediaid = new System.Windows.Forms.TextBox();
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bt_SimpleUpload = new System.Windows.Forms.Button();
            this.bt_SimpleSend = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_SimpleMsgtype = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_SimpleDescription = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb_author = new System.Windows.Forms.TextBox();
            this.label_author = new System.Windows.Forms.Label();
            this.tb_content = new System.Windows.Forms.TextBox();
            this.label_content = new System.Windows.Forms.Label();
            this.label_mediaid2 = new System.Windows.Forms.Label();
            this.tb_btntxt = new System.Windows.Forms.TextBox();
            this.label_btntxt = new System.Windows.Forms.Label();
            this.bt_ComplexUpload = new System.Windows.Forms.Button();
            this.bt_ComplexSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_ComplexMsgtype = new System.Windows.Forms.ComboBox();
            this.tb_mediaid2 = new System.Windows.Forms.TextBox();
            this.tb_PicUrl = new System.Windows.Forms.TextBox();
            this.label_picurl = new System.Windows.Forms.Label();
            this.tb_url = new System.Windows.Forms.TextBox();
            this.label_url = new System.Windows.Forms.Label();
            this.label_des = new System.Windows.Forms.Label();
            this.tb_title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_ComplexDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tabcontrol.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(43, 199);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(514, 226);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // tb_mediaid
            // 
            this.tb_mediaid.Location = new System.Drawing.Point(371, 75);
            this.tb_mediaid.Multiline = true;
            this.tb_mediaid.Name = "tb_mediaid";
            this.tb_mediaid.Size = new System.Drawing.Size(186, 44);
            this.tb_mediaid.TabIndex = 11;
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.tabPage1);
            this.tabcontrol.Controls.Add(this.tabPage2);
            this.tabcontrol.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrol.Location = new System.Drawing.Point(0, 0);
            this.tabcontrol.Multiline = true;
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(603, 493);
            this.tabcontrol.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bt_SimpleUpload);
            this.tabPage1.Controls.Add(this.bt_SimpleSend);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.cb_SimpleMsgtype);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.tb_SimpleDescription);
            this.tabPage1.Controls.Add(this.tb_mediaid);
            this.tabPage1.Controls.Add(this.pictureBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(595, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "简单消息推送服务";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bt_SimpleUpload
            // 
            this.bt_SimpleUpload.Location = new System.Drawing.Point(467, 152);
            this.bt_SimpleUpload.Name = "bt_SimpleUpload";
            this.bt_SimpleUpload.Size = new System.Drawing.Size(90, 23);
            this.bt_SimpleUpload.TabIndex = 18;
            this.bt_SimpleUpload.Text = "选择文件";
            this.bt_SimpleUpload.UseVisualStyleBackColor = true;
            this.bt_SimpleUpload.Click += new System.EventHandler(this.Upload);
            // 
            // bt_SimpleSend
            // 
            this.bt_SimpleSend.Location = new System.Drawing.Point(371, 152);
            this.bt_SimpleSend.Name = "bt_SimpleSend";
            this.bt_SimpleSend.Size = new System.Drawing.Size(90, 23);
            this.bt_SimpleSend.TabIndex = 17;
            this.bt_SimpleSend.Text = "推送";
            this.bt_SimpleSend.UseVisualStyleBackColor = true;
            this.bt_SimpleSend.Click += new System.EventHandler(this.Send);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(369, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "选择推送方式：";
            // 
            // cb_SimpleMsgtype
            // 
            this.cb_SimpleMsgtype.FormattingEnabled = true;
            this.cb_SimpleMsgtype.Items.AddRange(new object[] {
            "text",
            "image",
            "voice",
            "file"});
            this.cb_SimpleMsgtype.Location = new System.Drawing.Point(464, 35);
            this.cb_SimpleMsgtype.Name = "cb_SimpleMsgtype";
            this.cb_SimpleMsgtype.Size = new System.Drawing.Size(93, 20);
            this.cb_SimpleMsgtype.TabIndex = 15;
            this.cb_SimpleMsgtype.SelectedIndexChanged += new System.EventHandler(this.cb_SimpleMsgtype_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "   描述内容：";
            // 
            // tb_SimpleDescription
            // 
            this.tb_SimpleDescription.Location = new System.Drawing.Point(43, 75);
            this.tb_SimpleDescription.Multiline = true;
            this.tb_SimpleDescription.Name = "tb_SimpleDescription";
            this.tb_SimpleDescription.Size = new System.Drawing.Size(239, 100);
            this.tb_SimpleDescription.TabIndex = 13;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tb_author);
            this.tabPage2.Controls.Add(this.label_author);
            this.tabPage2.Controls.Add(this.tb_content);
            this.tabPage2.Controls.Add(this.label_content);
            this.tabPage2.Controls.Add(this.label_mediaid2);
            this.tabPage2.Controls.Add(this.tb_btntxt);
            this.tabPage2.Controls.Add(this.label_btntxt);
            this.tabPage2.Controls.Add(this.bt_ComplexUpload);
            this.tabPage2.Controls.Add(this.bt_ComplexSend);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cb_ComplexMsgtype);
            this.tabPage2.Controls.Add(this.tb_mediaid2);
            this.tabPage2.Controls.Add(this.tb_PicUrl);
            this.tabPage2.Controls.Add(this.label_picurl);
            this.tabPage2.Controls.Add(this.tb_url);
            this.tabPage2.Controls.Add(this.label_url);
            this.tabPage2.Controls.Add(this.label_des);
            this.tabPage2.Controls.Add(this.tb_title);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tb_ComplexDescription);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(595, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "复杂消息推送服务";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tb_author
            // 
            this.tb_author.Location = new System.Drawing.Point(440, 222);
            this.tb_author.Name = "tb_author";
            this.tb_author.Size = new System.Drawing.Size(119, 21);
            this.tb_author.TabIndex = 36;
            // 
            // label_author
            // 
            this.label_author.AutoSize = true;
            this.label_author.Location = new System.Drawing.Point(371, 225);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(41, 12);
            this.label_author.TabIndex = 35;
            this.label_author.Text = "作者：";
            // 
            // tb_content
            // 
            this.tb_content.Location = new System.Drawing.Point(94, 285);
            this.tb_content.Multiline = true;
            this.tb_content.Name = "tb_content";
            this.tb_content.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_content.Size = new System.Drawing.Size(239, 53);
            this.tb_content.TabIndex = 34;
            // 
            // label_content
            // 
            this.label_content.AutoSize = true;
            this.label_content.Location = new System.Drawing.Point(23, 285);
            this.label_content.Name = "label_content";
            this.label_content.Size = new System.Drawing.Size(65, 12);
            this.label_content.TabIndex = 33;
            this.label_content.Text = "具体内容：";
            // 
            // label_mediaid2
            // 
            this.label_mediaid2.AutoSize = true;
            this.label_mediaid2.Location = new System.Drawing.Point(371, 118);
            this.label_mediaid2.Name = "label_mediaid2";
            this.label_mediaid2.Size = new System.Drawing.Size(65, 12);
            this.label_mediaid2.TabIndex = 32;
            this.label_mediaid2.Text = "media_id：";
            // 
            // tb_btntxt
            // 
            this.tb_btntxt.Location = new System.Drawing.Point(94, 86);
            this.tb_btntxt.Name = "tb_btntxt";
            this.tb_btntxt.Size = new System.Drawing.Size(239, 21);
            this.tb_btntxt.TabIndex = 31;
            // 
            // label_btntxt
            // 
            this.label_btntxt.AutoSize = true;
            this.label_btntxt.Location = new System.Drawing.Point(23, 89);
            this.label_btntxt.Name = "label_btntxt";
            this.label_btntxt.Size = new System.Drawing.Size(65, 12);
            this.label_btntxt.TabIndex = 30;
            this.label_btntxt.Text = "按钮文字：";
            // 
            // bt_ComplexUpload
            // 
            this.bt_ComplexUpload.Location = new System.Drawing.Point(469, 280);
            this.bt_ComplexUpload.Name = "bt_ComplexUpload";
            this.bt_ComplexUpload.Size = new System.Drawing.Size(90, 23);
            this.bt_ComplexUpload.TabIndex = 29;
            this.bt_ComplexUpload.Text = "选择文件";
            this.bt_ComplexUpload.UseVisualStyleBackColor = true;
            this.bt_ComplexUpload.Click += new System.EventHandler(this.Upload);
            // 
            // bt_ComplexSend
            // 
            this.bt_ComplexSend.Location = new System.Drawing.Point(373, 280);
            this.bt_ComplexSend.Name = "bt_ComplexSend";
            this.bt_ComplexSend.Size = new System.Drawing.Size(90, 23);
            this.bt_ComplexSend.TabIndex = 28;
            this.bt_ComplexSend.Text = "推送";
            this.bt_ComplexSend.UseVisualStyleBackColor = true;
            this.bt_ComplexSend.Click += new System.EventHandler(this.Send);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 27;
            this.label1.Text = "选择推送方式：";
            // 
            // cb_ComplexMsgtype
            // 
            this.cb_ComplexMsgtype.FormattingEnabled = true;
            this.cb_ComplexMsgtype.Items.AddRange(new object[] {
            "video",
            "textcard",
            "news",
            "mpnews"});
            this.cb_ComplexMsgtype.Location = new System.Drawing.Point(466, 44);
            this.cb_ComplexMsgtype.Name = "cb_ComplexMsgtype";
            this.cb_ComplexMsgtype.Size = new System.Drawing.Size(93, 20);
            this.cb_ComplexMsgtype.TabIndex = 26;
            this.cb_ComplexMsgtype.SelectedIndexChanged += new System.EventHandler(this.cb_ComplexMsgtype_SelectedIndexChanged);
            // 
            // tb_mediaid2
            // 
            this.tb_mediaid2.Location = new System.Drawing.Point(373, 144);
            this.tb_mediaid2.Multiline = true;
            this.tb_mediaid2.Name = "tb_mediaid2";
            this.tb_mediaid2.Size = new System.Drawing.Size(186, 44);
            this.tb_mediaid2.TabIndex = 25;
            // 
            // tb_PicUrl
            // 
            this.tb_PicUrl.Location = new System.Drawing.Point(94, 167);
            this.tb_PicUrl.Name = "tb_PicUrl";
            this.tb_PicUrl.Size = new System.Drawing.Size(239, 21);
            this.tb_PicUrl.TabIndex = 24;
            // 
            // label_picurl
            // 
            this.label_picurl.AutoSize = true;
            this.label_picurl.Location = new System.Drawing.Point(29, 170);
            this.label_picurl.Name = "label_picurl";
            this.label_picurl.Size = new System.Drawing.Size(59, 12);
            this.label_picurl.TabIndex = 23;
            this.label_picurl.Text = "图片Url：";
            // 
            // tb_url
            // 
            this.tb_url.Location = new System.Drawing.Point(94, 127);
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(239, 21);
            this.tb_url.TabIndex = 22;
            // 
            // label_url
            // 
            this.label_url.AutoSize = true;
            this.label_url.Location = new System.Drawing.Point(29, 130);
            this.label_url.Name = "label_url";
            this.label_url.Size = new System.Drawing.Size(59, 12);
            this.label_url.TabIndex = 21;
            this.label_url.Text = "跳转Url：";
            // 
            // label_des
            // 
            this.label_des.AutoSize = true;
            this.label_des.Location = new System.Drawing.Point(23, 210);
            this.label_des.Name = "label_des";
            this.label_des.Size = new System.Drawing.Size(65, 12);
            this.label_des.TabIndex = 20;
            this.label_des.Text = "描述内容：";
            // 
            // tb_title
            // 
            this.tb_title.Location = new System.Drawing.Point(94, 46);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(239, 21);
            this.tb_title.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 36);
            this.label3.TabIndex = 18;
            this.label3.Text = "标题(视频\r\n  文本卡片：\r\n  图文需要)";
            // 
            // tb_ComplexDescription
            // 
            this.tb_ComplexDescription.Location = new System.Drawing.Point(94, 207);
            this.tb_ComplexDescription.Multiline = true;
            this.tb_ComplexDescription.Name = "tb_ComplexDescription";
            this.tb_ComplexDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_ComplexDescription.Size = new System.Drawing.Size(239, 58);
            this.tb_ComplexDescription.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(603, 493);
            this.Controls.Add(this.tabcontrol);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "微信应用消息推送";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tabcontrol.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_mediaid;
        private System.Windows.Forms.TabControl tabcontrol;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_SimpleDescription;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bt_SimpleUpload;
        private System.Windows.Forms.Button bt_SimpleSend;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_SimpleMsgtype;
        private System.Windows.Forms.TextBox tb_PicUrl;
        private System.Windows.Forms.Label label_picurl;
        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.Label label_url;
        private System.Windows.Forms.Label label_des;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_ComplexDescription;
        private System.Windows.Forms.Button bt_ComplexUpload;
        private System.Windows.Forms.Button bt_ComplexSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_ComplexMsgtype;
        private System.Windows.Forms.TextBox tb_mediaid2;
        private System.Windows.Forms.TextBox tb_content;
        private System.Windows.Forms.Label label_content;
        private System.Windows.Forms.Label label_mediaid2;
        private System.Windows.Forms.TextBox tb_btntxt;
        private System.Windows.Forms.Label label_btntxt;
        private System.Windows.Forms.TextBox tb_author;
        private System.Windows.Forms.Label label_author;
    }
}

