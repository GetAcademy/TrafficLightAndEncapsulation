using System.Text;

namespace TrafficLightAndEncapsulation
{
    internal class TrafficLightV0
    {
        private bool _red;
        private bool _yellow;
        private bool _green;

        public TrafficLightV0()
        {
            _red = true;
        }

        //public TrafficLightV0(int phase)
        //{
            
        //    _red = red;
        //    _yellow = yellow;
        //    _green = green;
        //}

        public void Next()
        {
            if (_red && !_yellow)
            {
                _yellow = true;
            }
            else if (_red)
            {
                _red = false;
                _yellow = false;
                _green = true;
            }
            else if (_green)
            {
                _green = false;
                _yellow = true;
            }
            else if (_yellow)
            {
                _yellow = false;
                _red = true;
            }
        }

        public void Show()
        {
            Show(_red, _yellow, _green);
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
