using Microsoft.SPOT;
using System.Threading;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

namespace Netduino3Poc
{
    public class Program
    {
        public static void Main()
        {
            Debug.Print("Starting N3 POC");

            Blinky();
        }

        public static void Blinky()
        {
            var led = new OutputPort(Pins.ONBOARD_LED, false);
            var outputD11 = new OutputPort(Pins.GPIO_PIN_D11, false);
            var outputD9 = new OutputPort(Pins.GPIO_PIN_D9, false);
            // as per https://github.com/WildernessLabs/Netduino_SDK/issues/20, also tried assigning the pin directly but this also doesn't work
            //var outputD9 = new OutputPort((Cpu.Pin) 69, true);
            
            for (var i = 1;;)
            {
                Debug.Print("Loop:" + i++);

                led.Write(true); 
                outputD9.Write(true); 
                outputD11.Write(true); 

                Thread.Sleep(250); // sleep for 250ms

                led.Write(false); 
                outputD9.Write(false); 
                outputD11.Write(false); 
                
                Thread.Sleep(250); // sleep for 250ms
            }
        }
    }
}
