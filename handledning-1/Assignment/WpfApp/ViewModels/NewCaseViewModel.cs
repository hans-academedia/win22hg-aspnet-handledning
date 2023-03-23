using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;
using WpfApp.Models.Entities;
using WpfApp.Navigation;
using WpfApp.Services;

namespace WpfApp.ViewModels;

internal partial class NewCaseViewModel : ObservableObject
{
    private readonly NavigationStore _navigationStore;
    private readonly CaseService _caseService = new CaseService();

    public NewCaseViewModel(NavigationStore navigationStore)
    {
        _navigationStore = navigationStore;
        CaseEntity = new CaseEntity
        {
            UserId = _navigationStore.UserId
        };
    }

    [ObservableProperty]
    private CaseEntity? caseEntity;

    [RelayCommand]
    public void NavigateToActiveCases()
    {
        _navigationStore.CurrentViewModel = new ActiveCasesViewModel(_navigationStore);
    }

    [RelayCommand]
    public async Task SaveNewCase()
    {
        await _caseService.CreateAsync(CaseEntity!);
        _navigationStore.CurrentViewModel = new ActiveCasesViewModel(_navigationStore);
    }
}
