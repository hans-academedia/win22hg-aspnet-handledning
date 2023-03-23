using CommunityToolkit.Mvvm.ComponentModel;
using System;

namespace WpfApp.Navigation;

internal class NavigationStore
{
	public int UserId { get; set; }

    public event Action? CurrentViewModelChanged;

	private ObservableObject? currentViewModel;

	public ObservableObject CurrentViewModel
	{
		get { return currentViewModel!; }
		set 
		{ 
			currentViewModel = value;
			OnCurrentViewModelChanged();
		}
	}

	private void OnCurrentViewModelChanged()
	{
		CurrentViewModelChanged?.Invoke();
	}

}
