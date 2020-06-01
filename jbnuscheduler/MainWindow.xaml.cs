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

namespace jbnuscheduler
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        // 사이즈 변경
        double orginalWidth, originalHeight;
        ScaleTransform scale = new ScaleTransform();


        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(Window1_Loaded);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Uri jbnuurl = new Uri("https://www.jbnu.ac.kr/kor/?menuID=139");
            browser.Source = jbnuurl;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Uri compurl = new Uri("https://cse.jbnu.ac.kr/cse/3586/subview.do?enc=Zm5jdDF8QEB8JTJGYmJzJTJGY3NlJTJGNTM4JTJGYXJ0Y2xMaXN0LmRvJTNG");
            browser.Source = compurl;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            browser.GoBack();
        }

        void Window1_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ChangeSize(e.NewSize.Width, e.NewSize.Height);
        }

        void Window1_Loaded(object sender, RoutedEventArgs e)

        {
            orginalWidth = this.Width;
            originalHeight = this.Height;

            if (this.WindowState == WindowState.Maximized)
            {
                ChangeSize(this.ActualWidth, this.ActualHeight);
            }
            this.SizeChanged += new SizeChangedEventHandler(Window1_SizeChanged);

        }
        private void ChangeSize(double width, double height)

        {
            scale.ScaleX = width / orginalWidth;
            scale.ScaleY = height / originalHeight;

            FrameworkElement rootElement = this.Content as FrameworkElement;
            rootElement.LayoutTransform = scale;
        }

    }
}
