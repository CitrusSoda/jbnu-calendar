using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Jbnu_Calendar
{
    /// <summary>
    /// Calendar.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Calendar : UserControl
    {
        wpfCrudEntities _db = new wpfCrudEntities();
        public Calendar()
        {
            InitializeComponent();
            calendar.SelectedDate = DateTime.Today;
        }
        // 캘린더의 선택된 날짜가 변경될 때마다 텍스트박스 변경
        private void calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            year.Text = calendar.SelectedDate.Value.ToString("yyyy년");
            month.Text = calendar.SelectedDate.Value.ToString("MM월");
            day.Text = calendar.SelectedDate.Value.ToString("dd일");
        }
        // 데이터를 이용해서 일정 추가
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 데이터 테이블에 추가
            schedule newMember = new schedule()
            {
                schedule1 = plan.Text,
                date = calendar.SelectedDate.Value.ToString("yyyy년 MM월 dd일")
            };

            _db.schedule.Add(newMember);
            _db.SaveChanges();
            CalendarList.datagrid.ItemsSource = _db.schedule.ToList();
            plan.Text = "";
        }
    }
}
