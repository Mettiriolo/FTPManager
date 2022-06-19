using MahApps.Metro.IconPacks;
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

namespace FTPManager.UserControls
{
    /// <summary>
    /// Menubutton.xaml 的交互逻辑
    /// </summary>
    public partial class Menubutton : UserControl
    {
        public Menubutton()
        {
            InitializeComponent();
        }
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon",typeof(PackIconMaterialKind),typeof(Menubutton));
        public PackIconMaterialKind Icon
        {
            get => (PackIconMaterialKind)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }
        public static readonly DependencyProperty IsActiveProperty =
           DependencyProperty.Register("IsActive", typeof(bool), typeof(Menubutton));
        public bool IsActive
        {
            get => (bool)GetValue(IsActiveProperty);
            set => SetValue(IconProperty, value);
        }
    }
}
