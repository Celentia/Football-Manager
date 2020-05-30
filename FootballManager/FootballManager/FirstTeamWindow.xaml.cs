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
using System.Windows.Shapes;

namespace FootballManager
{
    /// <summary>
    /// Interaction logic for FirstTeamWindow.xaml
    /// </summary>
    public partial class FirstTeamWindow : Window
    {
        FirstTeamDbContext context;
        FirstTeamPlayer NewPlayer = new FirstTeamPlayer();
        FirstTeamPlayer selectedPlayer = new FirstTeamPlayer();

        public FirstTeamWindow()
        {
        }

        public FirstTeamWindow(FirstTeamDbContext context)
        {
            this.context = context;
            InitializeComponent();
            GetPlayers();
            NewPlayerGrid.DataContext = NewPlayer;
        }

        private void GetPlayers()
        {
            FirstTeamDG.ItemsSource = context.Players.ToList();
        }

        private void AddPlayer(object s, RoutedEventArgs e)
        {
            context.Players.Add(NewPlayer);
            context.SaveChanges();
            GetPlayers();
            NewPlayer = new FirstTeamPlayer();
            NewPlayerGrid.DataContext = NewPlayer;
        }

        private void UpdateInfo(object s, RoutedEventArgs e)
        {
            context.Update(selectedPlayer);
            context.SaveChanges();
            GetPlayers();
        }

        private void SelectPlayerToEdit(object s, RoutedEventArgs e)
        {
            selectedPlayer = (s as FrameworkElement).DataContext as FirstTeamPlayer;
            UpdatePlayerGrid.DataContext = selectedPlayer;
        }

        private void Delete(object s, RoutedEventArgs e)
        {
            var PlayerToDelete = (s as FrameworkElement).DataContext as FirstTeamPlayer;
            context.Players.Remove(PlayerToDelete);
            context.SaveChanges();
            GetPlayers();
        }
    }
}
