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
            //UTG 
            RangeCombo.Add(new RangeCombo() { RangeId = 1, ComboId = "AA" });
            RangeCombo.Add(new RangeCombo() { RangeId = 1, ComboId = "AKo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 1, ComboId = "AKs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 1, ComboId = "AQs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 1, ComboId = "KK" });
            RangeCombo.Add(new RangeCombo() { RangeId = 1, ComboId = "QQ" });
            RangeCombo.Add(new RangeCombo() { RangeId = 1, ComboId = "JJ" });
            RangeCombo.Add(new RangeCombo() { RangeId = 1, ComboId = "TT" });

            RangeCombo.Add(new RangeCombo() { RangeId = 3, ComboId = "AJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 3, ComboId = "ATs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 3, ComboId = "KQs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 3, ComboId = "KJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 3, ComboId = "KTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 3, ComboId = "QJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 3, ComboId = "QTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 3, ComboId = "JTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 3, ComboId = "T9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 3, ComboId = "99" });
            RangeCombo.Add(new RangeCombo() { RangeId = 3, ComboId = "88" });

            RangeCombo.Add(new RangeCombo() { RangeId = 5, ComboId = "A9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 5, ComboId = "A8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 5, ComboId = "A7s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 5, ComboId = "A6s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 5, ComboId = "A5s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 5, ComboId = "A4s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 5, ComboId = "A3s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 5, ComboId = "A2s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 5, ComboId = "AJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 5, ComboId = "ATo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 5, ComboId = "K9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 5, ComboId = "K8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 5, ComboId = "KQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 5, ComboId = "KJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 5, ComboId = "Q9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 5, ComboId = "J9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 5, ComboId = "77" });
            RangeCombo.Add(new RangeCombo() { RangeId = 5, ComboId = "66" });

            // UTG+1
            RangeCombo.Add(new RangeCombo() { RangeId = 2, ComboId = "AA" });
            RangeCombo.Add(new RangeCombo() { RangeId = 2, ComboId = "AKo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 2, ComboId = "AKs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 2, ComboId = "AQs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 2, ComboId = "KK" });
            RangeCombo.Add(new RangeCombo() { RangeId = 2, ComboId = "QQ" });
            RangeCombo.Add(new RangeCombo() { RangeId = 2, ComboId = "JJ" });
            RangeCombo.Add(new RangeCombo() { RangeId = 2, ComboId = "TT" });

            RangeCombo.Add(new RangeCombo() { RangeId = 4, ComboId = "AJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 4, ComboId = "ATs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 4, ComboId = "KQs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 4, ComboId = "KJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 4, ComboId = "KTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 4, ComboId = "QJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 4, ComboId = "QTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 4, ComboId = "JTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 4, ComboId = "T9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 4, ComboId = "99" });
            RangeCombo.Add(new RangeCombo() { RangeId = 4, ComboId = "88" });

            RangeCombo.Add(new RangeCombo() { RangeId = 6, ComboId = "A9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 6, ComboId = "A8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 6, ComboId = "A7s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 6, ComboId = "A6s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 6, ComboId = "A5s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 6, ComboId = "A4s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 6, ComboId = "A3s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 6, ComboId = "A2s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 6, ComboId = "AJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 6, ComboId = "ATo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 6, ComboId = "K9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 6, ComboId = "K8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 6, ComboId = "KQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 6, ComboId = "KJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 6, ComboId = "Q9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 6, ComboId = "J9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 6, ComboId = "77" });
            RangeCombo.Add(new RangeCombo() { RangeId = 6, ComboId = "66" });

            // MP1
            RangeCombo.Add(new RangeCombo() { RangeId = 7, ComboId = "AA" });
            RangeCombo.Add(new RangeCombo() { RangeId = 7, ComboId = "AKs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 7, ComboId = "AQs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 7, ComboId = "AKo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 7, ComboId = "AQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 7, ComboId = "KK" });
            RangeCombo.Add(new RangeCombo() { RangeId = 7, ComboId = "QQ" });
            RangeCombo.Add(new RangeCombo() { RangeId = 7, ComboId = "JJ" });
            RangeCombo.Add(new RangeCombo() { RangeId = 7, ComboId = "TT" });

            RangeCombo.Add(new RangeCombo() { RangeId = 8, ComboId = "AJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 8, ComboId = "ATs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 8, ComboId = "KQs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 8, ComboId = "KJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 8, ComboId = "KTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 8, ComboId = "QJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 8, ComboId = "QTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 8, ComboId = "JTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 8, ComboId = "T9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 8, ComboId = "99" });
            RangeCombo.Add(new RangeCombo() { RangeId = 8, ComboId = "88" });
            RangeCombo.Add(new RangeCombo() { RangeId = 8, ComboId = "77" });
            RangeCombo.Add(new RangeCombo() { RangeId = 8, ComboId = "66" });

            RangeCombo.Add(new RangeCombo() { RangeId = 9, ComboId = "A9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 9, ComboId = "A8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 9, ComboId = "A7s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 9, ComboId = "A6s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 9, ComboId = "A5s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 9, ComboId = "A4s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 9, ComboId = "A3s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 9, ComboId = "A2s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 9, ComboId = "AJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 9, ComboId = "ATo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 9, ComboId = "A9o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 9, ComboId = "K9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 9, ComboId = "K8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 9, ComboId = "KQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 9, ComboId = "KJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 9, ComboId = "KTo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 9, ComboId = "Q9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 9, ComboId = "QJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 9, ComboId = "J9s" });

            //MP2 || LowJack
            RangeCombo.Add(new RangeCombo() { RangeId = 10, ComboId = "AA" });
            RangeCombo.Add(new RangeCombo() { RangeId = 10, ComboId = "Aks" });
            RangeCombo.Add(new RangeCombo() { RangeId = 10, ComboId = "AQs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 10, ComboId = "AJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 10, ComboId = "AKo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 10, ComboId = "AQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 10, ComboId = "KK" });
            RangeCombo.Add(new RangeCombo() { RangeId = 10, ComboId = "QQ" });
            RangeCombo.Add(new RangeCombo() { RangeId = 10, ComboId = "JJ" });
            RangeCombo.Add(new RangeCombo() { RangeId = 10, ComboId = "TT" });
            RangeCombo.Add(new RangeCombo() { RangeId = 10, ComboId = "99" });

            RangeCombo.Add(new RangeCombo() { RangeId = 11, ComboId = "ATs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 11, ComboId = "A9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 11, ComboId = "A8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 11, ComboId = "AJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 11, ComboId = "KQs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 11, ComboId = "KJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 11, ComboId = "KTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 11, ComboId = "QJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 11, ComboId = "QTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 11, ComboId = "JTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 11, ComboId = "T9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 11, ComboId = "98s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 11, ComboId = "88" });
            RangeCombo.Add(new RangeCombo() { RangeId = 11, ComboId = "77" });
            RangeCombo.Add(new RangeCombo() { RangeId = 11, ComboId = "66" });

            RangeCombo.Add(new RangeCombo() { RangeId = 12, ComboId = "A7s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 12, ComboId = "A6s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 12, ComboId = "A5s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 12, ComboId = "A4s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 12, ComboId = "A3s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 12, ComboId = "A2s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 12, ComboId = "ATo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 12, ComboId = "A9o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 12, ComboId = "A8o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 12, ComboId = "K9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 12, ComboId = "K8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 12, ComboId = "K7s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 12, ComboId = "K6s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 12, ComboId = "KQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 12, ComboId = "KJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 12, ComboId = "KTo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 12, ComboId = "Q9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 12, ComboId = "Q8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 12, ComboId = "QJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 12, ComboId = "QTo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 12, ComboId = "J9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 12, ComboId = "J8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 12, ComboId = "T8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 12, ComboId = "55" });

            //HiJack
            RangeCombo.Add(new RangeCombo() { RangeId = 13, ComboId = "AA" });
            RangeCombo.Add(new RangeCombo() { RangeId = 13, ComboId = "AKs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 13, ComboId = "AQs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 13, ComboId = "AJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 13, ComboId = "AKo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 13, ComboId = "AQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 13, ComboId = "KK" });
            RangeCombo.Add(new RangeCombo() { RangeId = 13, ComboId = "QQ" });
            RangeCombo.Add(new RangeCombo() { RangeId = 13, ComboId = "JJ" });
            RangeCombo.Add(new RangeCombo() { RangeId = 13, ComboId = "TT" });
            RangeCombo.Add(new RangeCombo() { RangeId = 13, ComboId = "99" });
            RangeCombo.Add(new RangeCombo() { RangeId = 13, ComboId = "88" });

            RangeCombo.Add(new RangeCombo() { RangeId = 14, ComboId = "ATs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 14, ComboId = "A9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 14, ComboId = "A8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 14, ComboId = "A5s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 14, ComboId = "KQs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 14, ComboId = "KJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 14, ComboId = "KTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 14, ComboId = "K9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 14, ComboId = "KQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 14, ComboId = "QJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 14, ComboId = "QTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 14, ComboId = "Q9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 14, ComboId = "JTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 14, ComboId = "J9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 14, ComboId = "T9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 14, ComboId = "98s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 14, ComboId = "77" });
            RangeCombo.Add(new RangeCombo() { RangeId = 14, ComboId = "66" });
            RangeCombo.Add(new RangeCombo() { RangeId = 14, ComboId = "55" });

            RangeCombo.Add(new RangeCombo() { RangeId = 15, ComboId = "A7s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 15, ComboId = "A6s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 15, ComboId = "A4s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 15, ComboId = "A3s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 15, ComboId = "A2s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 15, ComboId = "ATo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 15, ComboId = "A9o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 15, ComboId = "A8o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 15, ComboId = "K8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 15, ComboId = "K7s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 15, ComboId = "K6s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 15, ComboId = "KJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 15, ComboId = "KTo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 15, ComboId = "Q8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 15, ComboId = "QJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 15, ComboId = "QTo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 15, ComboId = "J8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 15, ComboId = "JTo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 15, ComboId = "T8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 15, ComboId = "87s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 15, ComboId = "44" });

            RangeCombo.Add(new RangeCombo() { RangeId = 16, ComboId = "AJo" });

            //Cutoff
            RangeCombo.Add(new RangeCombo() { RangeId = 17, ComboId = "AA" });
            RangeCombo.Add(new RangeCombo() { RangeId = 17, ComboId = "AKs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 17, ComboId = "AQs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 17, ComboId = "AJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 17, ComboId = "ATs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 17, ComboId = "AKo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 17, ComboId = "AQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 17, ComboId = "AJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 17, ComboId = "KK" });
            RangeCombo.Add(new RangeCombo() { RangeId = 17, ComboId = "QQ" });
            RangeCombo.Add(new RangeCombo() { RangeId = 17, ComboId = "JJ" });
            RangeCombo.Add(new RangeCombo() { RangeId = 17, ComboId = "TT" });
            RangeCombo.Add(new RangeCombo() { RangeId = 17, ComboId = "99" });
            RangeCombo.Add(new RangeCombo() { RangeId = 17, ComboId = "88" });
            RangeCombo.Add(new RangeCombo() { RangeId = 17, ComboId = "77" });

            RangeCombo.Add(new RangeCombo() { RangeId = 18, ComboId = "A9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 18, ComboId = "A8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 18, ComboId = "A7s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 18, ComboId = "A6s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 18, ComboId = "A5s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 18, ComboId = "A4s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 18, ComboId = "A3s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 18, ComboId = "A2s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 18, ComboId = "ATo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 18, ComboId = "A9o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 18, ComboId = "KQs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 18, ComboId = "KJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 18, ComboId = "KTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 18, ComboId = "K9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 18, ComboId = "KJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 18, ComboId = "KQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 18, ComboId = "QJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 18, ComboId = "QTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 18, ComboId = "Q9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 18, ComboId = "JTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 18, ComboId = "J9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 18, ComboId = "T9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 18, ComboId = "98s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 18, ComboId = "87s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 18, ComboId = "76s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 18, ComboId = "66" });
            RangeCombo.Add(new RangeCombo() { RangeId = 18, ComboId = "65s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 18, ComboId = "55" });
            RangeCombo.Add(new RangeCombo() { RangeId = 18, ComboId = "44" });

            RangeCombo.Add(new RangeCombo() { RangeId = 19, ComboId = "A8o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 19, ComboId = "A7o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 19, ComboId = "A6o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 19, ComboId = "A5o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 19, ComboId = "A4o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 19, ComboId = "A3o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 19, ComboId = "A2o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 19, ComboId = "K8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 19, ComboId = "K7s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 19, ComboId = "K6s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 19, ComboId = "K5s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 19, ComboId = "K4s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 19, ComboId = "K3s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 19, ComboId = "K2s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 19, ComboId = "KTo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 19, ComboId = "K9o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 19, ComboId = "Q8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 19, ComboId = "Q7s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 19, ComboId = "Q6s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 19, ComboId = "QJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 19, ComboId = "QTo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 19, ComboId = "JTo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 19, ComboId = "J8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 19, ComboId = "J7s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 19, ComboId = "T8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 19, ComboId = "T7s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 19, ComboId = "97s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 19, ComboId = "86s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 19, ComboId = "75s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 19, ComboId = "64s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 19, ComboId = "54s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 19, ComboId = "33" });
            RangeCombo.Add(new RangeCombo() { RangeId = 19, ComboId = "22" });

            //BTN
            RangeCombo.Add(new RangeCombo() { RangeId = 20, ComboId = "AA" });
            RangeCombo.Add(new RangeCombo() { RangeId = 20, ComboId = "AKs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 20, ComboId = "AQs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 20, ComboId = "AJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 20, ComboId = "ATs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 20, ComboId = "AKo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 20, ComboId = "AQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 20, ComboId = "AJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 20, ComboId = "KK" });
            RangeCombo.Add(new RangeCombo() { RangeId = 20, ComboId = "KQs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 20, ComboId = "KTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 20, ComboId = "KQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 20, ComboId = "QQ" });
            RangeCombo.Add(new RangeCombo() { RangeId = 20, ComboId = "JJ" });
            RangeCombo.Add(new RangeCombo() { RangeId = 20, ComboId = "TT" });
            RangeCombo.Add(new RangeCombo() { RangeId = 20, ComboId = "99" });
            RangeCombo.Add(new RangeCombo() { RangeId = 20, ComboId = "88" });
            RangeCombo.Add(new RangeCombo() { RangeId = 20, ComboId = "77" });

            RangeCombo.Add(new RangeCombo() { RangeId = 21, ComboId = "66" });
            RangeCombo.Add(new RangeCombo() { RangeId = 21, ComboId = "55" });
            RangeCombo.Add(new RangeCombo() { RangeId = 21, ComboId = "44" });
            RangeCombo.Add(new RangeCombo() { RangeId = 21, ComboId = "33" });
            RangeCombo.Add(new RangeCombo() { RangeId = 21, ComboId = "22" });

            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "A9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "A8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "A7s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "A6s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "A5s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "A4s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "A3s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "A2s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "ATo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "A9o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "KTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "K9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "K8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "K7s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "K6s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "K5s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "KJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "KTo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "QJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "QTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "Q9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "Q8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "QJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "QTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "Q9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "Q8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "JTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "J9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "J8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "T9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "T8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "98s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "97s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "87s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "86s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "76s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "75s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "65s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "64s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 22, ComboId = "54s" });

            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "A8o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "A7o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "A6o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "A5o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "A4o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "A3o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "A2o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "K4s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "K3s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "K2s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "K9o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "K8o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "K7o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "K6o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "K5o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "Q7s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "Q6s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "Q5s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "Q4s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "Q3s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "Q2s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "QTo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "Q9o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "Q8o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "Q7o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "J7s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "J6s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "J5s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "J4s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "J3s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "J2s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "JTo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "J9o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "J8o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "J7o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "T7s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "T6s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "T5s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "T9o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "T8o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "T7o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "96s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "95s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "98o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "97o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "85s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "87o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "76o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "65o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 23, ComboId = "43s" });

            return RangeCombo;
        }
    }
}
