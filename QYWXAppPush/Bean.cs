using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QYWXAppPush
{
    class Bean
    {
        //result返回消息类
        public class Result
        {
            public int errcode { get; set; }
            public string errmsg { get; set; }
            public string type { get; set; }
            public string media_id { get; set; }
            public string create_at { get; set; }
        }

        /// <summary>
        /// token类
        /// https://qyapi.weixin.qq.com/cgi-bin/gettoken?corpid=id&corpsecret=secrect
        /// </summary>
        public class CorpToken
        {
            public CorpToken()
            {
            }

            public string _access_token;
            public string _expires_in;
            public string _errcode;
            public string _errmsg;

            public string access_token
            {
                set { _access_token = value; }
                get { return _access_token; }
            }
            public string expires_in
            {
                set { _expires_in = value; }
                get { return _expires_in; }
            }

            public string errcode
            {
                set { _errcode = value; }
                get { return _errcode; }
            }

            public string errmsg
            {
                set { _errmsg = value; }
                get { return _errmsg; }
            }
        }
        //基础消息类
        public class BaseMessage
        {
            // 否 成员ID列表（消息接收者，多个接收者用‘|’分隔，最多支持1000个）。特殊情况：指定为@all，则向该企业应用的全部成员发送
            public string touser { get; set; }
            // 否 部门ID列表，多个接收者用‘|’分隔，最多支持100个。当touser为@all时忽略本参数
            public string toparty { get; set; }
            // 否 标签ID列表，多个接收者用‘|’分隔，最多支持100个。当touser为@all时忽略本参数
            public string totag { get; set; }
            // 是 消息类型 
            public string msgtype { get; set; }
            // 是 企业应用的id，整型。可在应用的设置页面查看
            public int agentid { get; set; }
            // 是 消息具体内容

        }

        //文本消息类
        public class Text
        {
            //是    消息内容，最长不超过2048个字节
            public string content { get; set; }

        }
        public class TextMessage : BaseMessage
        {
            //文本
            public Text text { get; set; }
            //否     表示是否是保密消息，0表示否，1表示是，默认0
            public int safe { get; set; }

        }

        //图片消息类
        public class Image
        {
            //媒体文件id，可以调用上传临时素材接口获取
            public string media_id { get; set; }
        }
        public class ImageMessage : BaseMessage
        {
            public Image image { get; set; }
            public int safe { get; set; }
        }

        //语音消息类
        public class Voice
        {
            //媒体文件id，可以调用上传临时素材接口获取
            public string media_id { get; set; }
        }
        public class VoiceMessage : BaseMessage
        {
            public Voice voice { get; set; }
            public int safe { get; set; }
        }


        //文件消息类
        public class Files
        {
            //媒体文件id，可以调用上传临时素材接口获取
            public string media_id { get; set; }
        }
        public class FilesMessage : BaseMessage
        {
            public Files file { get; set; }
            public int safe { get; set; }
        }

        //视频消息类
        public class Video
        {
            //媒体文件id，可以调用上传临时素材接口获取
            public string media_id { get; set; }
            //title 否   视频消息的标题，不超过128个字节，超过会自动截断
            public string title { get; set; }
            //description 否 视频消息的描述，不超过512个字节，超过会自动截断
            public string description { get; set; }
        }
        public class VideoMessage : BaseMessage
        {
            public Video video { get; set; }
            public int safe { get; set; }
        }


        //文本卡消息类
        public class TextCard
        {
            //媒体文件id，可以调用上传临时素材接口获取
            public string media_id { get; set; }
            //title 是   标题，不超过128个字节，超过会自动截断
            public string title { get; set; }
            //description 是 描述，不超过512个字节，超过会自动截断
            public string description { get; set; }
            //url 是 点击后跳转的链接。
            public string url { get; set; }
            //btntxt 否   按钮文字。 默认为“详情”， 不超过4个文字，超过自动截断。
            public string btntxt { get; set; }
        }
        public class TextCardMessage : BaseMessage
        {
            public TextCard textcard { get; set; }
            public int safe { get; set; }
        }

        //图文消息类
        public class News
        {
            public List<Articles> articles { get; set; }
            public class Articles
            {
                //媒体文件id，可以调用上传临时素材接口获取
                public string media_id { get; set; }
                //title 是   标题，不超过128个字节，超过会自动截断
                public string title { get; set; }
                //description 是 描述，不超过512个字节，超过会自动截断
                public string description { get; set; }
                //url 是 点击后跳转的链接。
                public string url { get; set; }
                //picurl 否   图文消息的图片链接，支持JPG、PNG格式，较好的效果为大图 640x320，小图80x80。
                public string picurl { get; set; }
                //btntxt 否   按钮文字。 默认为“详情”， 不超过4个文字，超过自动截断。
                public string btntxt { get; set; }
            }
        }
        public class NewsMessage : BaseMessage
        {
            public News news { get; set; }
            public int safe { get; set; }
        }

        //图文消息（mpnews）
        public class MpNews
        {
            public List<Articles> articles { get; set; }
            public class Articles
            {
                //title 是   标题，不超过128个字节，超过会自动截断
                public string title { get; set; }
                //thumb_media_id 是   图文消息缩略图的media_id, 可以通过素材管理接口获得。此处thumb_media_id即上传接口返回的media_id
                public string thumb_media_id { get; set; }
                //author  否 图文消息的作者，不超过64个字节
                public string author { get; set; }
                //content_source_url  否 图文消息点击“阅读原文”之后的页面链接
                public string content_source_url { get; set; }
                //content 是 图文消息的内容，支持html标签，不超过666 K个字节
                public string content { get; set; }
                //digest 否   图文消息的描述，不超过512个字节，超过会自动截断
                public string digest { get; set; }
            }
        }
        public class MpNewsMessage : BaseMessage
        {
            public MpNews mapnews { get; set; }
            public int safe { get; set; }
        }
    }
}
