using Newtonsoft.Json.Linq;
using System.Net;

namespace FortniteAES.Grabber
{
    public class AESGrabber
    {
        const string aesurl = @"https://benbot.app/api/v1/aes";
        /// <summary>
        ///     Returns ALL keys with some extra json data. Outdated, GetData() is better to use.
        /// </summary>
        public static string GetKeys()
        {
            var wc = new WebClient();
            var keys = wc.DownloadString(aesurl).Split(new[] { '\r', '\n' })[0].Replace(",", "\n");
            return keys;
        }

        /// <summary>
        ///     Returns the raw data from https://benbot.app/api/v1/aes with no editing done, ready to be parsed.
        /// </summary>
        public static string GetData()
        {
            string keys = "";
            var wc = new WebClient();
            keys = wc.DownloadString(aesurl);

            return keys;
        }

        /// <summary>
        ///     Returns the main AES key.
        /// </summary>
        public static string GetMainKey()
        {
            var wc = new WebClient();
            var keys = wc.DownloadString(aesurl);

            var jo = JObject.Parse(keys);
            var key = jo["mainKey"].ToString();

            return key;
        }

        /// <summary>
        ///     Returns the AES key of a specified pak file.
        /// </summary>
        public static string GetKey(string pakFile)
        {
            var wc = new WebClient();
            var keys = wc.DownloadString(aesurl);

            var jo = JObject.Parse(keys);
            var key = jo["dynamicKeys"][pakFile].ToString();

            return key;
        }
    }
}
