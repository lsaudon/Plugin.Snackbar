using System.Windows.Input;
using Android.Graphics;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Views;
using Xamarin.Essentials;

namespace Plugin.Snackbars
{
    [Preserve(AllMembers = true)]
    public class SnackbarImplementation : ISnackbar
    {
        private Snackbar _snackbar { get; set; }

        /// <summary>
        /// Make a Snackbar to display a message
        /// </summary>
        /// <param name="text">The text to show.</param>
        /// <param name="duration">How long to display the message in milliseconds.</param>
        /// <returns></returns>
        public ISnackbar Make(string text, int duration)
        {
            var view = GetView();
            _snackbar = Snackbar.Make(view, text, duration);
            return this;
        }

        /// <summary>
        /// Set the action to be displayed
        /// </summary>
        /// <param name="text">Text to display for the action.</param>
        /// <param name="command">Command to be invoked when the action is clicked.</param>
        /// <returns></returns>
        public ISnackbar SetAction(string text, ICommand command)
        {
            _snackbar = _snackbar.SetAction(text, (view) => command.Execute(null));
            return this;
        }

        /// <summary>
        /// Sets the text color of the action specified
        /// </summary>
        /// <param name="colorHex">Color to action text in hexadecimal.</param>
        /// <returns></returns>
        public ISnackbar SetActionTextColor(string colorHex)
        {
            var color = Color.ParseColor(colorHex);
            _snackbar = _snackbar.SetActionTextColor(color);
            return this;
        }

        /// <summary>
        /// Show Snackbar
        /// </summary>
        public void Show()
        {
            _snackbar.Show();
        }

        private View GetView()
        {
            return Platform.CurrentActivity.FindViewById(Android.Resource.Id.Content);
        }
    }
}
