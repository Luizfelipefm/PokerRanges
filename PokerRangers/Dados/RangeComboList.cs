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
            #region "20bb - 40bb"
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
            #endregion

            #region "10bb - 20bb"

            //UTG - Raise
            RangeCombo.Add(new RangeCombo() { RangeId = 24, ComboId = "AA" });
            RangeCombo.Add(new RangeCombo() { RangeId = 24, ComboId = "AKs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 24, ComboId = "AQs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 24, ComboId = "A9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 24, ComboId = "A8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 24, ComboId = "A7s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 24, ComboId = "A6s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 24, ComboId = "A5s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 24, ComboId = "AKo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 24, ComboId = "KK" });
            RangeCombo.Add(new RangeCombo() { RangeId = 24, ComboId = "KQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 24, ComboId = "K9o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 24, ComboId = "KQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 24, ComboId = "QQ" });
            RangeCombo.Add(new RangeCombo() { RangeId = 24, ComboId = "Q9o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 24, ComboId = "KJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 24, ComboId = "JJ" });
            RangeCombo.Add(new RangeCombo() { RangeId = 24, ComboId = "ATo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 24, ComboId = "TT" });
            RangeCombo.Add(new RangeCombo() { RangeId = 24, ComboId = "99" });
            RangeCombo.Add(new RangeCombo() { RangeId = 24, ComboId = "88" });

            //UTG1 - Raise
            RangeCombo.Add(new RangeCombo() { RangeId = 25, ComboId = "AA" });
            RangeCombo.Add(new RangeCombo() { RangeId = 25, ComboId = "AKs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 25, ComboId = "AQs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 25, ComboId = "A9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 25, ComboId = "A8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 25, ComboId = "A7s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 25, ComboId = "A6s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 25, ComboId = "A5s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 25, ComboId = "AKo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 25, ComboId = "KK" });
            RangeCombo.Add(new RangeCombo() { RangeId = 25, ComboId = "KQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 25, ComboId = "K9o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 25, ComboId = "KQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 25, ComboId = "QQ" });
            RangeCombo.Add(new RangeCombo() { RangeId = 25, ComboId = "Q9o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 25, ComboId = "KJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 25, ComboId = "JJ" });
            RangeCombo.Add(new RangeCombo() { RangeId = 25, ComboId = "ATo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 25, ComboId = "TT" });
            RangeCombo.Add(new RangeCombo() { RangeId = 25, ComboId = "99" });
            RangeCombo.Add(new RangeCombo() { RangeId = 25, ComboId = "88" });

            //UTG - Shove
            RangeCombo.Add(new RangeCombo() { RangeId = 26, ComboId = "AJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 26, ComboId = "ATs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 26, ComboId = "KJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 26, ComboId = "KTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 26, ComboId = "AQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 26, ComboId = "QJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 26, ComboId = "QTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 26, ComboId = "AJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 26, ComboId = "JTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 26, ComboId = "66" });
            RangeCombo.Add(new RangeCombo() { RangeId = 26, ComboId = "55" });

            //UTG1 - Shove
            RangeCombo.Add(new RangeCombo() { RangeId = 27, ComboId = "AJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 27, ComboId = "ATs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 27, ComboId = "KJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 27, ComboId = "KTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 27, ComboId = "AQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 27, ComboId = "QJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 27, ComboId = "QTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 27, ComboId = "AJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 27, ComboId = "JTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 27, ComboId = "66" });
            RangeCombo.Add(new RangeCombo() { RangeId = 27, ComboId = "55" });

            //UTG - Raise
            RangeCombo.Add(new RangeCombo() { RangeId = 28, ComboId = "AJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 28, ComboId = "ATs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 28, ComboId = "KJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 28, ComboId = "KTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 28, ComboId = "AQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 28, ComboId = "QJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 28, ComboId = "QTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 28, ComboId = "AJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 28, ComboId = "JTs" });

            //UTG1 - Raise
            RangeCombo.Add(new RangeCombo() { RangeId = 29, ComboId = "AJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 29, ComboId = "ATs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 29, ComboId = "KJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 29, ComboId = "KTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 29, ComboId = "AQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 29, ComboId = "QJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 29, ComboId = "QTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 29, ComboId = "AJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 29, ComboId = "JTs" });

            //UTG - Shove
            RangeCombo.Add(new RangeCombo() { RangeId = 30, ComboId = "77" });

            //UTG1 - Shove
            RangeCombo.Add(new RangeCombo() { RangeId = 31, ComboId = "77" });

            //MP1 - Raise
            RangeCombo.Add(new RangeCombo() { RangeId = 32, ComboId = "AA" });
            RangeCombo.Add(new RangeCombo() { RangeId = 32, ComboId = "AKs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 32, ComboId = "AQs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 32, ComboId = "A7s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 32, ComboId = "A6s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 32, ComboId = "A5s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 32, ComboId = "AKo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 32, ComboId = "KK" });
            RangeCombo.Add(new RangeCombo() { RangeId = 32, ComboId = "KQs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 32, ComboId = "QQ" });
            RangeCombo.Add(new RangeCombo() { RangeId = 32, ComboId = "QJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 32, ComboId = "JJ" });
            RangeCombo.Add(new RangeCombo() { RangeId = 32, ComboId = "KTo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 32, ComboId = "TT" });
            RangeCombo.Add(new RangeCombo() { RangeId = 32, ComboId = "T9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 32, ComboId = "99" });
            RangeCombo.Add(new RangeCombo() { RangeId = 32, ComboId = "88" });

            //MP1 - Shove 
            RangeCombo.Add(new RangeCombo() { RangeId = 33, ComboId = "AJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 33, ComboId = "ATs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 33, ComboId = "A9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 33, ComboId = "A8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 33, ComboId = "KJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 33, ComboId = "KTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 33, ComboId = "K9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 33, ComboId = "AQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 33, ComboId = "KQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 33, ComboId = "QJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 33, ComboId = "QTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 33, ComboId = "Q9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 33, ComboId = "AJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 33, ComboId = "KJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 33, ComboId = "JTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 33, ComboId = "J9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 33, ComboId = "ATo" });

            //MP1 - Raise 
            RangeCombo.Add(new RangeCombo() { RangeId = 34, ComboId = "AJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 34, ComboId = "ATs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 34, ComboId = "A9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 34, ComboId = "A8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 34, ComboId = "KJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 34, ComboId = "KTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 34, ComboId = "K9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 34, ComboId = "AQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 34, ComboId = "KQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 34, ComboId = "QJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 34, ComboId = "QTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 34, ComboId = "Q9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 34, ComboId = "AJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 34, ComboId = "KJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 34, ComboId = "JTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 34, ComboId = "J9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 34, ComboId = "ATo" });

            //MP1 - Shove
            RangeCombo.Add(new RangeCombo() { RangeId = 35, ComboId = "77" });

            //MP1 - Raise
            RangeCombo.Add(new RangeCombo() { RangeId = 36, ComboId = "77" });

            //MP1 - Shove
            RangeCombo.Add(new RangeCombo() { RangeId = 35, ComboId = "66" });

            //MP1 - Shove
            RangeCombo.Add(new RangeCombo() { RangeId = 33, ComboId = "55" });
            RangeCombo.Add(new RangeCombo() { RangeId = 33, ComboId = "44" });
            RangeCombo.Add(new RangeCombo() { RangeId = 33, ComboId = "33" });


            //MP2 - raise
            RangeCombo.Add(new RangeCombo() { RangeId = 37, ComboId = "AA" });
            RangeCombo.Add(new RangeCombo() { RangeId = 37, ComboId = "AKs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 37, ComboId = "AQs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 37, ComboId = "AJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 37, ComboId = "ATs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 37, ComboId = "KK" });
            RangeCombo.Add(new RangeCombo() { RangeId = 37, ComboId = "KQs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 37, ComboId = "K8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 37, ComboId = "QQ" });
            RangeCombo.Add(new RangeCombo() { RangeId = 37, ComboId = "QJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 37, ComboId = "JJ" });
            RangeCombo.Add(new RangeCombo() { RangeId = 37, ComboId = "KTo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 37, ComboId = "QTo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 37, ComboId = "TT" });
            RangeCombo.Add(new RangeCombo() { RangeId = 37, ComboId = "A9o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 37, ComboId = "99" });
            RangeCombo.Add(new RangeCombo() { RangeId = 37, ComboId = "88" });

            //MP2 - Shove
            RangeCombo.Add(new RangeCombo() { RangeId = 38, ComboId = "A7s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 38, ComboId = "A6s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 38, ComboId = "A5s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 38, ComboId = "A4s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 38, ComboId = "A3s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 38, ComboId = "A2s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 38, ComboId = "K9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 38, ComboId = "Q9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 38, ComboId = "KJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 38, ComboId = "J9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 38, ComboId = "T9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 38, ComboId = "44" });
            RangeCombo.Add(new RangeCombo() { RangeId = 38, ComboId = "33" });
            RangeCombo.Add(new RangeCombo() { RangeId = 38, ComboId = "22" });

            //MP2 - Raise
            RangeCombo.Add(new RangeCombo() { RangeId = 39, ComboId = "A7s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 39, ComboId = "A6s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 39, ComboId = "A5s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 39, ComboId = "A4s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 39, ComboId = "A3s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 39, ComboId = "A2s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 39, ComboId = "K9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 39, ComboId = "Q9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 39, ComboId = "KJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 39, ComboId = "J9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 39, ComboId = "T9s" });

            //MP2 - Shove
            RangeCombo.Add(new RangeCombo() { RangeId = 40, ComboId = "A9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 40, ComboId = "A8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 40, ComboId = "AKo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 40, ComboId = "KJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 40, ComboId = "KTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 40, ComboId = "AQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 40, ComboId = "KQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 40, ComboId = "QJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 40, ComboId = "QTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 40, ComboId = "AJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 40, ComboId = "JTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 40, ComboId = "ATo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 40, ComboId = "77" });
            RangeCombo.Add(new RangeCombo() { RangeId = 40, ComboId = "66" });
            RangeCombo.Add(new RangeCombo() { RangeId = 40, ComboId = "55" });

            //MP2 - Raise
            RangeCombo.Add(new RangeCombo() { RangeId = 41, ComboId = "A9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 41, ComboId = "A8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 41, ComboId = "AKo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 41, ComboId = "KJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 41, ComboId = "KTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 41, ComboId = "AQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 41, ComboId = "KQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 41, ComboId = "QJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 41, ComboId = "QTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 41, ComboId = "AJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 41, ComboId = "JTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 41, ComboId = "ATo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 41, ComboId = "77" });
            RangeCombo.Add(new RangeCombo() { RangeId = 41, ComboId = "66" });


            //HJ - Shove
            RangeCombo.Add(new RangeCombo() { RangeId = 42, ComboId = "ATs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 42, ComboId = "A9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 42, ComboId = "KQs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 42, ComboId = "KJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 42, ComboId = "AJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 42, ComboId = "66" });
            RangeCombo.Add(new RangeCombo() { RangeId = 42, ComboId = "55" });
            RangeCombo.Add(new RangeCombo() { RangeId = 42, ComboId = "44" });
            RangeCombo.Add(new RangeCombo() { RangeId = 42, ComboId = "33" });
            RangeCombo.Add(new RangeCombo() { RangeId = 42, ComboId = "22" });

            //HJ - Raise
            RangeCombo.Add(new RangeCombo() { RangeId = 43, ComboId = "AA" });
            RangeCombo.Add(new RangeCombo() { RangeId = 43, ComboId = "AKs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 43, ComboId = "AKo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 43, ComboId = "KK" });
            RangeCombo.Add(new RangeCombo() { RangeId = 43, ComboId = "QQ" });
            RangeCombo.Add(new RangeCombo() { RangeId = 43, ComboId = "QJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 43, ComboId = "JJ" });
            RangeCombo.Add(new RangeCombo() { RangeId = 43, ComboId = "KTo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 43, ComboId = "QTo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 43, ComboId = "TT" });
            RangeCombo.Add(new RangeCombo() { RangeId = 43, ComboId = "A7o" });

            //HJ - Shove 10 a 12 bb
            RangeCombo.Add(new RangeCombo() { RangeId = 44, ComboId = "AQs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 44, ComboId = "AJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 44, ComboId = "A4s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 44, ComboId = "A3s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 44, ComboId = "A2s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 44, ComboId = "KJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 44, ComboId = "ATo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 44, ComboId = "A9o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 44, ComboId = "99" });
            RangeCombo.Add(new RangeCombo() { RangeId = 44, ComboId = "A8o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 44, ComboId = "88" });
            RangeCombo.Add(new RangeCombo() { RangeId = 44, ComboId = "77" });

            //HJ - Raise 12 a 20 bb
            RangeCombo.Add(new RangeCombo() { RangeId = 45, ComboId = "AQs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 45, ComboId = "AJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 45, ComboId = "A4s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 45, ComboId = "A3s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 45, ComboId = "A2s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 45, ComboId = "KJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 45, ComboId = "ATo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 45, ComboId = "A9o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 45, ComboId = "99" });
            RangeCombo.Add(new RangeCombo() { RangeId = 45, ComboId = "A8o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 45, ComboId = "88" });
            RangeCombo.Add(new RangeCombo() { RangeId = 45, ComboId = "77" });

            //HJ - Shove 10 a 15 bb
            RangeCombo.Add(new RangeCombo() { RangeId = 46, ComboId = "A8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 46, ComboId = "A7s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 46, ComboId = "A6s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 46, ComboId = "A5s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 46, ComboId = "KTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 46, ComboId = "K9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 46, ComboId = "K8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 46, ComboId = "AQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 46, ComboId = "KQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 46, ComboId = "QJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 46, ComboId = "QTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 46, ComboId = "Q9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 46, ComboId = "Q8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 46, ComboId = "JTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 46, ComboId = "J9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 46, ComboId = "J8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 46, ComboId = "T9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 46, ComboId = "T8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 46, ComboId = "98s" });

            //HJ - Raise 15 a 20 bb
            RangeCombo.Add(new RangeCombo() { RangeId = 47, ComboId = "A8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 47, ComboId = "A7s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 47, ComboId = "A6s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 47, ComboId = "A5s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 47, ComboId = "KTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 47, ComboId = "K9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 47, ComboId = "K8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 47, ComboId = "AQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 47, ComboId = "KQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 47, ComboId = "QJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 47, ComboId = "QTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 47, ComboId = "Q9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 47, ComboId = "Q8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 47, ComboId = "JTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 47, ComboId = "J9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 47, ComboId = "J8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 47, ComboId = "T9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 47, ComboId = "T8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 47, ComboId = "98s" });


            //CO - Shove 10 a 20 bb
            RangeCombo.Add(new RangeCombo() { RangeId = 48, ComboId = "A8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 48, ComboId = "KJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 48, ComboId = "KQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 48, ComboId = "QJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 48, ComboId = "KJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 48, ComboId = "A9o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 48, ComboId = "A8o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 48, ComboId = "66" });
            RangeCombo.Add(new RangeCombo() { RangeId = 48, ComboId = "55" });
            RangeCombo.Add(new RangeCombo() { RangeId = 48, ComboId = "44" });
            RangeCombo.Add(new RangeCombo() { RangeId = 48, ComboId = "33" });
            RangeCombo.Add(new RangeCombo() { RangeId = 48, ComboId = "22" });

            //CO - Raise 10 a 20 bb
            RangeCombo.Add(new RangeCombo() { RangeId = 49, ComboId = "AA" });
            RangeCombo.Add(new RangeCombo() { RangeId = 49, ComboId = "AKs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 49, ComboId = "KK" });
            RangeCombo.Add(new RangeCombo() { RangeId = 49, ComboId = "K7s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 49, ComboId = "QQ" });
            RangeCombo.Add(new RangeCombo() { RangeId = 49, ComboId = "Q7s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 49, ComboId = "JJ" });
            RangeCombo.Add(new RangeCombo() { RangeId = 49, ComboId = "J7s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 49, ComboId = "QTo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 49, ComboId = "JTo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 49, ComboId = "TT" });
            RangeCombo.Add(new RangeCombo() { RangeId = 49, ComboId = "K9o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 49, ComboId = "Q9o" });

            //CO - Shove 10 a 12 bb
            RangeCombo.Add(new RangeCombo() { RangeId = 50, ComboId = "AQs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 50, ComboId = "AJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 50, ComboId = "ATs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 50, ComboId = "A9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 50, ComboId = "AKo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 50, ComboId = "KQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 50, ComboId = "AQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 50, ComboId = "99" });
            RangeCombo.Add(new RangeCombo() { RangeId = 50, ComboId = "88" });
            RangeCombo.Add(new RangeCombo() { RangeId = 50, ComboId = "77" });
            RangeCombo.Add(new RangeCombo() { RangeId = 50, ComboId = "A4o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 50, ComboId = "A3o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 50, ComboId = "A2o" });

            //CO - Raise 12 a 20 bb
            RangeCombo.Add(new RangeCombo() { RangeId = 51, ComboId = "AQs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 51, ComboId = "AJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 51, ComboId = "ATs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 51, ComboId = "A9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 51, ComboId = "AKo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 51, ComboId = "KQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 51, ComboId = "AQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 51, ComboId = "99" });
            RangeCombo.Add(new RangeCombo() { RangeId = 51, ComboId = "88" });
            RangeCombo.Add(new RangeCombo() { RangeId = 51, ComboId = "77" });

            //CO - Shove 10 a 15 bb
            RangeCombo.Add(new RangeCombo() { RangeId = 52, ComboId = "A7s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 52, ComboId = "A6s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 52, ComboId = "A5s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 52, ComboId = "A4s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 52, ComboId = "A3s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 52, ComboId = "A2s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 52, ComboId = "KTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 52, ComboId = "K9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 52, ComboId = "K8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 52, ComboId = "QTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 52, ComboId = "Q9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 52, ComboId = "Q8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 52, ComboId = "AJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 52, ComboId = "QJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 52, ComboId = "JTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 52, ComboId = "J9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 52, ComboId = "J8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 52, ComboId = "ATo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 52, ComboId = "KTo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 52, ComboId = "T9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 52, ComboId = "T8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 52, ComboId = "98s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 52, ComboId = "A7o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 52, ComboId = "A6o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 52, ComboId = "A5o" });

            //CO - Raise 15 a 20 bb
            RangeCombo.Add(new RangeCombo() { RangeId = 53, ComboId = "A7s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 53, ComboId = "A6s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 53, ComboId = "A5s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 53, ComboId = "A4s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 53, ComboId = "A3s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 53, ComboId = "A2s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 53, ComboId = "KTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 53, ComboId = "K9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 53, ComboId = "K8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 53, ComboId = "QTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 53, ComboId = "Q9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 53, ComboId = "Q8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 53, ComboId = "AJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 53, ComboId = "QJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 53, ComboId = "JTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 53, ComboId = "J9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 53, ComboId = "J8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 53, ComboId = "ATo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 53, ComboId = "KTo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 53, ComboId = "T9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 53, ComboId = "T8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 53, ComboId = "98s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 53, ComboId = "A7o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 53, ComboId = "A6o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 53, ComboId = "A5o" });


            //BTN - Shove 10 a 20 bb
            RangeCombo.Add(new RangeCombo() { RangeId = 54, ComboId = "A7s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 54, ComboId = "A6s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 54, ComboId = "A5s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 54, ComboId = "A4s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 54, ComboId = "A3s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 54, ComboId = "A2s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 54, ComboId = "KTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 54, ComboId = "KQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 54, ComboId = "QJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 54, ComboId = "QTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 54, ComboId = "KJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 54, ComboId = "JTs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 54, ComboId = "A9o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 54, ComboId = "A8o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 54, ComboId = "A7o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 54, ComboId = "55" });
            RangeCombo.Add(new RangeCombo() { RangeId = 54, ComboId = "44" });
            RangeCombo.Add(new RangeCombo() { RangeId = 54, ComboId = "33" });
            RangeCombo.Add(new RangeCombo() { RangeId = 54, ComboId = "22" });

            //BTN - Raise 10 a 20 bb
            RangeCombo.Add(new RangeCombo() { RangeId = 55, ComboId = "AA" });
            RangeCombo.Add(new RangeCombo() { RangeId = 55, ComboId = "AKs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 55, ComboId = "KK" });
            RangeCombo.Add(new RangeCombo() { RangeId = 55, ComboId = "QQ" });
            RangeCombo.Add(new RangeCombo() { RangeId = 55, ComboId = "JJ" });
            RangeCombo.Add(new RangeCombo() { RangeId = 55, ComboId = "TT" });
            RangeCombo.Add(new RangeCombo() { RangeId = 55, ComboId = "Q6s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 55, ComboId = "Q5s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 55, ComboId = "Q9o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 55, ComboId = "J9o" });

            //BTN - Shove 10 a 12 bb
            RangeCombo.Add(new RangeCombo() { RangeId = 56, ComboId = "AQs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 56, ComboId = "AJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 56, ComboId = "ATs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 56, ComboId = "A9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 56, ComboId = "A8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 56, ComboId = "AKo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 56, ComboId = "KQs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 56, ComboId = "KJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 56, ComboId = "K4s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 56, ComboId = "K3s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 56, ComboId = "K2s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 56, ComboId = "AQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 56, ComboId = "ATo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 56, ComboId = "K9o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 56, ComboId = "T9o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 56, ComboId = "99" });
            RangeCombo.Add(new RangeCombo() { RangeId = 56, ComboId = "K8o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 56, ComboId = "88" });
            RangeCombo.Add(new RangeCombo() { RangeId = 56, ComboId = "K7o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 56, ComboId = "77" });
            RangeCombo.Add(new RangeCombo() { RangeId = 56, ComboId = "76s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 56, ComboId = "65s" });

            //BTN - Raise 12 a 20 bb
            RangeCombo.Add(new RangeCombo() { RangeId = 57, ComboId = "AQs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 57, ComboId = "AJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 57, ComboId = "ATs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 57, ComboId = "A9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 57, ComboId = "A8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 57, ComboId = "AKo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 57, ComboId = "KQs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 57, ComboId = "KJs" });
            RangeCombo.Add(new RangeCombo() { RangeId = 57, ComboId = "K4s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 57, ComboId = "K3s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 57, ComboId = "K2s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 57, ComboId = "AQo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 57, ComboId = "ATo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 57, ComboId = "K9o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 57, ComboId = "T9o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 57, ComboId = "99" });
            RangeCombo.Add(new RangeCombo() { RangeId = 57, ComboId = "K8o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 57, ComboId = "88" });
            RangeCombo.Add(new RangeCombo() { RangeId = 57, ComboId = "K7o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 57, ComboId = "77" });
            RangeCombo.Add(new RangeCombo() { RangeId = 57, ComboId = "76s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 57, ComboId = "65s" });

            //BTN - Shove 10 a 15 bb
            RangeCombo.Add(new RangeCombo() { RangeId = 58, ComboId = "K9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 58, ComboId = "K8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 58, ComboId = "K7s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 58, ComboId = "K6s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 58, ComboId = "K5s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 58, ComboId = "Q9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 58, ComboId = "Q8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 58, ComboId = "Q7s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 58, ComboId = "AJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 58, ComboId = "QJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 58, ComboId = "J9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 58, ComboId = "J8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 58, ComboId = "J7s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 58, ComboId = "KTo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 58, ComboId = "QTo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 58, ComboId = "JTo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 58, ComboId = "T9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 58, ComboId = "T8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 58, ComboId = "T7s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 58, ComboId = "98s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 58, ComboId = "97s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 58, ComboId = "87s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 58, ComboId = "A6o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 58, ComboId = "66" });
            RangeCombo.Add(new RangeCombo() { RangeId = 58, ComboId = "A5o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 58, ComboId = "A4o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 58, ComboId = "A3o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 58, ComboId = "A2o" });

            //BTN - Raise 15 a 20 bb
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "K9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "K8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "K7s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "K6s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "K5s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "Q9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "Q8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "Q7s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "AJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "QJo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "J9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "J8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "J7s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "KTo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "QTo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "JTo" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "T9s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "T8s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "T7s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "98s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "97s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "87s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "A6o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "66" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "A5o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "A4o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "A3o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "A2o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "Q4s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "Q3s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "Q2s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "J6s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "J5s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "T6s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "96s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "Q8o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "J8o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "T8o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "98o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "86s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "Q7o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "87o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "75s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "K6o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "64s" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "K5o" });
            RangeCombo.Add(new RangeCombo() { RangeId = 59, ComboId = "54s" });


            #endregion

            return RangeCombo;
        }
    }
}
