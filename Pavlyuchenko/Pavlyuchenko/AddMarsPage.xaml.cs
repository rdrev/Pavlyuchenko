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
    /// Логика взаимодействия для AddMarsPage.xaml
    /// </summary>
    public partial class AddMarsPage : Page
    {
        private Маршруты маршрут = null;

        public AddMarsPage(Маршруты маршрут, Заказы заказ)
        {
            InitializeComponent();

            this.маршрут = маршрут;

            this.маршрут.Заказ = заказ.КодЗаказа;

            CBT.ItemsSource = ПавлюченкоEntities.Get().Транспорты.ToList();

            DataContext = this.маршрут;
        }

        private void ClenBtn_Click(object sender, RoutedEventArgs e)
        {
            MenegerFrame.Frame.GoBack();
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (маршрут.КодМаршрута == 0)
                {
                    ПавлюченкоEntities.Get().Маршруты.Add(маршрут);
                    ПавлюченкоEntities.Get().SaveChanges();
                }
                else
                {
                    var z = ПавлюченкоEntities.Get().Маршруты.Find(маршрут.КодМаршрута);
                    z = маршрут;
                    ПавлюченкоEntities.Get().SaveChanges();
                }
                MenegerFrame.Frame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
