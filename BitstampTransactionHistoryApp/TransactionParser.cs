using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Net.Http;
using System.Web.Script.Serialization;

namespace BitstampTransactionHistoryApp {
    class TransactionParser {
        private static readonly string URL = "https://www.bitstamp.net/api/v2/user_transactions/";
        private static readonly HttpClient client = new HttpClient();
        private string apiKey, apiSecret, customerId;

        public TransactionParser(string apiKey, string apiSecret, string customerId) {
            this.apiKey = apiKey;
            this.apiSecret = apiSecret;
            this.customerId = customerId;
        }

        public Transaction[] ParseTransactions() {
            string response = ParseJSONResponse();
            var serializer = new JavaScriptSerializer();
            var obj = (Dictionary<string, object>) serializer.DeserializeObject(response);


        }

        private string ParseJSONResponse() {
            string nonce = DateTimeOffset.Now.ToUnixTimeSeconds().ToString();
            string signature = CreateSignature(nonce);
            var parameters = new Dictionary<string, string> {
                {"key", apiKey},
                {"signature", signature},
                {"nonce", nonce}
            };
            var encoded = new FormUrlEncodedContent(parameters);
            var response = client.PostAsync(URL, encoded);
            return response.Result.Content.ReadAsStringAsync().Result;
        }

        private string CreateSignature(string nonce) {
            var msg = string.Format("{0}{1}{2}", nonce, customerId, apiKey);
            return ByteArrayToString(SignHMACSHA256(apiSecret, StringToByteArray(msg))).ToUpper();
        }

        private static byte[] SignHMACSHA256(string key, byte[] data) {
            var hashMaker = new HMACSHA256(Encoding.ASCII.GetBytes(key));
            return hashMaker.ComputeHash(data);
        }

        private static byte[] StringToByteArray(string str) {
            return Encoding.ASCII.GetBytes(str);
        }

        private static string ByteArrayToString(byte[] hash) {
            return BitConverter.ToString(hash).Replace("-", "").ToLower();
        }

    }
}
