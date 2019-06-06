using Windows.UI.Xaml.Controls;

namespace UwpBindBackSample
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private string _yesNoString;
        public string YesNoString
        {
            get => _yesNoString;
            set
            {
                if (_yesNoString != value)
                {
                    _yesNoString = value;
                    this.Bindings.Update();
                }
            }
        }

        public bool GetYesNoValue()
        {
            return YesNoString == "yes";
        }

        public void SetYesNoValue(bool? val)
        {
            YesNoString = val == true ? "yes" : "no";
        }
    }
}
