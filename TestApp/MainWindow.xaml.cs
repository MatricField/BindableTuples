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
using MatrixField.Bindable;
using MatrixField.Bindable.Collections;
using System.Collections.Specialized;

namespace TestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IDictionary<TestEnum, Bindable<bool>> _InternalData;
        private IDictionary<TestEnum, Bindable<bool>> InternalData
        {
            get => _InternalData;
            set
            {
                _InternalData = value;
                Data = _InternalData.AsBindable();
            }
        }
        public BindableCollection<KeyValuePair<TestEnum, Bindable<bool>>> Data { get; private set; }

        private TestEnum DefaultOption = TestEnum.Two;

        public MainWindow()
        {
            InternalData = ((TestEnum[])Enum.GetValues(typeof(TestEnum))).ToDictionary(x => x, _ => Bindable.Create(false));
            InternalData[DefaultOption].Item1 = true;
            InitializeComponent();
            Data.Add(new KeyValuePair<TestEnum, Bindable<bool>>((TestEnum)6, Bindable.Create(false)));
        }
    }
}
