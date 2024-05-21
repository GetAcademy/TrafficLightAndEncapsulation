namespace TrafficLightAndEncapsulation
{
    internal class Stats
    {
        private int _sum;
        private int _n;

        public void AddNumber(int number)
        {
            _n++;
            _sum += number;
        }

        public void Show()
        {
            Console.WriteLine($"Sum: {_sum} Snitt: {_sum/_n} Ant tall: {_n}");

        }
    }
}
