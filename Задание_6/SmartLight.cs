using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Задание_6
{
    public delegate void ChangedHandler(bool condition);
    public delegate void LightChangedHandler(int condition);
    internal class SmartLight
    {
        public event ChangedHandler OnStateChanged;
        public event LightChangedHandler OnLightChanged;
        public bool IsOn { get; set; }
        public int Brightness { get; set; }

        public void Toggle()
        {
            IsOn = !IsOn;
            OnStateChanged?.Invoke(IsOn);
        }

        public void SetBrightness(int brightness)
        {
            Brightness = brightness;
            OnLightChanged?.Invoke(Brightness);
        }
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public static SmartLight FromJson(string json)
        {
            return JsonConvert.DeserializeObject<SmartLight>(json);
        }

    }
}
