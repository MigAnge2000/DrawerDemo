using SlimeMVVM.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace SlimeMVVM.Behaviors
{
    public class Trawling : Behavior<View>
    {
        public double Verticaltransition { get; set; }
        PanGestureRecognizer panGestureRecognizer = new PanGestureRecognizer();
        protected override void OnAttachedTo(View bindable)
        {
            panGestureRecognizer.PanUpdated += PanGestureRecognizer_PanUpdated;
            bindable.GestureRecognizers.Add(panGestureRecognizer);
            base.OnAttachedTo(bindable);
        }
        protected override void OnDetachingFrom(View bindable)
        {
            panGestureRecognizer.PanUpdated -= PanGestureRecognizer_PanUpdated;
            bindable.GestureRecognizers.Remove(panGestureRecognizer);
            base.OnDetachingFrom(bindable);
        }

        private async void PanGestureRecognizer_PanUpdated(object sender, PanUpdatedEventArgs e)
        {
            switch (e.StatusType)
            {
                case GestureStatus.Running:
                    if (e.TotalY > 0)
                    {
                        await ((View)sender).TranslateTo(0, e.TotalY);
                        Verticaltransition = e.TotalY;
                    }
                    break;
                case GestureStatus.Completed:
                    if (Verticaltransition > 100)
                    {
                        await ((View)sender).TranslateTo(0, 200);
                        if (PopupNavigation.Instance.PopupStack.Any())
                        {
                            await PopupNavigation.Instance.PopAsync();
                        }
                    }
                    else
                    {
                        await ((View)sender).TranslateTo(0, e.TotalY);
                    }
                    break;

            }
        
        }


    }
}