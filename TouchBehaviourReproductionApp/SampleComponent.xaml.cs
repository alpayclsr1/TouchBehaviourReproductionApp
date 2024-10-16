using System.Windows.Input;

namespace TouchBehaviourReproductionApp;

public partial class SampleComponent : ContentView
{
	public SampleComponent()
	{
		InitializeComponent();
	}

	    public ICommand Command
    {
        get { return (ICommand)GetValue(CommandProperty); }
        set { SetValue(CommandProperty, value); }
    }

    public static readonly BindableProperty CommandProperty = BindableProperty.Create(
    nameof(Command), typeof(ICommand), typeof(SampleComponent), null, BindingMode.TwoWay);
	
}