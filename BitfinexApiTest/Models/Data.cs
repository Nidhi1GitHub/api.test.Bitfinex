using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitfinexApiTest.Models
{
    public class Data
    {
        public class ContinentsModel
        {
            public List<ContinentsData> data { get; set; }
        }

        public class ContinentsSingle
        {
            public ContinentsData data { get; set; }
        }

        public class ContinentsData
        {
            public int OPERATIVE { get; set; }
        }

        public class TickerData
        {
            public float FRR { get; set; }
            public float BID { get; set; }
            public int BID_PERIOD { get; set; }
            public float BID_SIZE { get; set; }
            public float ASK { get; set; }
            public int ASK_PERIOD { get; set; }
            public float ASK_SIZE { get; set; }
            public float DAILY_CHANGE { get; set; }
            public float DAILY_CHANGE_PERC { get; set; }
            public float LAST_PRICE { get; set; }
            public float VOLUME { get; set; }
            public float HIGH { get; set; }
            public float LOW { get; set; }
        }

        public class TradeData
        {
            public int MTS { get; set; }
            public float AMOUNT { get; set; }
            public float PRICE { get; set; }
            public float RATE { get; set; }
            public int PERIOD { get; set; }
        }
    }
}