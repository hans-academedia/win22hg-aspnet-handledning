using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;
using WpfApp.Models.Entities;
using WpfApp.Services;

namespace WpfApp.Models.ViewModels;

internal partial class NewCaseViewModel : ObservableObject
{
    private readonly NavigationStore? _navigationStore;
    private readonly CaseService _caseService = new();
    private readonly CustomerService _customerService = new();

    public NewCaseViewModel(NavigationStore? navigationStore)
    {
        _navigationStore = navigationStore;
    }

    [ObservableProperty]
    private CaseEntity caseEntity = new CaseEntity();

    [RelayCommand]
    public void NavigateToActiveCases()
    {
        _navigationStore!.CurrentViewModel = new ActiveCasesViewModel(_navigationStore);
    }

    [RelayCommand]
    public async Task SaveCase()
    {

        if (await _caseService.CreateAsync(CaseEntity))
            NavigateToActiveCases();

    }
}
