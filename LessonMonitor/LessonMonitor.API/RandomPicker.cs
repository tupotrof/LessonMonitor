using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LessonMonitor.API.Controllers
{
    public class RandomPicker
    {
        public int PickSize { get; private init; }
        public int TotalPicked { get; private set; }

        private bool[] numberIsPicked;
        private Random random;

        public RandomPicker(int size)
        {
            random = new Random();
            PickSize = size;
            numberIsPicked = new bool[PickSize];
            Reset();
        }

        public void Reset()
        {
            TotalPicked = 0;
            for (int i = 0; i < PickSize; ++i)
                numberIsPicked[i] = false;
        }

        public int Pick()
        {
            if (TotalPicked == PickSize) return -1;
            TotalPicked++;
            int a;
            do {
                a = random.Next(PickSize);
            } while (numberIsPicked[a]);
            numberIsPicked[a] = true;
            return a;
        }

        public int[] Pick(int size)
        {
            if (TotalPicked + size > PickSize) return null;
            var list = new List<int>();
            for (int i = 0; i < size; ++i)
                list.Add(Pick());
            return list.ToArray();
        }

    }
}
