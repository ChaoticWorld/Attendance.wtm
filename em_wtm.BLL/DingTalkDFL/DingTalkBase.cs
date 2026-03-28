using DingTalk.Api;
using DingTalk.Api.Request;
using DingTalk.Api.Response;

namespace DingTalkDFL
{
    public class DingTalkBase
    {
        #region Token
        private static string _token = string.Empty;
        private static DateTime tokenTime = DateTime.MinValue;
        protected static string token
        {
            get
            {
                var diff = DateTime.Now >= tokenTime.AddSeconds(7200);
                if (diff)
                    getToken();
                return _token;
            }
        }
        private static void getToken()
        {
            /*
             * CorpId：ding4c3d8c87a30fc2ba35c2f4657eb6378f
             * SSOsecret：LmRcvK4slAnZpWepUvNkdpE74gYEhGZg8GSVRVaAyv5hLzVFjd1D-Yhgi8i9f02c
             * AppKey：
             * dingolaz4gqcrbdponui
             * AppSecret：
             * --gIaMyXIQM23OFOxmItZUvhgDIy-f_VGtAFxa7O0KDwNaPT2NrfdGHb-R2O_TVE
             */

            IDingTalkClient client = new DefaultDingTalkClient("https://oapi.dingtalk.com/gettoken");
            OapiGettokenRequest reqToken = new OapiGettokenRequest()
            {
                Appkey = "dingolaz4gqcrbdponui",
                Appsecret = "--gIaMyXIQM23OFOxmItZUvhgDIy-f_VGtAFxa7O0KDwNaPT2NrfdGHb-R2O_TVE"
            };
            reqToken.SetHttpMethod("GET");
            OapiGettokenResponse resToken = client.Execute(reqToken);
            _token = resToken.AccessToken;
            tokenTime = DateTime.Now;
        }
        #endregion Token
        public DateTime GetDateTime(string dingTalkDateTime)
        {
            long tick = long.Parse(dingTalkDateTime) * 10000 + 621356256000000000;
            return new DateTime(tick);
        }
    }
    public class DingTalkLoginInfo : DingTalkBase
    {
        #region LoginUserList
        public static List<OapiUserGetResponse> LoginUserList { get; private set; } = new List<OapiUserGetResponse>();
        #endregion LoginUserList
        private static string getUserid(string authCode)
        {
            IDingTalkClient client = new DefaultDingTalkClient("https://oapi.dingtalk.com/user/getuserinfo");
            OapiUserGetuserinfoRequest request = new OapiUserGetuserinfoRequest()
            {
                Code = authCode
            };
            request.SetHttpMethod("GET");
            OapiUserGetuserinfoResponse response = client.Execute(request, token);
            return response.Userid;
        }
        public static OapiUserGetResponse getLoginUser(string authCode)
        {
            IDingTalkClient client = new DefaultDingTalkClient("https://oapi.dingtalk.com/user/get");
            OapiUserGetRequest request = new OapiUserGetRequest();
            request.Userid = getUserid(authCode);
            request.SetHttpMethod("GET");
            OapiUserGetResponse response = client.Execute(request, token);
            if (response.Errcode == 0)
            {
                if (LoginUserList.Exists(e => e.Userid == response.Userid))
                    LoginUserList.RemoveAll(r => r.Userid == response.Userid);
                LoginUserList.Add(response);
            }
            return response;
        }
    }
}
