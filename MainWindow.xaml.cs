using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using WpfProject1;

namespace WpfUkol {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private string cesta="";        
        private DataSet dataset;
        private static DayOfWeek day;
        private List<WeekendSales> weekendSales;
        private Microsoft.Win32.OpenFileDialog openFileDlg;
        public MainWindow() {
            InitializeComponent();
            weekendSales = new List<WeekendSales>();
            dataset = new DataSet();
            openFileDlg = new Microsoft.Win32.OpenFileDialog();
            openFileDlg.DefaultExt = ".xml";
            openFileDlg.InitialDirectory = @"C:\";
            openFileDlg.Multiselect = true;
            openFileDlg.Filter = "XML soubory|*.xml|All files|*.*";
        }

        private static bool isWeekend(string s) {
            try {
                day = DateTime.ParseExact(s, "d.M.yyyy", System.Globalization.CultureInfo.InvariantCulture).DayOfWeek;
                return ((day == DayOfWeek.Saturday) || (day == DayOfWeek.Sunday));
            }
            catch (ArgumentOutOfRangeException) { return false; }
            catch (FormatException) { return false;  }
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e) {
            bool? result = openFileDlg.ShowDialog();
            if (result==true) { cesta = openFileDlg.FileName; }
                  
            try {
                bool isXmlFile = new FileInfo(cesta).Extension == ".xml";
                if (isXmlFile) {
                    dataset.ReadXml(cesta);
                    DataGridData.ItemsSource = dataset.Tables[0].DefaultView;
                    this.lbLoad.Content = "XML file loaded";
                }
                else { this.lbLoad.Content = "Your XML file is probably bad"; cesta = ""; }
            }
            catch (XmlException) {
                this.lbLoad.Content = "Your XML file is probably bad";
            }
        }

        private void btnShow_Click(object sender, RoutedEventArgs e) {
            if (cesta != "") {
                XDocument doc = XDocument.Load(cesta);
                                           
                weekendSales = doc.Descendants("prodanyModel")
                        .Where(n => isWeekend(n.Element("datumProdeje").Value.ToString()))
                        .GroupBy(a => a.Element("nazevModelu").Value)
                        .Select(w => new WeekendSales {Model = w.Key.ToString(),                            
                            Suma = w.Sum(n => Math.Round(convertDouble(n.Element("cena").Value.ToString()),2)),
                            SumaDPH = w.Sum(n => Math.Round(convertDouble(n.Element("cena").Value.ToString()) + (convertDouble(n.Element("DPH").Value.ToString()) * convertDouble(n.Element("cena").Value.ToString())/100),2))})                        
                        .ToList();
                this.ListWiewResult.ItemsSource = weekendSales;
                this.DataGridData.ItemsSource = weekendSales;
            }
        }
        private static double convertDouble(string s) {
            double number = 0;
            bool b = double.TryParse(s.Replace(".", ","), out number);
            //if (!b) { warning = "Some data was wrong!"; } - pripadne varovani pro uzivatele v labelu
            return number;
        }
       
    }
}
