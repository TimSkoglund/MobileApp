using CommunityToolkit.Mvvm.ComponentModel;


namespace MobileApp.ViewModels;

public partial class AddActivityViewModel : ObservableObject
{
    [ObservableProperty]
    private string _title = "Add New Activity";
}