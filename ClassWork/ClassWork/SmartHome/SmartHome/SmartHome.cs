using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public delegate void TemperatureEventHandler(string massage);
    public delegate void MotionEventHandler(string massage);
    internal class SmartHome
    {
    }
    public class TemperatureSensor
    {
        public event TemperatureEventHandler OnOverheat;

        public void CheckTemperature(int currentTemp)
        {
            if (currentTemp > 30)
            {
                OnOverheat?.Invoke($"!! Температура критическая: {currentTemp}!");
            }
        }
    }
    public class MotionSensor
    {
        public event MotionEventHandler OnMotionDetected;
        public void DetectMotion(bool isMotion)
        {
            if (isMotion)
            {
                OnMotionDetected?.Invoke("!! Обноружено движение в кридоре!");
            }
        }
    }
    public class Notifier
    {
        public static void SendTemperatureAlert(string message)
        {
            Console.WriteLine(message);
        }
        public static void LogMotionEvent(string message)
        {
            Console.WriteLine($"[Log] {message} (time: {DateTime.Now})");
        }

    }
    public class SmartLight
    {
        private bool isOn = false;

        public void TurnOn(string massage)
        {
            if (!isOn)
            {
                isOn = true;
                Console.WriteLine("On");
            }
        }
        public void TurnOff() {
            if (isOn) { 
                isOn = false;
                Console.WriteLine("Off");
            }

        }

    }
}
