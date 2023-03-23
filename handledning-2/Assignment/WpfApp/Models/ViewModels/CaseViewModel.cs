using CommunityToolkit.Mvvm.ComponentModel;
using WpfApp.Services;

namespace WpfApp.Models.ViewModels;

internal partial class CaseViewModel : ObservableObject
{
    private readonly NavigationStore _navigationStore;

    public CaseViewModel(int id, NavigationStore navigationStore)
    {
        _navigationStore = navigationStore;
    }
}
