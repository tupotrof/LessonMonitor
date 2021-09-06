using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LessonMonitor.API
{
    public class Team
    {
        public string Name { get; init; }
        public int Size { get; init; }
        public List<string> Teammates { get; init; }


    }
}
