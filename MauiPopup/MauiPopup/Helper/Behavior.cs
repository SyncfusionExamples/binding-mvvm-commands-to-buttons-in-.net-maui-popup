using Syncfusion.Maui.Popup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiPopup
{
    internal class  PopupBehavior : Behavior<ContentPage>
    {
        Button? button;
        SfPopup? popup;
        AcceptButtonCustomCommand? acceptCommand;
        DeclineButtonCustomCommand? declineCommand;

        protected override void OnAttachedTo(ContentPage bindable)
        {
            button = bindable.FindByName<Button>("clickToShowPopup");
            popup = bindable.FindByName<SfPopup>("popup");

            acceptCommand = new AcceptButtonCustomCommand();
            declineCommand = new DeclineButtonCustomCommand();
            popup.AcceptCommand = acceptCommand;
            popup.DeclineCommand = declineCommand;
            button.Clicked += OnButtonClicked;
            base.OnAttachedTo(bindable);
        }

        private void OnButtonClicked(object? sender, EventArgs e)
        {
            popup!.Show();
        }

        protected override void OnDetachingFrom(ContentPage bindable)
        {
            button!.Clicked -= OnButtonClicked;
            base.OnDetachingFrom(bindable);
        }
    }
}
