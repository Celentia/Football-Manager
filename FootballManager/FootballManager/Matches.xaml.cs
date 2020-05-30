using FootballManager.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
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
    /// Interaction logic for Matches.xaml
    /// </summary>
    public partial class Matches : Window
    {
        private readonly ServiceProvider serviceProvider;
 
        public Matches() {
            ServiceCollection services = new ServiceCollection();
            services.AddDbContext<FirstTeamDbContext>(options =>
            {
                options.UseSqlite("Data Source = FirstTeam.db");
            });
            services.AddDbContext<SecondTeamDbContext>(options =>
            {
                options.UseSqlite("Data Source = SecondTeam.db");
            });
            services.AddSingleton<FirstTeamWindow>();
            services.AddSingleton<SecondTeamWindow>();
            serviceProvider = services.BuildServiceProvider();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FirstTeamWindow window1 = new FirstTeamWindow();
            window1 = serviceProvider.GetService<FirstTeamWindow>();
            window1.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SecondTeamWindow window2 = new SecondTeamWindow();
            window2 = serviceProvider.GetService<SecondTeamWindow>();
            window2.Show();
        }
    }
}
