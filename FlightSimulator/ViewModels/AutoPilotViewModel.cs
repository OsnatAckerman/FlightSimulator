using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulator.ViewModels
{
    class AutoPilotViewModel : BaseNotify
    {
        private string color = "White";
        private bool isWrite = false;
        private string content = "";

        public string BackgroundColor
        {
            get {
                if (content != "")
                {
                    return "Pink";
                } else
                {
                    return "White";
                }
            }
        }

        public string Content
        {
            get
            {
                return content;
            }

            set
            {
                content = value;
                NotifyPropertyChanged("Content");
            }
        }

    }
}
