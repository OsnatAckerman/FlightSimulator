using FlightSimulator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FlightSimulator.ViewModels
{
    class AutoPilotViewModel : BaseNotify
    {
        private String content = "";

        public String BackgroundColor
        {
            get {
                if (content != "") { return "Pink"; }
                else { return "White"; }
            }
        }

        public String Content
        {
            get { return content; }

            set
            {
                content = value;
                NotifyPropertyChanged("Content");
                NotifyPropertyChanged("BackgroundColor");
            }
        }

        private ICommand clearCommand;
        public ICommand ClearCommand
        {
            get
            {
                return clearCommand ?? (clearCommand = new CommandHandler(() => OnClick()));
            }
        }
        private void OnClick()
        {
            content = "";
            NotifyPropertyChanged("Content");
            NotifyPropertyChanged("BackgroundColor");
        }
    }
}
