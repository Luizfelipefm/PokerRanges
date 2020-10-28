using System;
using System.Collections.Generic;
using PokerRangers.Models;

namespace PokerRangers.Dados
{
    public class RangeList
    {
        public List<Models.Range> GetRanges()
        {
            var ranges = new List<Models.Range>();
            ranges.Add(new Models.Range()
            {
                RangeId = 1,
                Descricao = "Raise",
                PosicaoId = 1,
                RangeInicio = 20,
                RangeFim = 40
            });

            return ranges;
        }
    }
}
