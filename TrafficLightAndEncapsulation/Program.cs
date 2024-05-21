using TrafficLightAndEncapsulation;

var trafficLight = new TrafficLight();
while (true)
{
    Console.Clear();
    trafficLight.Show();
    trafficLight.Next();
    Console.ReadKey(true);
}