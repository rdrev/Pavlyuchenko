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
    /// Логика взаимодействия для MarsPage.xaml
    /// </summary>
    public partial class MarsPage : Page
    {
        private Заказы заказ = null;
        private Пользователи пользовател = null;

        public MarsPage(Заказы заказ, Пользователи пользовател)
        {
            InitializeComponent();

            this.пользовател = пользовател;
            this.заказ = заказ;

            if (пользовател.Роль == 1)//aдаптирование интерфейс под клиента
            {
                ChB1.Visibility = Visibility.Hidden;
                UpTel.Visibility = Visibility.Hidden;
                DelTel.Visibility = Visibility.Hidden;
            }
            if (пользовател.Роль == 2)//aдаптирование интерфейс под логиста
            {
                ChB0.Visibility = Visibility.Hidden;
            }
            if (пользовател.Роль == 3)//aдаптирование интерфейс под водителя
            {
                ChB0.Visibility = Visibility.Hidden;
                UpTel.Visibility = Visibility.Hidden;
                DelTel.Visibility = Visibility.Hidden;
            }
            if (пользовател.Роль == 4)//aдаптирование интерфейс под администратора
            {
                ChB1.Visibility = Visibility.Hidden;
            }
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            var el = (sender as CheckBox).DataContext as Маршруты;
            if ((sender as CheckBox).IsChecked == true)
                el.Выполнено = true;
            else if ((sender as CheckBox).IsChecked == false)
                el.Выполнено = false;
            ПавлюченкоEntities.Get().SaveChanges();
        }

        private void updata()
        {
            DG.ItemsSource = ПавлюченкоEntities.Get().Маршруты.ToList().Where(p => p.Заказ == заказ.КодЗаказа).ToList();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            updata();
        }


        private void UpBtn_Click(object sender, RoutedEventArgs e)
        {
            MenegerFrame.Frame.Navigate(new AddMarsPage((sender as Button).DataContext as Маршруты, заказ));
        }

        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы дельствительно хотете удалить это", "Подверждение", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    ПавлюченкоEntities.Get().Маршруты.Remove((sender as Button).DataContext as Маршруты);
                    ПавлюченкоEntities.Get().SaveChanges();

                    updata();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddMarsBtn_Click(object sender, RoutedEventArgs e)
        {
            MenegerFrame.Frame.Navigate(new AddMarsPage(new Маршруты(), заказ));
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            MenegerFrame.Frame.GoBack();
        }
    }
}
