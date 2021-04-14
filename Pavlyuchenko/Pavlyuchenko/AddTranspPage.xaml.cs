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
    /// Логика взаимодействия для AddTranspPage.xaml
    /// </summary>
    public partial class AddTranspPage : Page
    {
        private Транспорты транспорт = null;

        public AddTranspPage(Транспорты транспорт)
        {
            InitializeComponent();

            this.транспорт = транспорт;

            DataContext = транспорт;

            CBP.ItemsSource = ПавлюченкоEntities.Get().Пользователи.ToList().Where(p=> p.Роль == 3).ToList();
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (транспорт.КодТранспорта == 0)
                {
                    ПавлюченкоEntities.Get().Транспорты.Add(транспорт);
                    ПавлюченкоEntities.Get().SaveChanges();
                }
                else
                {
                    var z = ПавлюченкоEntities.Get().Транспорты.Find(транспорт.КодТранспорта);
                    z = транспорт;
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
