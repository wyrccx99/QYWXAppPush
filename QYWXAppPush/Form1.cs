using Newtonsoft.Json;
using System;
using System.Windows.Forms;
using static QYWXAppPush.Bean;

namespace QYWXAppPush
{
    public partial class Form1 : Form
    {
        public string corpid = "**********";
        public string corpsecret = "*****************";//通讯小助手Secret
        public int agentId = 1000010;
        public static string filepath = "";
        public static string filename = "";
        static string access_token = "";
        static string msgtype = "";
        static Result result;
        public Form1()
        {
            access_token = WXUtils.GetToken(corpid, corpsecret);
            InitializeComponent();
            bt_Upload.Visible = false;
            //pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            //pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void bt_Send_Click(object sender, EventArgs e)
        {
            /*text.content = "你的快递已到，请携带工卡前往邮件中心领取。\n出发前可查看" +
                "<a href=\"http://work.weixin.qq.com\">邮件中心视频实况" +
                "</a>，聪明避开排队。";*/
            string resultStr = WXUtils.SendMessage("706615", null, null, msgtype, agentId, tb_mediaid.Text, 0, access_token);
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

        private void bt_Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;//该值确定是否可以选择多个文件
            dialog.Title = "请选择要上传的文件"; //窗体标题
            switch (msgtype)
            {
                case "image":
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
                    result = WXUtils.UploadMaterial(filepath, filename, access_token, msgtype);
                    if (result.errcode == 0)
                    {
                        tb_mediaid.Text = result.media_id;
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

        private void cb_msgtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_mediaid.Text = "";
            msgtype = cb_msgtype.SelectedItem.ToString();
            if (!msgtype.Equals("text"))
            {
                bt_Upload.Visible = true;
            }
            else
            {
                bt_Upload.Visible = false;
            }
        }

    }
}
