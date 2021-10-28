using System;
using System.Collections.Generic;
using System.Net;
using System.Web;
using CoinGecko;


namespace GeckoAPICall
{ 
    public class GeckoCALL
    {
        /// <summary>
        /// Calls CoinGeckoAPI via URL
        /// </summary>
        public static string setURL = " https://api.coingecko.com/api/v3/coins/markets?vs_currency=eur&order=market_cap_rank_desc&per_pa5ge=33&page=1&sparkline=false&price_change_percentage=24h%2C7d";
        /// <summary>
        /// Calls 231 crypto instead of 33 and sort without annoying char.
        /// </summary>
        /// <returns>231 call</returns>
        public static List<string> makeAPICall()
        {
            List<string> strList = new List<string>();
            var client = new WebClient();
            int y = 0;
            var upDateURL = "";
            for (int i = 0; i < 231; i += 33)// call SwapString for call 231 Crypto
            {
                y += 33;
                string str = y.ToString();
                SwapString(str);
                upDateURL = SwapString(str);


                var URL = new UriBuilder(upDateURL);

                client.Headers.Add("Accepts", "application/json");

                Console.Write(client.DownloadString(URL.ToString()));

                string[] shot = client.DownloadString(URL.ToString()).Split('{', ',', '[');

                foreach (var sub in shot)
                {
                    if (sub.Length < 1)
                    {

                        continue;
                    }
                    if (sub[1] == 'i' && sub[2] == 'm' || sub[1] == 'p' && sub.Length > 45 || sub[1] == 'i' && sub[2] == 'd' || sub[1] == 'n' || sub[1] == 's' && sub[2] == 'y' || sub[1] == 'c' && sub[7] == 't')
                    {
                        strList.Add(sub);
                    }

                }
            }
            var x = strList.Count;
            for (var i = 0; i < x; i++)
            {
                var length = 0;
                for (int ii = 1; ii < strList[i].Length; ii++)
                    if (strList[i][ii] == '"')
                    {
                        length = ii;
                        break;
                    }

                strList[i] = strList[i].Remove(0, length + 2);
                if (strList[i][0] == '"')
                {
                    strList[i] = strList[i].Remove(0, 1);
                    strList[i] = strList[i].Remove(strList[i].Length - 1, 1);
                }

                Console.WriteLine(strList[i]);
            }


            return (strList);

        }
        /// <summary>
        /// Modification de l'URL
        /// </summary>
        /// <param name="str"></param>
        /// <returns>Desired URL</returns>
        public static string SwapString(string str)
        {
            string sampleURL = setURL; //"https://api.coingecko.com/api/v3/coins/markets?vs_currency=eur&order=market_cap_rank_desc&per_page=33&page=1&sparkline=false&price_change_percentage=24h%2C7d"; // url want to change
            //Console.WriteLine(sampleURL);

            string find = "_page="; //consistant string to find the numbers you want to change 




            var first_len = 0;
            var second_len = 0;
            var trig = 0;



            for (int i = 0; i < sampleURL.Length; i++) // first loop for find location BEFORE number need to remplace
            {
                if (i == sampleURL.IndexOf("_page="))
                {
                    i += find.Length;

                    first_len += i;

                }


            }
            for (int i = 0; i < sampleURL.Length; i++) // first loop for find location AFTER number need to remplace
            {
                if (i == sampleURL.IndexOf("&page="))
                {


                    second_len += i;

                }

            }
            var empty_space = second_len - first_len;

            var ch_to_str = "";
            string replacement;




            for (int i = 0; i < sampleURL.Length; i++)// replace the string with str argument and return the new URL
            {

                if (i >= first_len && i < second_len)
                {
                    ch_to_str += sampleURL[i].ToString();
                    trig++;




                    if (trig == empty_space)
                    {
                        replacement = sampleURL.Replace(ch_to_str, str);
                        //Console.WriteLine(replacement);
                        return replacement;

                    }

                }

            }

            return sampleURL;
        }


    }
}