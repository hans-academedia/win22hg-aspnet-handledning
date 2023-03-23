using CommunityToolkit.Mvvm.ComponentModel;
using WpfApp.Models.Entities;
using WpfApp.Navigation;
using WpfApp.Services;

namespace WpfApp.ViewModels;

internal partial class CreateUserViewModel : ObservableObject
{
    private readonly NavigationStore _navigationStore;
    private readonly UserService _userService = new();

    public CreateUserViewModel(NavigationStore navigationStore)
    {
        _navigationStore = navigationStore;
    }

    [ObservableProperty]
    private UserEntity userEntity = new UserEntity();
}
