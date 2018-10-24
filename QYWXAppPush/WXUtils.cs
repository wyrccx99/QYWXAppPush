using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QYWXAppPush.Bean;

namespace QYWXAppPush
{
    class WXUtils
    {
        #region 检测文件大小
        //检测文件大小
        public static string CheckFileSize(string filepath, string msgtype)
        {
            string result = "";
            try
            {
                byte[] fileByte = new byte[1024]; // 文件内容二进制
                FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
                fileByte = new byte[fs.Length]; // 二进制文件
                fs.Read(fileByte, 0, Convert.ToInt32(fs.Length));
                fs.Close();
                long b = fileByte.Length;
                for (int i = 0; i < 2; i++)
                {
                    b /= 1024;
                }

                switch (msgtype)
                {
                    case "image":
                        if (b > 2)
                            result = "图片大小超出限制";
                        break;
                    case "voice":
                        if (b > 2)
                            result = "语音大小超出限制";
                        break;
                    case "video":
                        if (b > 10)
                            result = "视频大小超出限制";
                        break;
                    case "file":
                        if (b > 20)
                            result = "文件大小超出限制";
                        break;
                }
            }
            catch (OverflowException)
            {
                result = "选择的文件大小超出限制";
                return result;
            }
            return result;

        }
        #endregion

        #region 消息发送函数
        //发送消息
        public static string SendMessage(string touser, string toparty, string totag, string msgtype, int agentid, string media_id_or_content, int safe, string token)
        {
            string result = "";
            string messagejson = "";
            Text text;
            TextMessage textmessage;
            switch (msgtype)
            {

                case "text":
                    text = new Text();
                    textmessage = new TextMessage();
                    text.content = media_id_or_content;
                    textmessage.touser = touser;
                    textmessage.msgtype = msgtype;
                    textmessage.agentid = agentid;
                    textmessage.text = text;
                    messagejson = JsonConvert.SerializeObject(textmessage);
                    result = PostJson(token, messagejson);
                    break;
                case "image":
                    Image image = new Image();
                    image.media_id = media_id_or_content;
                    ImageMessage imagemessage = new ImageMessage();
                    imagemessage.touser = touser;
                    imagemessage.msgtype = msgtype;
                    imagemessage.agentid = agentid;
                    imagemessage.image = image;
                    messagejson = JsonConvert.SerializeObject(imagemessage);
                    result = PostJson(token, messagejson);
                    break;
                case "voice":
                    Voice voice = new Voice();
                    voice.media_id = media_id_or_content;
                    VoiceMessage voicemessage = new VoiceMessage();
                    voicemessage.touser = touser;
                    voicemessage.msgtype = msgtype;
                    voicemessage.agentid = agentid;
                    voicemessage.voice = voice;
                    messagejson = JsonConvert.SerializeObject(voicemessage);
                    result = PostJson(token, messagejson);
                    break;
                case "file":
                    Files file = new Files();
                    file.media_id = media_id_or_content;
                    FilesMessage filemessage = new FilesMessage();
                    filemessage.touser = touser;
                    filemessage.msgtype = msgtype;
                    filemessage.agentid = agentid;
                    filemessage.file = file;
                    messagejson = JsonConvert.SerializeObject(filemessage);
                    result = PostJson(token, messagejson);
                    break;
                default:
                    text = new Text();
                    textmessage = new TextMessage();
                    text.content = media_id_or_content;
                    textmessage.touser = touser;
                    textmessage.msgtype = msgtype;
                    textmessage.agentid = agentid;
                    textmessage.text = text;
                    messagejson = JsonConvert.SerializeObject(textmessage);
                    result = PostJson(token, messagejson);
                    break;
            }
            return result;
        }
        #endregion

        #region WXAPI post请求
        //访问微信url并返回微信信息
        public static string PostJson(string token, string postDataStr)
        {
            string postUrl = "https://qyapi.weixin.qq.com/cgi-bin/message/send?access_token=" + token;
            string strResult = "";
            try
            {
                ServicePointManager.DefaultConnectionLimit = 200;
                byte[] bytes = Encoding.UTF8.GetBytes(postDataStr);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(postUrl);
                //声明一个HttpWebRequest请求  
                request.Timeout = 600000;
                request.ReadWriteTimeout = 600000;
                request.KeepAlive = false;

                request.Method = "POST";
                request.ContentLength = bytes.Length;
                request.ContentType = "text/xml";
                Stream reqstream = request.GetRequestStream();
                reqstream.Write(bytes, 0, bytes.Length);

                //设置连接超时时间  
                request.Headers.Set("Pragma", "no-cache");

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream streamReceive = response.GetResponseStream();
                Encoding encoding = Encoding.UTF8;

                StreamReader streamReader = new StreamReader(streamReceive, encoding);
                strResult = streamReader.ReadToEnd();
                streamReceive.Dispose();
                streamReader.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return strResult;
        }
        #endregion


        //上传素材到微信服务器返回media_id
        public static Result UploadMaterial(string filepath, string filename, string token, string type)
        {
            string resultStr = "";
            string postUrl = string.Format("https://qyapi.weixin.qq.com/cgi-bin/media/upload?access_token={0}&type={1}", token, type);
            try
            {
                //byte[] bytes = Encoding.UTF8.GetBytes();
                string boundary = "----WebKitFormBoundary7MA4YWxkTrZu0gW";

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(postUrl);
                CookieContainer cookieContainer = new CookieContainer();
                request.CookieContainer = cookieContainer;
                request.AllowAutoRedirect = true;
                //声明一个HttpWebRequest请求  
                request.Timeout = 600000;
                request.ReadWriteTimeout = 600000;
                request.KeepAlive = false;
                request.Method = "POST";
                request.Headers.Set("Pragma", "no-cache");
                request.ContentType = "multipart/form-data;charset=utf-8;boundary=" + boundary;

                #region 将文件转成二进制

                byte[] fileByte = new byte[1024]; // 文件内容二进制
                FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
                fileByte = new byte[fs.Length]; // 二进制文件
                fs.Read(fileByte, 0, Convert.ToInt32(fs.Length));
                fs.Close();
                //MessageBox.Show(fileByte.Length.ToString());
                #endregion

                byte[] itemBoundaryBytes = Encoding.UTF8.GetBytes("\r\n--" + boundary + "\r\n");
                byte[] endBoundaryBytes = Encoding.UTF8.GetBytes("\r\n--" + boundary + "--\r\n");

                //请求头部信息
                StringBuilder sbHeader =
                    new StringBuilder(
                        string.Format(
                            "Content-Disposition:form-data;name=\"media\";filename=\"{0}\"\r\nContent-Type:application/octet-stream\r\n\r\n",
                            filename));
                byte[] postHeaderBytes = Encoding.UTF8.GetBytes(sbHeader.ToString());

                Stream postStream = request.GetRequestStream();
                postStream.Write(itemBoundaryBytes, 0, itemBoundaryBytes.Length);
                postStream.Write(postHeaderBytes, 0, postHeaderBytes.Length);
                postStream.Write(fileByte, 0, fileByte.Length);
                postStream.Write(endBoundaryBytes, 0, endBoundaryBytes.Length);
                postStream.Close();

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream streamReceive = response.GetResponseStream();
                Encoding encoding = Encoding.UTF8;

                StreamReader streamReader = new StreamReader(streamReceive, encoding);
                resultStr = streamReader.ReadToEnd();
                streamReceive.Dispose();
                streamReader.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Result result = JsonConvert.DeserializeObject<Result>(resultStr);
            return result;
        }

        //根据CorpID，secret，code获取微信openid、access token信息
        //访问微信url并返回微信信息
        public static string GetToken(string curcorpid, string curcorpsecret)
        {
            string result = "";
            string url = "https://qyapi.weixin.qq.com/cgi-bin/gettoken?corpid=" + curcorpid + "&corpsecret=" + curcorpsecret;
            try
            {
                WebClient wc = new WebClient();
                wc.Credentials = CredentialCache.DefaultCredentials;
                wc.Encoding = Encoding.UTF8;
                result = wc.DownloadString(url);
                if (result.Contains("errcode"))
                {
                    //MessageBox.Show(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            CorpToken Corp_Token_Model = JsonConvert.DeserializeObject<CorpToken>(result);
            return Corp_Token_Model.access_token;
        }

        //获取文件后缀名
        public static string GetExtra(String filename)
        {
            string extra;
            extra = filename.Substring(filename.IndexOf("."));
            return extra;
        }
    }
}
