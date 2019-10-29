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

namespace CherkashinProject.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAllUser.xaml
    /// </summary>
    public partial class PageAllUser : Page
    {
        public PageAllUser()
        {
            InitializeComponent();
            List<Entity.Users> users = AppData.Context.Users.ToList();
            DataGridAllUser.ItemsSource = users;
        }
    }
}
