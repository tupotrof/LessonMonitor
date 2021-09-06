using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LessonMonitor.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RandomPickController
    {
        private static string[] Names = new[] {
            "Банкир", "Снайпер", "Тенька", "Джонни", "Доктор Хорс", "Микро", 
            "Повелитель", "Ципрус", "Куртизанка", "Кровавый Эльф", "Могуло", "Тупотроф",
        };

        private RandomPicker picker;

        public RandomPickController()
        {
            picker = new RandomPicker(Names.Length);
        }

        [HttpGet]
        public List<Team> Pick(int teams, int teamSize)
        {
            picker.Reset();
            if (teams * teamSize > picker.PickSize) return null;
            var list = new List<Team>();
            for (int t = 1; t <= teams; ++t) {
                list.Add(new Team {
                    Name = $"Team #{t}",
                    Size = teamSize,
                    Teammates = picker.Pick(teamSize).Select(a => Names[a]).ToList()
                });
            }
            return list;
        }
    }
}
