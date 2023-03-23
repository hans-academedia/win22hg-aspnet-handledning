using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using WpfApp.Models.Entities;
using WpfApp.Navigation;
using WpfApp.Services;

namespace WpfApp.ViewModels
{
    internal partial class ActiveCasesViewModel : ObservableObject
    {
        private readonly NavigationStore _navigationStore;
        private readonly CaseService _caseService = new();

        [ObservableProperty]
        private string title = "Aktiva Ärenden";

        [ObservableProperty]
        private ObservableCollection<CaseEntity> activeCases = new();

        public ActiveCasesViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            GetActiveCases();
        }

        private void GetActiveCases()
        {
            var _cases = Task.Run(_caseService.GetAllActiveAsync).Result;
            foreach (var _case in _cases)
                ActiveCases.Add(_case);
        }

    }
}
