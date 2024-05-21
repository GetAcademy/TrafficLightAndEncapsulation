namespace TrafficLightAndEncapsulation
{
    internal class Clicker
    {
        public int Points { get; private set; }
        private int _upgrades;
        private char _letter;

        public Clicker()
        {
        }

        public Clicker(char letter)
        {
            Points = 0;
            _upgrades = 1;
            _letter = letter;
        }

        public void HandleLetter(char letter)
        {
            if (letter == _letter)
            {
                Click();
            }
            else if (letter == char.ToUpper(_letter))
            {
                BuyUpgrade();
            }
        }

        public void Click()
        {
            Points += _upgrades;
        }

        public void BuyUpgrade()
        {
            if (Points >= 10)
            {
                _upgrades++;
                Points -= 10;
            }
        }

        public void Show()
        {
            var upperLetter = char.ToUpper(_letter);
            var text = $"Klikker {upperLetter}: Du har {Points} poeng. ({_letter}=klikk, {upperLetter}=upgrade)";
            Console.WriteLine(text);
        }
    }
}
