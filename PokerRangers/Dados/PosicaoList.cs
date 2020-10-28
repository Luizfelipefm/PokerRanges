using System;
using System.Collections.Generic;
using PokerRangers.Models;

namespace PokerRangers.Dados
{
    public class PosicaoList
    {
        public List<Posicao> GetPosicaos()
        {
            var posicaos = new List<Posicao>();
            posicaos.Add(new Posicao() { PosicaoId = 1, Descricao = Descricao.UTG });
            posicaos.Add(new Posicao() { PosicaoId = 2, Descricao = Descricao.UTG1 });
            posicaos.Add(new Posicao() { PosicaoId = 3, Descricao = Descricao.MP1 });
            posicaos.Add(new Posicao() { PosicaoId = 4, Descricao = Descricao.MP2 });
            posicaos.Add(new Posicao() { PosicaoId = 5, Descricao = Descricao.HJ });
            posicaos.Add(new Posicao() { PosicaoId = 6, Descricao = Descricao.CO });
            posicaos.Add(new Posicao() { PosicaoId = 7, Descricao = Descricao.BTN });
            posicaos.Add(new Posicao() { PosicaoId = 8, Descricao = Descricao.SB });
            posicaos.Add(new Posicao() { PosicaoId = 9, Descricao = Descricao.BB });

            return posicaos;
        }
    }
}
