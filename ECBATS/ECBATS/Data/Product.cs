using System;
namespace ECBATS.Data
{
/// <summary>
/// List made for collecting datas in a crypto
/// </summary>
    public class CryptoSaving
    {
        public long ID { get; set; }
        public string CryptoName { get; set; }
        public string Symbol { get; set; }
        public string Price { get; set; }
        public string Percent24h { get; set; }
        public string Percent7j { get; set; }

        
    }
}
