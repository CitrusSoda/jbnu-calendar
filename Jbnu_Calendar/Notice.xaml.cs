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

namespace Jbnu_Calendar
{
    /// <summary>
    /// Notice.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Notice : UserControl
    {
        public Notice()
        {
            InitializeComponent();
        }
        // 전북대학교 홈페이지 공지사항
        private void Jbnu_Click(object sender, RoutedEventArgs e)
        {
            Uri jbnuurl = new Uri("https://www.jbnu.ac.kr/kor/?menuID=139");
            browser.Source = jbnuurl;
        }
        // 전북대학교 홈페이지 코로나 공지사항
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Uri corona = new Uri("https://www.jbnu.ac.kr/kor/?menuID=452");
            browser.Source = corona;
        }
        // 컴퓨터공학부 홈페이지 공지사항
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Uri computer_s = new Uri("https://cse.jbnu.ac.kr/cse/3586/subview.do?enc=Zm5jdDF8QEB8JTJGYmJzJTJGY3NlJTJGNTM4JTJGYXJ0Y2xMaXN0LmRvJTNG");
            browser.Source = computer_s;
        }
    }
}
