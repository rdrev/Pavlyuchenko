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
    /// Логика взаимодействия для UserLookPage.xaml
    /// </summary>
    public partial class UserLookPage : Page
    {
        public UserLookPage()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            MenegerFrame.Frame.Navigate(new AddUserPage(new Пользователи()));
        }

        private void UpBtn_Click(object sender, RoutedEventArgs e)
        {
            MenegerFrame.Frame.Navigate(new AddUserPage((sender as Button).DataContext as Пользователи));
        }

        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы дельствительно хотете удалить это", "Подверждение", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    ПавлюченкоEntities.Get().Пользователи.Remove((sender as Button).DataContext as Пользователи);
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
            DG.ItemsSource = ПавлюченкоEntities.Get().Пользователи.ToList();
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            MenegerFrame.Frame.GoBack();
        }
    }
}
