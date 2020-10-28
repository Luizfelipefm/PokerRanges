using System;

namespace PokerRangers.Models
{
    public class Posicao
    {
        public int PosicaoId { get; set; }
        public Descricao Descricao { get; set; }
    }
    public enum Descricao
    {
        UTG = 1,
        UTG1 = 2,
        MP1 = 3,
        MP2 = 4,
        HJ = 5,
        CO = 6,
        BTN = 7,
        SB = 8,
        BB = 9
    }
}