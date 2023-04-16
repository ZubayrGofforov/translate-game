using System;
using TranslateGame.Desktop.Enums;

namespace TranslateGame.Desktop.Models
{
    public class Result
    {
        public Guid UserId { get; set; }

        public TestLevel Level { get; set; }

        public int Count { get; set; }

        public double Percentage { get; set; }
    }
}
