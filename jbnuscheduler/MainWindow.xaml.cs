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
    public partial class MainWindow : Window
    {
        // 사이즈 변경
        double orginalWidth, originalHeight;
        ScaleTransform scale = new ScaleTransform();

        // 사이즈 변경
        void Window1_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ChangeSize(e.NewSize.Width, e.NewSize.Height);
        }

        // 사이즈 변경
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

        // 사이즈 변경
        private void ChangeSize(double width, double height)

        {
            scale.ScaleX = width / orginalWidth;
            scale.ScaleY = height / originalHeight;

            FrameworkElement rootElement = this.Content as FrameworkElement;
            rootElement.LayoutTransform = scale;
        }

        public MainWindow()
        {
            InitializeComponent();
            // 사이즈 변경
            this.Loaded += new RoutedEventHandler(Window1_Loaded);
        }

        // 캘린더기능창 띄우기
        private void Open_Calendar(object sender, RoutedEventArgs e)
        {
            Window Calendar = new Calendar();
            Calendar.Show();
        }

        // 전북대학교 홈페이지 공지사항
        private void Jbnu_Click(object sender, RoutedEventArgs e)
        {
            Uri jbnuurl = new Uri("https://www.jbnu.ac.kr/kor/?menuID=139");
            browser.Source = jbnuurl;
        }

        // 컴퓨터공학부 공지사항
        private void Computer_Click(object sender, RoutedEventArgs e)
        {
            Uri compurl = new Uri("https://cse.jbnu.ac.kr/cse/3586/subview.do?enc=Zm5jdDF8QEB8JTJGYmJzJTJGY3NlJTJGNTM4JTJGYXJ0Y2xMaXN0LmRvJTNG");
            browser.Source = compurl;
        }

        // 뒤로가기
        private void Goback(object sender, RoutedEventArgs e)
        {
            browser.GoBack();
        }
    }
}
