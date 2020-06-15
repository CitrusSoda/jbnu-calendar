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
    /// CalendarList.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class CalendarList : UserControl
    {
        wpfCrudEntities _db = new wpfCrudEntities();
        public static DataGrid datagrid;
        public CalendarList()
        {
            InitializeComponent();
            Load();
        }
        // 데이터를 그리드에 추가
        private void Load()
        {
            myDataGrid.ItemsSource = _db.schedule.ToList();
            datagrid = myDataGrid;
        }
        // 데이터를 삭제하여 데이터그리드에서도 보이지 않게 된다
        private void delete(object sender, RoutedEventArgs e)
        {
            int Id = (myDataGrid.SelectedItem as schedule).id;
            var deleteMember = _db.schedule.Where(m => m.id == Id).Single();
            _db.schedule.Remove(deleteMember);
            _db.SaveChanges();
            myDataGrid.ItemsSource = _db.schedule.ToList();
        }
    }
}
