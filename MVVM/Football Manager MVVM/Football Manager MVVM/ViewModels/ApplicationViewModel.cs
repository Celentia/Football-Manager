using Football_Manager_MVVM.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Football_Manager_MVVM
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        //private Player selectedPlayer;
        private Player selectedPlayer { get; set; }

        public ObservableCollection<Player> Players { get; set; }

        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand(obj =>
                  {
                      Player player = new Player();
                      Players.Insert(0, player);
                      SelectedPlayer = player;

                      using (PlayersContext context = new PlayersContext())
                      {
                          context.Players.Add(SelectedPlayer);
                          context.SaveChanges();
                      }
                  }));
            }
        }

        private RelayCommand removeCommand;
        public RelayCommand RemoveCommand
        {
            get
            {
                return removeCommand ??
                  (removeCommand = new RelayCommand(obj =>
                  {
                      Player player = obj as Player;
                      if (player != null)
                      {
                          Players.Remove(player);
                      }
                  },
                 (obj) => SelectedPlayer != null));
            }
        }

        public Player SelectedPlayer
        {
            get { return selectedPlayer; }
            set
            {
                selectedPlayer = value;
                OnPropertyChanged("SelectedPlayer");
            }
        }
        public void Update()
        {
            using (PlayersContext context = new PlayersContext())
            {
                context.Entry(SelectedPlayer).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public ApplicationViewModel()
        {
            Players = new ObservableCollection<Player>
            {
                new Player { Id = 1, FirstName = "Nino", LastName = "Olivieri", Position = "Goalkeeper"},
                new Player { Id = 2, FirstName = "Matt", LastName = "Doe", Position = "Striker"},
                new Player { Id = 3, FirstName = "Scott", LastName = "Nelson", Position = "Full-backs"},
                new Player { Id = 4, FirstName = "Pike", LastName = "Red", Position = "Full-backs"},
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

