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
                Descricao = "Raise/Shove",
                PosicaoId = (int)Descricao.UTG,
                RangeInicio = 20,
                RangeFim = 40,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 2,
                Descricao = "Raise/Shove",
                PosicaoId = (int)Descricao.UTG1,
                RangeInicio = 20,
                RangeFim = 40,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 3,
                Descricao = "Raise/Call",
                PosicaoId = (int)Descricao.UTG,
                RangeInicio = 20,
                RangeFim = 40,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 4,
                Descricao = "Raise/Call",
                PosicaoId = (int)Descricao.UTG1,
                RangeInicio = 20,
                RangeFim = 40,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 5,
                Descricao = "Raise/Fold",
                PosicaoId = (int)Descricao.UTG,
                RangeInicio = 20,
                RangeFim = 40,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 6,
                Descricao = "Raise/Fold",
                PosicaoId = (int)Descricao.UTG1,
                RangeInicio = 20,
                RangeFim = 40,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 7,
                Descricao = "Raise/Shove",
                PosicaoId = (int)Descricao.MP1,
                RangeInicio = 20,
                RangeFim = 40,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 8,
                Descricao = "Raise/Call",
                PosicaoId = (int)Descricao.MP1,
                RangeInicio = 20,
                RangeFim = 40,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 9,
                Descricao = "Raise/Fold",
                PosicaoId = (int)Descricao.MP1,
                RangeInicio = 20,
                RangeFim = 40,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 10,
                Descricao = "Raise/Shove",
                PosicaoId = (int)Descricao.MP2,
                RangeInicio = 20,
                RangeFim = 40,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 11,
                Descricao = "Raise/Call",
                PosicaoId = (int)Descricao.MP2,
                RangeInicio = 20,
                RangeFim = 40,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 12,
                Descricao = "Raise/Fold",
                PosicaoId = (int)Descricao.MP2,
                RangeInicio = 20,
                RangeFim = 40,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 13,
                Descricao = "Raise/Shove",
                PosicaoId = (int)Descricao.HJ,
                RangeInicio = 20,
                RangeFim = 40,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 14,
                Descricao = "Raise/Call",
                PosicaoId = (int)Descricao.HJ,
                RangeInicio = 20,
                RangeFim = 40,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 15,
                Descricao = "Raise/Fold",
                PosicaoId = (int)Descricao.HJ,
                RangeInicio = 20,
                RangeFim = 40,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 16,
                Descricao = "Raise/Fold ou Call Contra Jogadores Muito Agressivos",
                PosicaoId = (int)Descricao.HJ,
                RangeInicio = 20,
                RangeFim = 40,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 17,
                Descricao = "Raise/Shove",
                PosicaoId = (int)Descricao.CO,
                RangeInicio = 20,
                RangeFim = 40,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 18,
                Descricao = "Raise/Call",
                PosicaoId = (int)Descricao.CO,
                RangeInicio = 20,
                RangeFim = 40,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 19,
                Descricao = "Raise/Fold",
                PosicaoId = (int)Descricao.CO,
                RangeInicio = 20,
                RangeFim = 40,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 20,
                Descricao = "Raise/Shove",
                PosicaoId = (int)Descricao.BTN,
                RangeInicio = 20,
                RangeFim = 40,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 21,
                Descricao = "Raise/Call ou Shove Dependendo do Oponente",
                PosicaoId = (int)Descricao.BTN,
                RangeInicio = 20,
                RangeFim = 40,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 22,
                Descricao = "Raise/Call",
                PosicaoId = (int)Descricao.BTN,
                RangeInicio = 20,
                RangeFim = 40,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 23,
                Descricao = "Raise/Fold",
                PosicaoId = (int)Descricao.BTN,
                RangeInicio = 20,
                RangeFim = 40,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 24,
                Descricao = "Raise",
                PosicaoId = (int)Descricao.UTG,
                RangeInicio = 10,
                RangeFim = 20,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 25,
                Descricao = "Raise",
                PosicaoId = (int)Descricao.UTG1,
                RangeInicio = 10,
                RangeFim = 20,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 26,
                Descricao = "Shove",
                PosicaoId = (int)Descricao.UTG,
                RangeInicio = 10,
                RangeFim = 12,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 27,
                Descricao = "Shove",
                PosicaoId = (int)Descricao.UTG1,
                RangeInicio = 10,
                RangeFim = 12,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 28,
                Descricao = "Raise",
                PosicaoId = (int)Descricao.UTG,
                RangeInicio = 13,
                RangeFim = 20,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 29,
                Descricao = "Raise",
                PosicaoId = (int)Descricao.UTG1,
                RangeInicio = 13,
                RangeFim = 20,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 30,
                Descricao = "Shove",
                PosicaoId = (int)Descricao.UTG,
                RangeInicio = 10,
                RangeFim = 15,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 31,
                Descricao = "Shove",
                PosicaoId = (int)Descricao.UTG1,
                RangeInicio = 10,
                RangeFim = 15,
            });

            ranges.Add(new Models.Range()
            {
                RangeId = 32,
                Descricao = "Raise",
                PosicaoId = (int)Descricao.MP1,
                RangeInicio = 10,
                RangeFim = 20,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 33,
                Descricao = "Shove",
                PosicaoId = (int)Descricao.MP1,
                RangeInicio = 10,
                RangeFim = 12,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 34,
                Descricao = "Raise",
                PosicaoId = (int)Descricao.MP1,
                RangeInicio = 12,
                RangeFim = 20,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 35,
                Descricao = "Shove",
                PosicaoId = (int)Descricao.MP1,
                RangeInicio = 10,
                RangeFim = 15,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 36,
                Descricao = "Raise",
                PosicaoId = (int)Descricao.MP1,
                RangeInicio = 15,
                RangeFim = 20,
            });

            ranges.Add(new Models.Range()
            {
                RangeId = 37,
                Descricao = "Raise",
                PosicaoId = (int)Descricao.MP2,
                RangeInicio = 10,
                RangeFim = 20,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 38,
                Descricao = "Shove",
                PosicaoId = (int)Descricao.MP2,
                RangeInicio = 10,
                RangeFim = 12,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 39,
                Descricao = "Raise",
                PosicaoId = (int)Descricao.MP2,
                RangeInicio = 12,
                RangeFim = 20,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 40,
                Descricao = "Shove",
                PosicaoId = (int)Descricao.MP2,
                RangeInicio = 10,
                RangeFim = 15,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 41,
                Descricao = "Raise",
                PosicaoId = (int)Descricao.MP2,
                RangeInicio = 15,
                RangeFim = 20,
            });

            ranges.Add(new Models.Range()
            {
                RangeId = 42,
                Descricao = "Shove",
                PosicaoId = (int)Descricao.HJ,
                RangeInicio = 10,
                RangeFim = 20,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 43,
                Descricao = "Raise",
                PosicaoId = (int)Descricao.HJ,
                RangeInicio = 10,
                RangeFim = 20,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 44,
                Descricao = "Shove",
                PosicaoId = (int)Descricao.HJ,
                RangeInicio = 10,
                RangeFim = 12,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 45,
                Descricao = "Raise",
                PosicaoId = (int)Descricao.HJ,
                RangeInicio = 12,
                RangeFim = 20,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 46,
                Descricao = "Shove",
                PosicaoId = (int)Descricao.HJ,
                RangeInicio = 10,
                RangeFim = 25,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 47,
                Descricao = "Raise",
                PosicaoId = (int)Descricao.HJ,
                RangeInicio = 15,
                RangeFim = 20,
            });

            ranges.Add(new Models.Range()
            {
                RangeId = 48,
                Descricao = "Shove",
                PosicaoId = (int)Descricao.CO,
                RangeInicio = 10,
                RangeFim = 20,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 49,
                Descricao = "Raise",
                PosicaoId = (int)Descricao.CO,
                RangeInicio = 10,
                RangeFim = 20,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 50,
                Descricao = "Shove",
                PosicaoId = (int)Descricao.CO,
                RangeInicio = 10,
                RangeFim = 12,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 51,
                Descricao = "Raise",
                PosicaoId = (int)Descricao.CO,
                RangeInicio = 12,
                RangeFim = 20,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 52,
                Descricao = "Shove",
                PosicaoId = (int)Descricao.CO,
                RangeInicio = 10,
                RangeFim = 15,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 53,
                Descricao = "Raise",
                PosicaoId = (int)Descricao.CO,
                RangeInicio = 15,
                RangeFim = 20,
            });

            ranges.Add(new Models.Range()
            {
                RangeId = 54,
                Descricao = "Shove",
                PosicaoId = (int)Descricao.BTN,
                RangeInicio = 10,
                RangeFim = 20,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 55,
                Descricao = "Raise",
                PosicaoId = (int)Descricao.BTN,
                RangeInicio = 10,
                RangeFim = 20,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 56,
                Descricao = "Shove",
                PosicaoId = (int)Descricao.BTN,
                RangeInicio = 10,
                RangeFim = 12,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 57,
                Descricao = "Raise",
                PosicaoId = (int)Descricao.BTN,
                RangeInicio = 12,
                RangeFim = 20,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 58,
                Descricao = "Shove",
                PosicaoId = (int)Descricao.BTN,
                RangeInicio = 10,
                RangeFim = 15,
            });
            ranges.Add(new Models.Range()
            {
                RangeId = 59,
                Descricao = "Raise",
                PosicaoId = (int)Descricao.BTN,
                RangeInicio = 15,
                RangeFim = 20,
            });

            return ranges;
        }
    }
}
