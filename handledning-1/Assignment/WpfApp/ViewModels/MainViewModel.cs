using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WpfApp.Navigation;

namespace WpfApp.ViewModels;

internal partial class MainViewModel : ObservableObject
{
    private readonly NavigationStore _navigationStore;

    public string AppTitle { get; set; } = "WPF APP";
    public string NewCaseButtonContent { get; set; } = "Skapa ärende";

    public MainViewModel(NavigationStore navigationStore)
    {
        _navigationStore = navigationStore;
        _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
    }

    public ObservableObject CurrentViewModel => _navigationStore.CurrentViewModel;

    private void OnCurrentViewModelChanged()
    {
        OnPropertyChanged(nameof(CurrentViewModel));
    }

    [RelayCommand]
    public void NavigateToNewCase()
    {
        _navigationStore.CurrentViewModel = new NewCaseViewModel(_navigationStore);
    }
}
