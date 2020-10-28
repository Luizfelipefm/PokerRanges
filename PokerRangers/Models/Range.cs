using System;
using System.Collections.Generic;

namespace PokerRangers.Models
{
    public class Range
    {
        public int RangeId { get; set; }
        public string Descricao { get; set; }
        public int PosicaoId { get; set; }
        public int RangeInicio { get; set; }
        public int RangeFim { get; set; }

        public Posicao Posicao { get; set; }
        public List<RangeCombo> RangeCombos { get; set; }
    }
}
