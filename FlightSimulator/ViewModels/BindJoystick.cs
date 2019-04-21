using FlightSimulator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulator.ViewModels
{
    class BindJoystick
    {
        public float ThrottleCommand
        {
            set
            {
                string throttleLine = "set controls/engines/current-engine/throttle " + value + "\r\n";
                ConnectCommand.Instance.Send(throttleLine);
            }
        }

        public float RudderCommand
        {
            set
            {
                string rudderLine = "set controls/flight/rudder " + value + "\r\n";
                ConnectCommand.Instance.Send(rudderLine);
            }
        }

        public float ElevatorCommand
        {
            set
            {
                string ElevatorLine = "set /controls/flight/elevator " + value + "\r\n";
                ConnectCommand.Instance.Send(ElevatorLine);
            }
        }

        public float AileronCommand
        {
            set
            {
                string AileronLine = "set /controls/flight/aileron " + value + "\r\n";
                ConnectCommand.Instance.Send(AileronLine);
            }
        }


    }
}
