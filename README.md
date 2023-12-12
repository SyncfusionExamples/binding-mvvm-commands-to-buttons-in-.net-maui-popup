# binding-mvvm-commands-to-buttons-in-.net-maui-popup
This example demonstrates about how to bind the Commands for the Accept and Decline button in .NET MAUI Popup (SfPopup).

In .NET MAUI Popup, you have the ability to include footer buttons that users can interact with. This article demonstrates how to handle the click events of the accept and decline buttons in the footer area of the SfPopup by using custom commands.

## Implementing Custom Commands

To handle the actions of the accept and decline buttons, you can create custom commands by implementing the ICommand interface. Below is an example of how to create custom commands for both accept and decline buttons:

```csharp
public class AcceptButtonCustomCommand : ICommand
{
    public event EventHandler CanExecuteChanged;

    public bool CanExecute(object parameter)
    {
        return true; // The command can always execute
    }

    public void Execute(object parameter)
    {
        // Implement the action to be performed on accept button click
    }
}

public class DeclineButtonCustomCommand : ICommand
{
    public event EventHandler CanExecuteChanged;

    public bool CanExecute(object parameter)
    {
        return true; // The command can always execute
    }

    public void Execute(object parameter)
    {
        // Implement the action to be performed on decline button click
    }
}
```

## Assigning Custom Commands to Footer Buttons

Once you have defined your custom commands, you can assign them to the accept and decline buttons of the SfPopup as shown below:

```csharp
popup = bindable.FindByName<SfPopup>("popup");
acceptCommand = new AcceptButtonCustomCommand();
declineCommand = new DeclineButtonCustomCommand();
popup.AcceptCommand = acceptCommand;
popup.DeclineCommand = declineCommand;
```

## Conclusion

I hope you enjoyed learning about How to bind MVVM Commands in footer buttons in .NET MAUI Popup (SfPopup).
You can refer to our .NET MAUI Popup feature tour page to know about its other groundbreaking feature representations and documentation, and how to quickly get started for configuration specifications. You can also explore our .NET MAUI SfPopup example to understand how to create and present data. For current customers, you can check out our components from the License and Downloads page. If you are new to Syncfusion, you can try our 30-day free trial to check out our other controls.
If you have any queries or require clarifications, please let us know in the comments section below. You can also contact us through our support forums, Direct-Trac, or feedback portal. We are always happy to assist you!