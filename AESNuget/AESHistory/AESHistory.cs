using Newtonsoft.Json.Linq;
using System.Net;

namespace FortniteAES.AESHistory
{
    public class AESHistory
    {
        const string aesurl = @"https://benbot.app/api/v1/aes?version=";
        /// <summary>
        ///     Returns ALL keys with some extra json data. Outdated, GetData() is better to use.
        /// </summary>
        public static string GetOldKeys(string version)
        {
            var wc = new WebClient();
            var keys = wc.DownloadString(aesurl + version).Split(new[] { '\r', '\n' })[0].Replace(",", "\n");
            return keys;
        }

        /// <summary>
        ///     Returns the raw data from the AES page of benbot.app for the specified Fortnite version with no editing done, ready to be parsed.
        /// </summary>
        public static string GetOldData(string version)
        {
            string keys = "";
            var wc = new WebClient();
            keys = wc.DownloadString(aesurl + version);

            return keys;
        }

        /// <summary>
        ///     Returns the main AES key of a specified Fortnite version.
        /// </summary>
        public static string GetOldMainKey(string version)
        {
            var wc = new WebClient();
            var keys = wc.DownloadString(aesurl + version);

            var jo = JObject.Parse(keys);
            var key = jo["mainKey"].ToString();

            return key;
        }

        /// <summary>
        ///     Returns the AES key of a specified pak file of a specified Fortnite version.
        /// </summary>
        public static string GetOldKey(string version, string pakFile)
        {
            var wc = new WebClient();
            var keys = wc.DownloadString(aesurl + version);

            var jo = JObject.Parse(keys);
            var key = jo["dynamicKeys"][pakFile].ToString();

            return key;
        }
    }
}
