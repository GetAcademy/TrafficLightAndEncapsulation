using TrafficLightAndEncapsulation;

var stats = new Stats();

while (true)
{
    Console.Write("Skriv et tall: ");
    var numberStr = Console.ReadLine();
    var number = Convert.ToInt32(numberStr);
    stats.AddNumber(number);
    stats.Show();
}



//var clickerA = new Clicker('a');
//var clickerB = new Clicker('b');
//while (true)
//{
//    Console.Clear();
//    clickerA.Show();
//    clickerB.Show();
//    var sumPoints = clickerA.Points + clickerB.Points;
//    Console.WriteLine($"Poeng til sammen: {sumPoints}");
//    var cmdKey = Console.ReadKey(true);
//    clickerA.HandleLetter(cmdKey.KeyChar);
//    clickerB.HandleLetter(cmdKey.KeyChar);
//}

//var trafficLight = new TrafficLight();
//while (true)
//{
//    Console.Clear();
//    trafficLight.Show();
//    Console.WriteLine($"Fase: {trafficLight.Phase}");
//    //trafficLight.Phase = 7;
//    trafficLight.Next();
//    Console.ReadKey(true);
//}