using System.Windows.Input;
using Foundation;

namespace Plugin.Snackbars
{
    [Preserve(AllMembers = true)]
    public class SnackbarImplementation : ISnackbar
    {
        public ISnackbar Make(string text, int duration)
        {
            throw new System.NotImplementedException();
        }

        public ISnackbar SetAction(string text, ICommand command)
        {
            throw new System.NotImplementedException();
        }

        public ISnackbar SetActionTextColor(string colorHex)
        {
            throw new System.NotImplementedException();
        }

        public void Show()
        {
            throw new System.NotImplementedException();
        }
    }
}
