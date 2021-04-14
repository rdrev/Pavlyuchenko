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
    /// Логика взаимодействия для AddKlientPage.xaml
    /// </summary>
    public partial class AddKlientPage : Page
    {
        private Клиенты клиент = null;

        public AddKlientPage(Клиенты клиент)
        {
            InitializeComponent();

            this.клиент = клиент;

            DataContext = клиент;

            CBP.ItemsSource = ПавлюченкоEntities.Get().Пользователи.ToList();
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (клиент.КодКлиент == 0)
                {
                    ПавлюченкоEntities.Get().Клиенты.Add(клиент);
                    ПавлюченкоEntities.Get().SaveChanges();
                }
                else
                {
                    var z = ПавлюченкоEntities.Get().Клиенты.Find(клиент.КодКлиент);
                    z = клиент;
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
