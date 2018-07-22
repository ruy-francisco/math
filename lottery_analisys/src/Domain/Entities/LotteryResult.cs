using System;
using Domain.Enum;

namespace Domain.Entities
{
    public class LotteryResult
    {
        public LotteryType LotteryType { get; set; }
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public string Sorteio { get; set; }
        public DateTime Proxima_Data { get; set; }
    }
}