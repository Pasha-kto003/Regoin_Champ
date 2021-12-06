using Regoin_Champ.db;
using Regoin_Champ.mvvm;
using Regoin_Champ.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Threading;


namespace Regoin_Champ.ViewModels
{
   public class LaborantViewModel : BaseViewModel
   {
        Window window = new Window();
        DispatcherTimer _timer;
        TimeSpan _time;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private string time;
        public string Time
        {
            get => time;
            set
            {
                time = value;
                SignalChanged();
            }
        }

        public int Type { get; set; }

        public CustomCommand Exit { get; set; }

        public LaborantViewModel(Laborant laborant)
        {
            FirstName = laborant.FirstName;
            LastName = laborant.LastName;
            Type = laborant.Type;

            _time = TimeSpan.FromMinutes(16);

            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                Time = _time.ToString("c");
                if (_time == TimeSpan.Zero) _timer.Stop();
                if (_time == TimeSpan.FromMinutes(15))
                {
                    MessageWindow message = new MessageWindow("Осталось четверть часа");
                    message.Show();
                }
                _time = _time.Add(TimeSpan.FromSeconds(-1));
                SignalChanged("Time");

            }, Application.Current.Dispatcher);

            _timer.Start();

            
        }
       
    }
}
