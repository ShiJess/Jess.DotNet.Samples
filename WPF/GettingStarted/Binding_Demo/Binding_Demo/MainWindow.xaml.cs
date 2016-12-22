using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace Binding_Demo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.templatebinding.Text = "模板绑定";

            ForDataBinding data = new ForDataBinding();
            data.Count = 10;
            this.fordatabinding.DataContext = data;

            this.simpleconvert.DataContext = new SimpleDataConvert();

            this.forvalidate.DataContext = new ForExceptionValidate();
        }

    }

    class ForDataBinding
    {
        public int Count { get; set; }
    }

    class SimpleDataConvert
    {
        public DateTime Date { get; set; } = DateTime.Now;
        public float Price { get; set; } = 100.123456f;
    }

    class DateConverter : IValueConverter
    {
        /// <summary>
        /// 数据源转界面显示
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.GetType() == typeof(System.DateTime))
            {
                return ((System.DateTime)value).ToString("yyyyMMdd");
            }
            else
            {
                return value;
            }
        }

        /// <summary>
        /// 界面显示转数据源
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType == typeof(System.DateTime) && value != null)
            {
                DateTime dt = DateTime.Now;
                string valuestr = value.ToString();
                if (DateTime.TryParse(valuestr, out dt))
                {
                    return dt;
                }
                else if (valuestr.Length == 8)
                {
                    string yearstr = valuestr.Substring(0, 4);
                    string monthstr = valuestr.Substring(4, 2);
                    string daystr = valuestr.Substring(6, 2);
                    if (DateTime.TryParse(string.Format("{0}-{1}-{2}", yearstr, monthstr, daystr), out dt))
                    {
                        return dt;
                    }
                }
            }
            return value;
        }
    }


    class ForExceptionValidate
    {
        private int max;
        public int Max
        {
            get { return max; }
            set
            {
                if (value > 100)
                {
                    throw new Exception("Max不能超过100");
                }
                max = value;
            }
        }
    }

}
