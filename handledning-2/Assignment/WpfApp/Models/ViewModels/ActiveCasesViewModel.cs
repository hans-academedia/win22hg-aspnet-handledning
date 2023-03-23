using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using WpfApp.Models.Entities;
using WpfApp.Services;

namespace WpfApp.Models.ViewModels;


internal partial class ActiveCasesViewModel : ObservableObject
{
    private readonly NavigationStore? _navigationStore;
    private readonly CaseService _caseService = new();

    public ActiveCasesViewModel(NavigationStore? navigationStore)
    {
        _navigationStore = navigationStore;
        GetActiveCases();
    }

    [ObservableProperty]
    private ObservableCollection<CaseEntity> activeCases = new();

    private void GetActiveCases()
    {
        var result = Task.Run(() => _caseService.GetAllAsync(x => x.StatusId != 3)).Result;
        if (result != null)
            foreach(var item in result)
                ActiveCases.Add(item);
    }

    [RelayCommand]
    public void NavigateToCase(object parameter)
    {
        _navigationStore!.CurrentViewModel = new CaseViewModel((int)parameter, _navigationStore);
    }
}
