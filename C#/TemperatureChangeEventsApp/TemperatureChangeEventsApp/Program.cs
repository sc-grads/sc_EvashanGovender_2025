using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureChangeEventsApp
{
    public delegate void TemperatureChangeHandler(string message);

    public class TemperatureChangedEventArgs : EventArgs
    {
        public string Temperature { get; }
        
        public TemperatureChangedEventArgs(int temperature)
        {
            Temperature = temperature.ToString();
        }
    }
    public class TemperatureMonitor
    {
        public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;
        //public event TemperatureChangeHandler OnTemperatureChanged;
        private int _temperature;
        public int Temperature
        {
            get { return _temperature; }
            set
            {
              
                if(_temperature != value)
                {
                    _temperature = value;
                    OnTemperatureChanged(new TemperatureChangedEventArgs(_temperature));
                }
            }
        }
        protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
        {
            TemperatureChanged?.Invoke(this,e);
        }
    }

    public class TemperatureAlert
    {
        public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine($"Alert: temperature is {e.Temperature} sender is: {sender}" );
        }
    }

    public class TemperatureCoolingAlert
    {
        public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine($"Cooling Alert: temperature is {e.Temperature} sender is: {sender}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureMonitor monitor = new TemperatureMonitor();
            TemperatureAlert alert = new TemperatureAlert();
            TemperatureCoolingAlert coolingAlert = new TemperatureCoolingAlert();
            // Subscribe to the event
            monitor.TemperatureChanged += alert.OnTemperatureChanged;
            monitor.TemperatureChanged += coolingAlert.OnTemperatureChanged;
            // Simulate temperature changes
            monitor.Temperature = 35; // High temperature
            monitor.Temperature = -5; // Low temperature
            monitor.Temperature = 20; // Normal temperature

            Console.ReadLine(); // Keep the console open
        }
    }
}
