using System;
using System.Collections.Generic;
using PokerRangers.Models;

namespace PokerRangers.Dados
{
    public class RangeComboList
    {
        public List<RangeCombo> GetRangeCombos()
        {
            var RangeCombo = new List<RangeCombo>();
            RangeCombo.Add(new RangeCombo() { RangeId = 1, ComboId = 1});
            RangeCombo.Add(new RangeCombo() { RangeId = 1, ComboId = 15});
            RangeCombo.Add(new RangeCombo() { RangeId = 1, ComboId = 29});

            return RangeCombo;
        }
    }
}
