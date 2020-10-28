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
           
           
            return ranges;
        }
    }
}
