using System;
using TranslateGame.Desktop.Enums;

namespace TranslateGame.Desktop.Models
{
    public class Word
    {
        public string WordName { get; set; } = String.Empty;

        public string WordValue { get; set; } = String.Empty;

        public TestLevel Level { get; set; }
    }
}
