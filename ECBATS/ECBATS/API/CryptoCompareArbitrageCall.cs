using System;
using System.Collections.Generic;
using System.Net;
using System.Web;
namespace ECBATS.API
{
    public class CryptoCompareArbitrageCall
    {
        public class CryptoCompareAPIcall
        {
            private static string API_KEY = "c98174b698d9f51471a2d4c81a8fd315287400ff7327d5d44c78b4e728a0c215";
            public static string makeAPICall(string Symbol) //call API from CryptoCompare feature
            {
                List<string> strList = new List<string>();




                string fav = Symbol; //.ToUpper




                var URL = new UriBuilder("https://min-api.cryptocompare.com/data/price?fsym=" + fav + "&tsyms=EUR");

                var client = new WebClient();

                client.Headers.Add("X-CMC_PRO_API_KEY", API_KEY);
                client.Headers.Add("Accepts", "application/json");


                string[] shot = client.DownloadString(URL.ToString()).Split('{', ',', '[', '}', ']');
                foreach (var sub in shot)
                {

                    if (sub.Length <= 1)
                    {
                        continue;
                    }
                    else
                    {
                        strList.Add(sub);
                    }
                }

                var x = strList.Count;

                for (var i = 0; i < x; i++)
                {
                    var length = 0;
                    for (int ii = 1; ii < strList[i].Length; ii++)
                    {
                        if (strList[i][ii] == '"')
                        {
                            length = ii;
                            break;
                        }
                    }
                    strList[i] = strList[i].Remove(0, length + 2);
                    if (strList[i][0] == '"')
                    {
                        strList[i] = strList[i].Remove(0, 1);
                        strList[i] = strList[i].Remove(strList[i].Length - 1, 1);
                    }


                }

                return strList[0];

            }
        }
    }
}
