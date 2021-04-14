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
    /// Логика взаимодействия для AddZakPage.xaml
    /// </summary>
    public partial class AddZakPage : Page
    {
        private Заказы заказ = null;

        public AddZakPage(Заказы заказ, Пользователи пользовател)
        {
            InitializeComponent();

            this.заказ = заказ;

            DataContext = this.заказ;

            CBK.ItemsSource = ПавлюченкоEntities.Get().Клиенты.ToList().Where(p=> p.Пользователи.Роль == 1).ToList();
            CBP.ItemsSource = ПавлюченкоEntities.Get().Посылки.ToList();

            if(пользовател.Роль == 1)
            {
                CBK.Visibility = Visibility.Hidden;
                TBK.Visibility = Visibility.Hidden;
            }    
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(заказ.КодЗаказа == 0)
                {
                    ПавлюченкоEntities.Get().Заказы.Add(заказ);
                    ПавлюченкоEntities.Get().SaveChanges();
                }   
                else
                {
                    var z = ПавлюченкоEntities.Get().Заказы.Find(заказ.КодЗаказа);
                    z = заказ;
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
