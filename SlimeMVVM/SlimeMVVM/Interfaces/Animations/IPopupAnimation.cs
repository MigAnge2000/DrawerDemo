using SlimeMVVM.Pages;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SlimeMVVM.Interfaces.Animations
{
    public interface IPopupAnimation
    {
        void Preparing(View content, PopupPage page);
        void Disposing(View content, PopupPage page);
        Task Appearing(View content, PopupPage page);
        Task Disappearing(View content, PopupPage page);
    }
}
