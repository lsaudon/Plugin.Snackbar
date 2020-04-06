using System.Windows.Input;

namespace Plugin.Snackbars
{
    public interface ISnackbar
    {
        /// <summary>
        /// Make a Snackbar to display a message
        /// </summary>
        /// <param name="text">The text to show.</param>
        /// <param name="duration">How long to display the message in milliseconds.</param>
        /// <returns></returns>
        ISnackbar Make(string text, int duration);

        /// <summary>
        /// Set the action to be displayed
        /// </summary>
        /// <param name="text">Text to display for the action.</param>
        /// <param name="command">Command to be invoked when the action is clicked.</param>
        /// <returns></returns>
        ISnackbar SetAction(string text, ICommand command);

        /// <summary>
        /// Sets the text color of the action specified
        /// </summary>
        /// <param name="colorHex">Color to action text in hexadecimal.</param>
        /// <returns></returns>
        ISnackbar SetActionTextColor(string colorHex);

        /// <summary>
        /// Show Snackbar
        /// </summary>
        void Show();
    }
}
