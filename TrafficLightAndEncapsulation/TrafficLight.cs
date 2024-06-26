﻿using System.Text;

namespace TrafficLightAndEncapsulation
{
    internal class TrafficLight
    {
        public int Phase { get; private set; }

        //public int Phase
        //{
        //    get
        //    {
        //        return _phase;
        //    }
        //    private set
        //    {
        //        _phase = value;
        //    } 
        //}

        //public int GetPhase()
        //{
        //    return _phase;
        //}

        //public void SetPhase(int phase)
        //{
        //    _phase = phase;
        //}

        public TrafficLight()
        {
        }

        public TrafficLight(int phase)
        {
            if (phase >= 0 && phase <= 3)
            {
                Phase = phase;
            }
        }


        public void Next()
        {
            Phase++;
            if (Phase == 4) Phase = 0;
            //_phase = _phase == 4 ? 0 : _phase + 1;
            //_phase = (_phase + 1) % 4;
        }

        public void Show()
        {
            var red = Phase < 2;
            var yellow = Phase is 1 or 3;
            //var yellow = _phase % 2 == 1;
            var green = Phase == 2;
            Show(red, yellow, green);
        }

        private static void Show(bool red, bool yellow, bool green)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("┏━┓");
            DrawLine(red ? ConsoleColor.Red : ConsoleColor.Black);
            DrawLine(yellow ? ConsoleColor.Yellow : ConsoleColor.Black);
            DrawLine(green ? ConsoleColor.Green : ConsoleColor.Black);
            Console.WriteLine("┗━┛");
        }

        private static void DrawLine(ConsoleColor color)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("┃");
            Console.ForegroundColor = color;
            Console.Write("O");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("┃");
        }
    }
}


