using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Net.Http;
using System.Web.Script.Serialization;
using System.Diagnostics;
using System.Data.Entity.Validation;

namespace BitstampTransactionHistoryApp {
    class TransactionParser {
        private static readonly string API_URL = "https://www.bitstamp.net/api/v2/";
        private static readonly HttpClient client = new HttpClient();
        private string apiKey, apiSecret, customerId;

        public TransactionParser(string apiKey, string apiSecret, string customerId) {
            this.apiKey = apiKey;
            this.apiSecret = apiSecret;
            this.customerId = customerId;
        }

        //Parses new transactions
        public List<Transaction> ParsePrivateTransactions() {
            string response = PostJSONResponse("user_transactions");
            var serializer = new JavaScriptSerializer();
            var transactions = serializer.Deserialize<List<Transaction>>(response);
            return transactions;
        }

        //Prases new transactions, adds them to the database, and returns all available transactions
        public List<Transaction> UpdatedPrivateTransactions() {
            List<Transaction> parsed = ParsePrivateTransactions();

            Debug.Print("Parsed " + parsed.Count() + " transaction");
            //If it fails to update the database, only return newly parsed transactions
            List<Transaction> ret = parsed;
            using (var ctx = new TransactionHistoriesEntities()) {
                foreach (var transaction in parsed) {
                    if (!ctx.Transactions.Any(t => t.id == transaction.id)) {
                        ctx.Transactions.Add(transaction);
                    }
                }
                try {
                    ctx.SaveChanges();
                }
                catch (DbEntityValidationException e) {
                    foreach (var eve in e.EntityValidationErrors) {
                        foreach (var v in eve.ValidationErrors) {
                            Debug.Print(v.PropertyName + " - " + v.ErrorMessage);
                        }
                    }
                }
                ret = ctx.Transactions.ToList();
            }
            return ret;
        }

        //Parses new transactions
        public List<PublicTransaction> ParsePublicTransactionsFor(string pair, Dictionary<string, string> parameters) {
            string response = GetJSONResponse("transactions/" + pair, parameters);
            var serializer = new JavaScriptSerializer();
            var transactions = serializer.Deserialize<List<PublicTransaction>>(response);
            return transactions;
        }



        //Prases new transactions, adds them to the database, and returns all available transactions
        public List<PublicTransaction> UpdatedPublicTransactions(string pair, Dictionary<string, string> parameters) {
            List<PublicTransaction> parsed = ParsePublicTransactionsFor(pair, parameters);
            //If it fails to update the database, only return newly parsed transactions
            List<PublicTransaction> ret = parsed;
            using (var ctx = new TransactionHistoriesEntities()) {
                foreach (var transaction in parsed) {
                    if (!ctx.PublicTransactions.Any(t => t.tid == transaction.tid)) {
                        ctx.PublicTransactions.Add(transaction);
                    }
                }
                try {
                    ctx.SaveChanges();
                }
                catch (DbEntityValidationException e) {
                    foreach (var eve in e.EntityValidationErrors) {
                        foreach (var v in eve.ValidationErrors) {
                            Debug.Print(v.PropertyName + " - " + v.ErrorMessage);
                        }
                    }
                }
                ret = ctx.PublicTransactions.ToList();
            }
            return ret;
        }



        private string GetJSONResponse(string function, Dictionary<string, string> parameters) {
            string url = API_URL + function + "/?" + DictionaryToGetParams(parameters);
            Debug.Print("GET url: " + url);
            var response = client.GetAsync(url);
            return response.Result.Content.ReadAsStringAsync().Result;
        }

        private string DictionaryToGetParams(Dictionary<string, string> parameters) {
            string ret = "";
            int index = 0;
            foreach (var p in parameters) {
                ret += (p.Key + "=" + p.Value);
                if (++index < parameters.Count) {
                    ret += "&";
                }
            }
            return ret;
        }

        //Overload function to make a call without any additional POST parameters
        private string PostJSONResponse(string function) {
            return PostJSONResponse(function, new Dictionary<string, string>());
        }

        private string PostJSONResponse(string function, Dictionary<string, string> parameters) {
            //provides an option to parse public data
            if (apiKey != null) {
                //multiplying by 100.000 in case the API key is used on another computer with milis timestamp
                string nonce = (DateTimeOffset.Now.ToUnixTimeSeconds() * 100000).ToString();
                string signature = CreateSignature(nonce);
                //Add required auth parameters
                parameters.Add("key", apiKey);
                parameters.Add("signature", signature);
                parameters.Add("nonce", nonce);
            }
            var encoded = new FormUrlEncodedContent(parameters);
            var response = client.PostAsync(API_URL + function + "/", encoded);
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
