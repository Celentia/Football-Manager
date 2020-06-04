using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Football_Manager_MVVM.ViewModels
{
    class PlayerViewModel : INotifyPropertyChanged, IDisposable
    {
        private readonly Player player;

        public PlayerViewModel(Player p)
        {
            player = p;
            player.PropertyChanged += Player_PropertyChanged;
        }

        void IDisposable.Dispose()
        {
            player.PropertyChanged -= Player_PropertyChanged;
        }

        private void Player_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            OnPropertyChanged(e.PropertyName);
        }

        public int Id
        {
            get { return player.id; }
            set
            {
                player.id = value;
                OnPropertyChanged("Id");
            }
        }
        public string FirstName
        {
            get { return player.firstName; }
            set
            {
                player.firstName = value;
                OnPropertyChanged("FirstName");
            }
        }
        public string LastName
        {
            get { return player.lastName; }
            set
            {
                player.lastName = value;
                OnPropertyChanged("LastName");
            }
        }
        public string Position
        {
            get { return player.position; }
            set
            {
                player.position = value;
                OnPropertyChanged("Position");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
