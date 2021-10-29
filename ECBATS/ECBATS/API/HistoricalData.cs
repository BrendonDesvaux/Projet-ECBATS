/*using System;
namespace ECBATS.API
{
    public class HistoricalData
    {
        
        /// <summary>
        /// This code is to have price information of any currencies 30days prior the date of launch of the code with a hourly interval and without unwanted characters
        /// </summary>
        /// <returns>List of price without any characters other than the price itself</returns>
        public static List<double> makehistoricalCallhourly()
        {
            List<string> strList = new List<string>();
            List<double> dblList = new List<double>();
            var client = new WebClient();

            var URL = new UriBuilder("https://api.coingecko.com/api/v3/coins/bitcoin/market_chart?vs_currency=eur&days=30&interval=hourly");

            client.Headers.Add("Accepts", "application/json");


            string[] shot = client.DownloadString(URL.ToString()).Split('{', ',', '[', '}', ']');// this is used to remove unwanted characters

            foreach (var sub in shot)
            {

                if (sub.Length <= 1)    //this is to remove empty strings from the list
                {
                    continue;
                }
                else
                {
                    strList.Add(sub);
                }

            }
            strList.Remove(strList[0]); // this is to remove the first string which is useless for us
            var x = strList.Count;
            strList.RemoveRange(24 * 60, x - 24 * 60);// this is to remove unwanted data
            for (var i = 0; i < 24 * 30; i++)
            {
                strList.Remove(strList[i]); //this is to remove unwanted data
            }
            x = strList.Count;
            for (var i = 0; i < x; i++)
            {
                dblList.Add(Double.Parse(strList[i]));
                Console.WriteLine(dblList[i]);
            }
            return dblList;
        }
        }
    }
}*/
