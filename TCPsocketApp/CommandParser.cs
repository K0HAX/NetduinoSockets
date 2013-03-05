using System;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware.NetduinoPlus;

namespace TCPsocketApp
{
    class CommandParser
    {
        private OutputPort led;
        public CommandParser(OutputPort led)
        {
            this.led = led;
        }

        public string Parse(string command)
        {
            string returnvalue;
            switch (command)
            {
                case "h":
                    returnvalue = "No help yet";
                    break;
                case "l1on":
                    returnvalue = "LED 1 On";
                    led.Write(true);
                    break;
                case "l1off":
                    returnvalue = "LED 1 Off";
                    led.Write(false);
                    break;
                default:
                    returnvalue = "Invalid command, type \"h\" for help.";
                    break;
            }
            return returnvalue;
        }
    }
}
