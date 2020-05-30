using FootballManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FootballManager
{
    /// <summary>
    /// Interaction logic for SecondTeamWindow.xaml
    /// </summary>
    public partial class SecondTeamWindow : Window
    {
        SecondTeamDbContext context;
        SecondTeamPlayer NewPlayer = new SecondTeamPlayer();
        SecondTeamPlayer selectedPlayer = new SecondTeamPlayer();

        public SecondTeamWindow()
        {
        }

        public SecondTeamWindow(SecondTeamDbContext context)
        {
            this.context = context;
            InitializeComponent();
            GetPlayers();
            NewTeamGrid.DataContext = NewPlayer;
        }

        private void GetPlayers()
        {
            TeamDG.ItemsSource = context.Players.ToList();
        }

        private void AddPlayer(object s, RoutedEventArgs e)
        {
            context.Players.Add(NewPlayer);
            context.SaveChanges();
            GetPlayers();
            NewPlayer = new SecondTeamPlayer();
            NewTeamGrid.DataContext = NewPlayer;
        }

        private void UpdateInfo(object s, RoutedEventArgs e)
        {
            context.Update(selectedPlayer);
            context.SaveChanges();
            GetPlayers();
        }

        private void SelectPlayerToEdit(object s, RoutedEventArgs e)
        {
            selectedPlayer = (s as FrameworkElement).DataContext as SecondTeamPlayer;
            UpdateTeamGrid.DataContext = selectedPlayer;
        }

        private void Delete(object s, RoutedEventArgs e)
        {
            var playertToDelete = (s as FrameworkElement).DataContext as SecondTeamPlayer;
            context.Players.Remove(playertToDelete);
            context.SaveChanges();
            GetPlayers();
        }
    }
}
