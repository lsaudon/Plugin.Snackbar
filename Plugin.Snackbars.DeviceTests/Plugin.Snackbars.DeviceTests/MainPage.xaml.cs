using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace Plugin.Snackbars.DeviceTests
{
    [DesignTimeVisible(false)]
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button5_OnClicked(object sender, EventArgs e)
        {
            CrossSnackbar.Current
                .Make("Message5", 1000)
                .SetAction("Ok", new Command(Execute))
                .SetActionTextColor(Color.Blue.ToHex())
                .Show();
        }

        private void Execute()
        {
            CrossSnackbar.Current
                .Make("Message 1",2000)
                .Show();
        }
    }
}
