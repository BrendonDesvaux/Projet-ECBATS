//using System;
//using System.Collections.Generic;
//using System.Net;
//using System.Web;
//namespace ECBATS.API
//{
//    public class ArbitrageCall
//    {
//        public static (List<List<double>>, List<List<string>>) ArbitrageCalculus()
//        {
//            string strpercentage = CoinGeckoArbitrageCall.makeArbitrageCall().strprc;
//            string strprice = CoinGeckoArbitrageCall.makeArbitrageCall().strprice;

//            List<string> CoinGeckoList = new List<string> { strprice };
//            List<string> CryptoCompareList = new List<string> { CryptoCompareArbitrageCall.CryptoCompareAPIcall.makeAPICall() };

//            List<List<string>> arbitrage = new List<List<string>> { CryptoCompareList, CoinGeckoList };

//            double CryptoCompare = double.Parse(CryptoCompareList[0]);
//            double ArbitragePercent = double.Parse(strpercentage);

//            double CoinGecko;

//            try
//            {
//                CoinGecko = double.Parse("55555");
//            }
//            catch (FormatException) { }

//            CoinGecko = double.Parse(CoinGeckoList[0]);

//            if (CryptoCompare >= CoinGecko)
//            {
//                arbitrage.Remove(CryptoCompareList);
//                arbitrage.Remove(CoinGeckoList);
//                arbitrage = new List<List<string>> { CoinGeckoList, CryptoCompareList };
//            }
//            CryptoCompare = CryptoCompare + CryptoCompare * ArbitragePercent / 100;
//            CoinGecko = CoinGecko + CoinGecko * ArbitragePercent / 100;

//            List<double> CryptoCompareList24h = new List<double> { CryptoCompare };
//            List<double> CoinGeckoList24h = new List<double> { CoinGecko };

//            List<List<double>> arbitrage24h = new List<List<double>> { CryptoCompareList24h, CoinGeckoList24h };

//            if (CryptoCompare >= CoinGecko)
//            {
//                arbitrage24h.Remove(CryptoCompareList24h);
//                arbitrage24h.Remove(CoinGeckoList24h);
//                arbitrage24h = new List<List<double>> { CoinGeckoList24h, CryptoCompareList24h };
//            }
//            return (arbitrage24h, arbitrage);
//        }
//    }
//}

