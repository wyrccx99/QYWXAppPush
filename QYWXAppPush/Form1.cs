using Newtonsoft.Json;
using System;
using System.Windows.Forms;
using static QYWXAppPush.Bean;
using System.Configuration;

namespace QYWXAppPush
{
    public partial class Form1 : Form
    {
        public string corpid = ConfigurationManager.AppSettings["corpid"];//企业微信id
        public string corpsecret = ConfigurationManager.AppSettings["corpsecret"];//企业微信应用secret
        //public int agentId = Convert.ToInt32(ConfigurationManager.AppSettings["agentid"]);//企业微信应用id
        public static string filepath = "";
        public static string filename = "";
        static string access_token = "";
        static string msgtype = "";
        static string receivers = "";
        static Result result;
        static string media_id;
        static Receiver receiver;
        public Form1()
        {
            access_token = WXUtils.GetToken(corpid, corpsecret);
            InitializeComponent();
            receiver = new Receiver();
            bt_SimpleUpload.Visible = false;
            bt_ComplexUpload.Visible = false;
            tb_mediaid2.Visible = false;
            tb_PicUrl.Visible = false;
            tb_url.Visible = false;
            tb_content.Visible = false;
            label_picurl.Visible = false;
            label_url.Visible = false;
            label_content.Visible = false;
            label_author.Visible = false;
            tb_author.Visible = false;

            cb_Receiver.SelectedIndex = 3;
            cb_ComplexMsgtype.SelectedIndex = 0;
            cb_SimpleMsgtype.SelectedIndex = 0;
            receivers = cb_Receiver.SelectedItem.ToString();
            receiver.touser = receivers;
        }

        private void Send(object sender, EventArgs e)
        {
            /*text.content = "你的快递已到，请携带工卡前往邮件中心领取。\n出发前可查看" +
                "<a href=\"http://work.weixin.qq.com\">邮件中心视频实况" +
                "</a>，聪明避开排队。";*/
            
            Content content = new Content();
            content.title = tb_title.Text;
            content.url = tb_url.Text;
            content.btntxt = tb_btntxt.Text;
            content.picurl = tb_PicUrl.Text;
            content.text = tb_SimpleDescription.Text;
            content.content = tb_content.Text;
            content.description = tb_ComplexDescription.Text;
            content.author = tb_author.Text;
            string resultStr = WXUtils.SendMessage(receiver, msgtype, content, media_id, 0, access_token);
            result = JsonConvert.DeserializeObject<Result>(resultStr);
            if (result.errcode == 0)
            {
                MessageBox.Show("推送成功~");
            }
            else
            {
                MessageBox.Show(result.errmsg);
            }

        }

        private void Upload(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;//该值确定是否可以选择多个文件
            dialog.Title = "请选择要上传的文件"; //窗体标题
            switch (msgtype)
            {
                case "image":
                    dialog.Filter = "文件(*.jpg,*.jpeg,*.png,*.gif)|*.jpg;*.jpeg;*.png;*.gif"; //文件筛选
                    break;
                case "mpnews":
                    dialog.Filter = "文件(*.jpg,*.jpeg,*.png,*.gif)|*.jpg;*.jpeg;*.png;*.gif"; //文件筛选
                    break;
                case "voice":
                    dialog.Filter = "文件(*.amr)|*.amr"; //文件筛选
                    break;
                case "video":
                    dialog.Filter = "文件(*.mp4,*.mpeg,*.mpg,*.dat,*flv)|*.mp4;*.mpeg;*.mpg;*.dat;*.flv"; //文件筛选
                    break;
                default:
                    break;
            }
            //dialog.Filter = "文件(*.jpg,*.png,*.gif)|*.jpg;*.png;*.gif"; //文件筛选
            //默认路径设置为我的电脑文件夹
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (dialog.FileName.Length != 0)
                {
                    filepath = dialog.FileName;//文件夹路径
                    filename = filepath.Substring(filepath.LastIndexOf("\\") + 1); //格式化处理，提取文件名
                    //File.Copy(file, Application.StartupPath + "\\cai\\" + lujin, false); //复制到的目录切记要加文件名！！！
                    string extra = WXUtils.GetExtra(filename);
                    if (extra.Equals(".jpg") || extra.Equals(".jpeg") || extra.Equals(".png") || extra.Equals(".gif"))
                    {
                        pictureBox.Load(filepath);
                    }
                    //pictureBox.Load(filepath);
                }
                else
                {
                    MessageBox.Show("当前未选择文件");
                }

            }
            if (!filepath.Equals("") && !filename.Equals(""))
            {

                string checkfilesize = WXUtils.CheckFileSize(filepath, msgtype);
                if (checkfilesize.Equals(""))
                {
                    if (msgtype.Equals("mpnews"))
                    {
                        result = WXUtils.UploadMaterial(filepath, filename, access_token, "image");
                    }
                    else
                    {
                        result = WXUtils.UploadMaterial(filepath, filename, access_token, msgtype);
                    }

                    
                    if (result.errcode == 0)
                    {
                        tb_mediaid.Text = result.media_id;
                        tb_mediaid2.Text = result.media_id;
                        media_id = result.media_id;
                    }
                    else
                    {
                        MessageBox.Show(result.errmsg);
                    }

                }
                else
                {
                    MessageBox.Show(checkfilesize);
                }

            }
            else
            {
                MessageBox.Show("当前未选择文件");
            }

        }

        private void cb_SimpleMsgtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_mediaid.Text = "";
            tb_SimpleDescription.Text = "";
            msgtype = cb_SimpleMsgtype.SelectedItem.ToString();
            if (!msgtype.Equals("text"))
            {
                bt_SimpleUpload.Visible = true;
                label_simpledes.Visible = false;
                tb_SimpleDescription.Visible = false;
            }
            else
            {
                bt_SimpleUpload.Visible = false;
                label_simpledes.Visible = true;
                tb_SimpleDescription.Visible = true;
            }
        }

        private void cb_ComplexMsgtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_mediaid2.Text = "";
            tb_ComplexDescription.Text = "";
            tb_title.Text = "";
            tb_url.Text = "";
            tb_PicUrl.Text = "";
            tb_content.Text = "";
            tb_author.Text = "";
            tb_btntxt.Text = "";

            msgtype = cb_ComplexMsgtype.SelectedItem.ToString();
            
            if (msgtype.Equals("textcard") || msgtype.Equals("news"))
            {
                bt_ComplexUpload.Visible = false;
                tb_mediaid2.Visible = false;
                tb_url.Visible = true;
                label_url.Visible = true;
                label_mediaid2.Visible = false;
                tb_btntxt.Visible = true;
                label_btntxt.Visible = true;
                label_author.Visible = false;
                tb_author.Visible = false;
                if (!msgtype.Equals("textcard"))
                {
                    tb_PicUrl.Visible = true;
                    label_picurl.Visible = true;
                }
            }
            else if(msgtype.Equals("video"))
            {
                bt_ComplexUpload.Visible = true;
                tb_mediaid2.Visible = true;
                tb_PicUrl.Visible = false;
                tb_url.Visible = false;
                label_picurl.Visible = false;
                label_url.Visible = false;
                tb_btntxt.Visible = false;
                label_btntxt.Visible = false;
                label_mediaid2.Visible = true;
                label_author.Visible = false;
                tb_author.Visible = false;
            }
            else
            {
                tb_btntxt.Visible = true;
                label_btntxt.Visible = true;
                bt_ComplexUpload.Visible = true;
                tb_mediaid2.Visible = true;
                tb_PicUrl.Visible = false;
                tb_url.Visible = true;
                label_picurl.Visible = false;
                label_url.Visible = true;
                label_mediaid2.Visible = true;
                label_author.Visible = true;
                tb_author.Visible = true;
                tb_content.Visible = true;
                label_content.Visible = true;
            }
        }

        private void cb_Receiver_SelectedIndexChanged(object sender, EventArgs e)
        {
            receivers = cb_Receiver.SelectedItem.ToString();

            if (receivers.Equals("@all"))
            {
                tb_Receiver.Visible = false;
            }
            else
            {
                tb_Receiver.Visible = true;
            }
        }

        private void tb_Receiver_TextChanged(object sender, EventArgs e)
        {
            if (receivers.Equals("@all"))
            {
                receiver.touser = "@all";
                receiver.toparty = "";
                receiver.totag = "";
            }
            else if (receivers.Equals("touser"))
            {
                receiver.touser = tb_Receiver.Text;
            }
            else if (receivers.Equals("toparty"))
            {
                receiver.toparty = tb_Receiver.Text;
            }
            else if (receivers.Equals("totag"))
            {
                receiver.totag = tb_Receiver.Text;
            }
        }

    }
}
