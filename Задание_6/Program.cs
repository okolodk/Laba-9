namespace Задание_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartLight light = new SmartLight();
            light.OnStateChanged += lightisOn;
            light.OnLightChanged += lightCondition;
            light.IsOn = true;
            light.SetBrightness(90);

            light.Toggle();
            light.Toggle();

            string json = light.ToJson();
            Console.WriteLine($"JSON: {json}");

            SmartLight l = SmartLight.FromJson(json);
            Console.WriteLine($"{l.IsOn}:{l.Brightness}");
        }
        static void lightisOn(bool isOn)
        {
            Console.WriteLine(isOn ? "Свет вкл" : "Свет выкл");
        }
        static void lightCondition(int brightness)
        {
            Console.WriteLine($"Яркость света {brightness}");
        }
    }
}
