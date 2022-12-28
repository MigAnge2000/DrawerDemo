using SlimeMVVM.Pages;
using System;
using System.Threading.Tasks;

namespace SlimeMVVM.Contracts
{
    public interface IPopupPlatform
    {
        event EventHandler OnInitialized;

        bool IsInitialized { get; }

        bool IsSystemAnimationEnabled { get; }

        Task AddAsync(PopupPage page);

        Task RemoveAsync(PopupPage page);
    }
}
