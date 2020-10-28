using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PokerRangers.Models;
using PokerRangers.Dados;

namespace PokerRangers.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            var rangeList = new RangeList();
            var ranges = rangeList.GetRanges();

            var rangeComboList = new RangeComboList();
            var comboRanges = rangeComboList.GetRangeCombos();

            var posicaoList = new PosicaoList();
            var posicoes = posicaoList.GetPosicaos();

            var range = new Models.Range();
            range = ranges.FirstOrDefault();
            range.RangeCombos = comboRanges.Where(p => p.RangeId == range.RangeId).ToList();
            range.Posicao = posicoes.Where(p => p.PosicaoId == range.PosicaoId).FirstOrDefault();

            return View(range);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
