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
using System.Windows.Shapes;
using Test.ClassHelper;

namespace Test
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            GetList();
        }

        private void GetList()
        {
            User.ItemsSource = ClassHelper.EF.Context.Client.ToList();
        }

        private void TbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TbSearch.Text == null)
            {

            }
            else
            {
                User.ItemsSource = EF.Context.Client.Where(i => i.LastName.Contains(TbSearch.Text)).ToList();
            }
        }
    }
}
