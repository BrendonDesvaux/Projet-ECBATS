//using System;
//using System.Collections.Generic;
//using System.Net;
//using System.Web;
//using CoinGecko;
//namespace ECBATS.API
//{
//    public class CoinGeckoArbitrageCall
//    {
        
//        public static string setURL = " https://api.coingecko.com/api/v3/coins/markets?vs_currency=eur&order=market_cap_rank_desc&per_page=33&page=1&sparkline=false&price_change_percentage=24h%2C7d";
//        public static (string strprice, string strprc) makeArbitrageCall()//string Symbol) // return values in euro of current price & percent price  24h
//        {

//            string symbolFav = "btc"; //Symbol;
//        string strprice = "";
//            string strprc = "";
//            List<string> strList = new List<string>();
//            var client = new WebClient();
//            int y = 0;
//            string upDateURL;
//            for (int i = 0; i < 231; i += 33)// call SwapString for call 231 Crypto
//            {
//                y += 33;
//                string str = y.ToString();
//                SwapString(str);
//                upDateURL = SwapString(str);
//                var URL = new UriBuilder(upDateURL);

//                client.Headers.Add("Accepts", "application/json");

//                string[] shot = client.DownloadString(URL.ToString()).Split('{', ',', '[', '}', ']');

//                foreach (var sub in shot)
//                {
//                    if (sub.Length <= 1)
//                    {
//                        continue;
//                    }
//                    if (sub[1] == 'p' && sub.Length > 45 || sub[1] == 's' && sub[2] == 'y' || sub[1] == 'c' && sub[7] == 't') //ne pas effacer
//                    {
//                        strList.Add(sub);
//                    }
//                }
//            }
//            var x = strList.Count;
//            for (var z = 0; z < x; z++)
//            {
//                var length = 0;
//                for (int ii = 1; ii < strList[z].Length; ii++)
//                    if (strList[z][ii] == '"')
//                    {
//                        length = ii;
//                        break;
//                    }
//                strList[z] = strList[z].Remove(0, length + 2);

//                if (strList[z][0] == '"')
//                {

//                    strList[z] = strList[z].Remove(0, 1);

//                    strList[z] = strList[z].Remove(strList[z].Length - 1, 1);

//                }

//            }

//            for (var zz = 0; zz < x; zz++)
//            {
//                if (String.Compare(strList[zz], symbolFav) == 0)
//                {
//                    strprice = strList[zz + 1];
//                    strprc = strList[zz + 2];
//                    return (strprice, strprc);
//                }
//            }

//            return (strprice, strprc);
//        }
//        public static string SwapString(string str)
//        {
//            string sampleURL = setURL;

//            string find = "_page="; //consistant string to find the numbers you want to change 

//            var first_len = 0;
//            var second_len = 0;
//            var trig = 0;

//            for (int i = 0; i < sampleURL.Length; i++) // first loop for find location BEFORE number need to remplace
//            {
//                if (i == sampleURL.IndexOf("_page="))
//                {
//                    i += find.Length;
//                    first_len += i;
//                }
//            }
//            for (int i = 0; i < sampleURL.Length; i++) // first loop for find location AFTER number need to remplace
//            {
//                if (i == sampleURL.IndexOf("&page="))
//                {
//                    second_len += i;
//                }
//            }
//            var empty_space = second_len - first_len;

//            var ch_to_str = "";
//            string replacement;

//            for (int i = 0; i < sampleURL.Length; i++)// replace the string with str argument and return the new URL
//            {
//                if (i >= first_len && i < second_len)
//                {
//                    ch_to_str += sampleURL[i].ToString();
//                    trig++;

//                    if (trig == empty_space)
//                    {
//                        replacement = sampleURL.Replace(ch_to_str, str);
//                        //Console.WriteLine(replacement);
//                        return replacement;
//                    }
//                }
//            }
//            return sampleURL;
//        }
//    }
//}
