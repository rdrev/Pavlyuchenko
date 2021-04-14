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
    /// Логика взаимодействия для KlientLookPage.xaml
    /// </summary>
    public partial class KlientLookPage : Page
    {
        public KlientLookPage()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            MenegerFrame.Frame.Navigate(new AddKlientPage(new Клиенты()));
        }

        private void UpBtn_Click(object sender, RoutedEventArgs e)
        {
            MenegerFrame.Frame.Navigate(new AddKlientPage((sender as Button).DataContext as Клиенты));
        }

        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы дельствительно хотете удалить это", "Подверждение", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    ПавлюченкоEntities.Get().Клиенты.Remove((sender as Button).DataContext as Клиенты);
                    ПавлюченкоEntities.Get().SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            DG.ItemsSource = ПавлюченкоEntities.Get().Клиенты.ToList();
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            MenegerFrame.Frame.GoBack();
        }
    }
}
