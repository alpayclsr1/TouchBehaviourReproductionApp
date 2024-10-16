using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TouchBehaviourReproductionApp;

public partial class MainPageViewModel:ObservableObject
{
    public MainPageViewModel()
    {
        
    }

    [RelayCommand]
    public async void NavigateToModalPage()
    {
        var page=new NavigationPage();
        await Shell.Current.Navigation.PushModalAsync(page, false);
    }

}
