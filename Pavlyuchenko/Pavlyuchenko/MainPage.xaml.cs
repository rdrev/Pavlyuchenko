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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        private Пользователи пользовател = null;

        public MainPage(Пользователи пользовател)
        {
            InitializeComponent();

            this.пользовател = пользовател;

            if (пользовател.Роль == 1)//aдаптирование интерфейс под клиента
            {
                ChB1.Visibility = Visibility.Hidden;
                UpTel.Visibility = Visibility.Hidden;
                DelTel.Visibility = Visibility.Hidden;
                UserLookBtn.Visibility = Visibility.Hidden;
                klientLookBtn.Visibility = Visibility.Hidden;
                TranspLookBtn.Visibility = Visibility.Hidden;
                PosilkaLookBtn.Visibility = Visibility.Hidden;
            }
            if (пользовател.Роль == 2)//aдаптирование интерфейс под логиста
            {
                ChB0.Visibility = Visibility.Hidden;
                UserLookBtn.Visibility = Visibility.Hidden;
                klientLookBtn.Visibility = Visibility.Hidden;
                TranspLookBtn.Visibility = Visibility.Hidden;
                PosilkaLookBtn.Visibility = Visibility.Hidden;
            }
            if (пользовател.Роль == 3)//aдаптирование интерфейс под водителя
            {
                ChB1.Visibility = Visibility.Hidden;
                UpTel.Visibility = Visibility.Hidden;
                DelTel.Visibility = Visibility.Hidden;
                UserLookBtn.Visibility = Visibility.Hidden;
                klientLookBtn.Visibility = Visibility.Hidden;
                TranspLookBtn.Visibility = Visibility.Hidden;
                PosilkaLookBtn.Visibility = Visibility.Hidden;
            }
            if (пользовател.Роль == 4)//aдаптирование интерфейс под администратора
            {
                ChB1.Visibility = Visibility.Hidden;
            }
        }

        private void AddZakBtn_Click(object sender, RoutedEventArgs e)
        {
            MenegerFrame.Frame.Navigate(new AddZakPage(new Заказы(), пользовател));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            updata();
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            var el = (sender as CheckBox).DataContext as Заказы;
            if ((sender as CheckBox).IsChecked == true)
                el.Утверждено = true;
            else if ((sender as CheckBox).IsChecked == false)
                el.Утверждено = false;
            ПавлюченкоEntities.Get().SaveChanges();
        }

        private void UpBtn_Click(object sender, RoutedEventArgs e)
        {
            MenegerFrame.Frame.Navigate(new AddZakPage((sender as Button).DataContext as Заказы, пользовател));
        }

        private void MarsBtn_Click(object sender, RoutedEventArgs e)
        {
            MenegerFrame.Frame.Navigate(new MarsPage((sender as Button).DataContext as Заказы, пользовател));
        }

        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы дельствительно хотете удалить это", "Подверждение", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    ПавлюченкоEntities.Get().Заказы.Remove((sender as Button).DataContext as Заказы);
                    ПавлюченкоEntities.Get().SaveChanges();

                    updata();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updata()
        {
            if (пользовател.Роль == 1)//aдаптирование интерфейс под клиента
            {
                DG.ItemsSource = ПавлюченкоEntities.Get().Заказы.ToList().Where(p => p.Клиент == пользовател.КодПользователя);//вывод толька заказа клиента
            }
            if (пользовател.Роль == 2)//aдаптирование интерфейс под логиста
            {
                DG.ItemsSource = ПавлюченкоEntities.Get().Заказы.ToList();
            }
            if (пользовател.Роль == 3)//aдаптирование интерфейс под водителя
            {
                List<Заказы> spis = new List<Заказы>();

                foreach (var el in ПавлюченкоEntities.Get().Маршруты.ToList().Where(p => p.Транспорты.Водитель == пользовател.КодПользователя))//поиск заказыв где участвует водитель 
                {
                    spis.Add(el.Заказы);
                }

                DG.ItemsSource = spis.Distinct().ToList();
            }
            if (пользовател.Роль == 4)//aдаптирование интерфейс под администратора
            {
                DG.ItemsSource = ПавлюченкоEntities.Get().Заказы.ToList();
            }
        }

        private void PosilkaLookBtn_Click(object sender, RoutedEventArgs e)
        {
            MenegerFrame.Frame.Navigate(new PosilkaLookPage());
        }

        private void TranspLookBtn_Click(object sender, RoutedEventArgs e)
        {
            MenegerFrame.Frame.Navigate(new TranspLookPage());
        }

        private void klientLookBtn_Click(object sender, RoutedEventArgs e)
        {
            MenegerFrame.Frame.Navigate(new KlientLookPage());
        }

        private void UserLookBtn_Click(object sender, RoutedEventArgs e)
        {
            MenegerFrame.Frame.Navigate(new UserLookPage());
        }
    }
}
