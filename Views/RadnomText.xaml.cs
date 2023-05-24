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

namespace MVVM
{
    /// <summary>
    /// Логика взаимодействия для RadnomText.xaml
    /// </summary>
    public partial class RadnomText : Window
    {
        public RadnomText()
        {
            InitializeComponent();
            DataContext = new VeiwModels.RandTextViewModel();
        }
    }
}
