using System;
using System.Collections.Generic;

namespace PokerRangers.Models
{
    public class Principal
    {
        public Range Range { get; set; }
        public Posicao Descricao { get; set; }
        public List<RangeCombo> RangeCombos { get; set; }
    }
}
