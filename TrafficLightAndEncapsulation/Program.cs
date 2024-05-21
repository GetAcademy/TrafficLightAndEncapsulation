using TrafficLightAndEncapsulation;

var trafficLight = new TrafficLight();
while (true)
{
    Console.Clear();
    trafficLight.Show();
    Console.WriteLine($"Fase: {trafficLight.Phase}");
    //trafficLight.Phase = 7;
    trafficLight.Next();
    Console.ReadKey(true);
}