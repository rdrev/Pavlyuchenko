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

namespace Pavlyuchenko
{
    /// <summary>
    /// Логика взаимодействия для AddUserPage.xaml
    /// </summary>
    public partial class AddUserPage : Page
    {
        private Пользователи пользовател = null;

        public AddUserPage(Пользователи пользовател)
        {
            InitializeComponent();

            this.пользовател = пользовател;

            DataContext = пользовател;

            CBR.ItemsSource = ПавлюченкоEntities.Get().Роли.ToList();
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (пользовател.КодПользователя == 0)
                {
                    ПавлюченкоEntities.Get().Пользователи.Add(пользовател);
                    ПавлюченкоEntities.Get().SaveChanges();
                }
                else
                {
                    var z = ПавлюченкоEntities.Get().Пользователи.Find(пользовател.КодПользователя);
                    z = пользовател;
                    ПавлюченкоEntities.Get().SaveChanges();
                }
                MenegerFrame.Frame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClenBtn_Click(object sender, RoutedEventArgs e)
        {
            MenegerFrame.Frame.GoBack();
        }
    }
}
