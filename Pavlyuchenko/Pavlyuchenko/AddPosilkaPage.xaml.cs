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
    /// Логика взаимодействия для AddPosilkaPage.xaml
    /// </summary>
    public partial class AddPosilkaPage : Page
    {
        private Посылки посылка = null;

        public AddPosilkaPage(Посылки посылка)
        {
            InitializeComponent();

            this.посылка = посылка;

            DataContext = посылка;
        }

        private void ClenBtn_Click(object sender, RoutedEventArgs e)
        {
            MenegerFrame.Frame.GoBack();
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (посылка.КодПосылки == 0)
                {
                    ПавлюченкоEntities.Get().Посылки.Add(посылка);
                    ПавлюченкоEntities.Get().SaveChanges();
                }
                else
                {
                    var z = ПавлюченкоEntities.Get().Посылки.Find(посылка.КодПосылки);
                    z = посылка;
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
