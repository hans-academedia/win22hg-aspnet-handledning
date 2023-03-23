using CommunityToolkit.Mvvm.ComponentModel;
using System;
using WpfApp.Models.Entities;
using WpfApp.Navigation;
using WpfApp.Services;

namespace WpfApp.ViewModels;

internal partial class CaseViewModel : ObservableObject
{
    private readonly NavigationStore _navigationStore;
    private readonly CaseService _caseService;

    public CaseViewModel(int id, NavigationStore navigationStore)
    {
        _navigationStore = navigationStore;
        _caseService = new CaseService();

    }

    [ObservableProperty]
    private CaseEntity currentCase = null!;

}
