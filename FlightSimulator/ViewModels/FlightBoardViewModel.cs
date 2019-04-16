using FlightSimulator.Model;
using FlightSimulator.Model.Interface;
using FlightSimulator.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FlightSimulator.ViewModels
{
    public class FlightBoardViewModel : BaseNotify
    {
     
        public double Lon
        {
            get;
        }

        public double Lat
        {
            get;
        }

        #region CommandSettings
        private ICommand _settingsCommand;
        public ICommand SettingsCommand
        {
            get
            {
                return _settingsCommand ?? (_settingsCommand = new CommandHandler(() => OnClick()));
            }
        }
        private void OnClick()
        {
            var settingWin = new Settings();
            settingWin.Show();
        }
        #endregion
    }
}
