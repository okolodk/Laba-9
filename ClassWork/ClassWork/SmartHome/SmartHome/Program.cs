namespace SmartHome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tempSensor = new TemperatureSensor();
            var motionSensor = new MotionSensor();
            var smartLight = new SmartLight();

            tempSensor.OnOverheat += Notifier.SendTemperatureAlert;
            motionSensor.OnMotionDetected += Notifier.LogMotionEvent;
            motionSensor.OnMotionDetected += smartLight.TurnOn;


            tempSensor.CheckTemperature(15);
            tempSensor.CheckTemperature(35);
            motionSensor.DetectMotion(false);
            motionSensor.DetectMotion(true);
            Thread.Sleep(3000);
            smartLight.TurnOff();
        }
    }
}
