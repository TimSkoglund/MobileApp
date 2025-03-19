using CommunityToolkit.Mvvm.ComponentModel;


namespace MobileApp.ViewModels;

public partial class GetStartedViewModel : ObservableObject
{
    [ObservableProperty]
    private string _title = "GetStarted";
}
