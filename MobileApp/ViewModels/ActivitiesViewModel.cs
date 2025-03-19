using CommunityToolkit.Mvvm.ComponentModel;


namespace MobileApp.ViewModels;

public partial class ActivitiesViewModel : ObservableObject
{
    [ObservableProperty]
    private string _title = "Activities";
}
