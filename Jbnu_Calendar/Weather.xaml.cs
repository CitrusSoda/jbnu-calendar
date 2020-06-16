using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
using System.Xml;

namespace Jbnu_Calendar
{
    /// <summary>
    /// Weather.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Weather : UserControl
    {
        string responseFromServer;
        private string url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4511357000";  // 호출할 url
        public Weather()
        {
            InitializeComponent();
            WebRequest request = WebRequest.Create(url);  // url 저장
            request.Method = "GET";

            WebResponse response = request.GetResponse();  // get방식으로 요청을 보내고 응답을 response에 저장
            Stream dataStream = response.GetResponseStream();  // 응답에서 stream값으로 변환
            StreamReader reader = new StreamReader(dataStream);  // 스트림 읽는 reader
            String strRead = reader.ReadToEnd();  // 처음부터 끝까지 스트림 읽어서 String으로 저장

            XmlDocument doc = new XmlDocument();  // Xml 객체 doc
            doc.LoadXml(strRead);  // doc로 스트림 읽기


            day.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");  // 현재 날짜 및 시간 출력

            string weatherContent;  // 날씨에 대한 정보
            string[] whatNumber = new string[6];// rss 에서 받아온 날짜 숫자를 저장할 배열. 0은 오늘 1은 내일 2는 모레
            string[] date = new string[6];  // 오늘 내일 모레 저장할 배열
            int j = 0;
            string[] emoticon = new string[6];  // 이모티콘 저장할 배열

            // 날짜 숫자를 오늘, 내일, 모레로 바꾸는 반복문
            for (int i = 2; i <= 14; i += 2)
            {
                if (i == 8) continue;
                whatNumber[j] = doc.GetElementsByTagName("day")[i].InnerText;
                emoticon[j] = doc.GetElementsByTagName("wfKor")[i].InnerText;

                if (whatNumber[j] == "0") date[j] = "오늘";
                else if (whatNumber[j] == "1") date[j] = "내일";
                else date[j] = "모레";
                j++;
            }

            // 날씨를 받아서 이모티콘으로 바꿈
            if (emoticon[0] == "구름 많음" || emoticon[0] == "흐림") emoji1.Kind = PackIconKind.WeatherCloudy;
            else if (emoticon[0] == "비") emoji1.Kind = PackIconKind.WeatherRainy;
            else if (emoticon[0] == "눈") emoji1.Kind = PackIconKind.WeatherSnowy;

            if (emoticon[1] == "구름 많음" || emoticon[1] == "흐림") emoji2.Kind = PackIconKind.WeatherCloudy;
            else if (emoticon[1] == "비") emoji2.Kind = PackIconKind.WeatherRainy;
            else if (emoticon[1] == "눈") emoji2.Kind = PackIconKind.WeatherSnowy;

            if (emoticon[2] == "구름 많음" || emoticon[2] == "흐림") emoji3.Kind = PackIconKind.WeatherCloudy;
            else if (emoticon[2] == "비") emoji3.Kind = PackIconKind.WeatherRainy;
            else if (emoticon[2] == "눈") emoji3.Kind = PackIconKind.WeatherSnowy;

            if (emoticon[3] == "구름 많음" || emoticon[3] == "흐림") emoji4.Kind = PackIconKind.WeatherCloudy;
            else if (emoticon[3] == "비") emoji4.Kind = PackIconKind.WeatherRainy;
            else if (emoticon[3] == "눈") emoji4.Kind = PackIconKind.WeatherSnowy;

            if (emoticon[4] == "구름 많음" || emoticon[4] == "흐림") emoji5.Kind = PackIconKind.WeatherCloudy;
            else if (emoticon[4] == "비") emoji5.Kind = PackIconKind.WeatherRainy;
            else if (emoticon[4] == "눈") emoji5.Kind = PackIconKind.WeatherSnowy;

            if (emoticon[5] == "구름 많음" || emoticon[5] == "흐림") emoji6.Kind = PackIconKind.WeatherCloudy;
            else if (emoticon[5] == "비") emoji6.Kind = PackIconKind.WeatherRainy;
            else if (emoticon[5] == "눈") emoji6.Kind = PackIconKind.WeatherSnowy;

            // weatherContent에 날씨 정보를 저장하고 textbox로 출력
            weatherContent = date[0] + (" ") + doc.GetElementsByTagName("hour")[2].InnerText + ("시\n") +
                             doc.GetElementsByTagName("wfKor")[2].InnerText + ("\n") +
                             doc.GetElementsByTagName("tmn")[2].InnerText + (" / ") + doc.GetElementsByTagName("tmx")[2].InnerText;
            today09.Text = weatherContent;

            weatherContent = date[1] + (" ") + doc.GetElementsByTagName("hour")[4].InnerText + ("시\n") +
                             doc.GetElementsByTagName("wfKor")[4].InnerText + ("\n") +
                             doc.GetElementsByTagName("tmn")[4].InnerText + (" / ") + doc.GetElementsByTagName("tmx")[4].InnerText;
            today15.Text = weatherContent;

            weatherContent = date[2] + (" ") + doc.GetElementsByTagName("hour")[6].InnerText + ("시\n") +
                             doc.GetElementsByTagName("wfKor")[6].InnerText + ("\n") +
                             doc.GetElementsByTagName("tmn")[6].InnerText + (" / ") + doc.GetElementsByTagName("tmx")[6].InnerText;
            today21.Text = weatherContent;

            weatherContent = date[3] + (" ") + doc.GetElementsByTagName("hour")[10].InnerText + ("시\n") +
                             doc.GetElementsByTagName("wfKor")[10].InnerText + ("\n") +
                             doc.GetElementsByTagName("tmn")[10].InnerText + (" / ") + doc.GetElementsByTagName("tmx")[10].InnerText;
            tomorr09.Text = weatherContent;

            weatherContent = date[4] + (" ") + doc.GetElementsByTagName("hour")[12].InnerText + ("시\n") +
                             doc.GetElementsByTagName("wfKor")[12].InnerText + ("\n") +
                             doc.GetElementsByTagName("tmn")[12].InnerText + (" / ") + doc.GetElementsByTagName("tmx")[12].InnerText;
            tomorr15.Text = weatherContent;

            weatherContent = date[5] + (" ") + doc.GetElementsByTagName("hour")[14].InnerText + ("시\n") +
                             doc.GetElementsByTagName("wfKor")[14].InnerText + ("\n") +
                             doc.GetElementsByTagName("tmn")[14].InnerText + (" / ") + doc.GetElementsByTagName("tmx")[14].InnerText;
            tomorr21.Text = weatherContent;


            responseFromServer = reader.ReadToEnd();

            reader.Close();
            dataStream.Close();
            response.Close();
        }
    }
}
