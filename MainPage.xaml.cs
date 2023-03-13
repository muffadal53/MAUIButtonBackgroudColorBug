using MAUIButtonBackgroudColorBug.ViewModels;

namespace MAUIButtonBackgroudColorBug;

public partial class MainPage : ContentPage
{
    private readonly MainPageViewModel _viewModel = new();

    public MainPage()
	{
        BindingContext = _viewModel;

        InitializeComponent();
	}


    private void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        // Perform required operation after examining e.Value
        CheckBox checkBox = (CheckBox) sender;
        if (checkBox.IsChecked)
        {
            _viewModel.ChangeButtonColor = true;
        }
        else
        {
            _viewModel.ChangeButtonColor = false;
        }
    }

    private void Clicked(object sender, EventArgs e)
    {
        mycheckBox.IsChecked = !mycheckBox.IsChecked;
    }

    private void ColorAppliedBtnClicked(object sender, EventArgs e)
    {
        DisplayAlert("Applied Color Button", "ColorAppliedBtn is Clicked", "OK");
    }

    private void ColorNotAppliedBtnClicked(object sender, EventArgs e)
    {
        DisplayAlert("Not Applied Color Button", "ColorNotAppliedBtn is Clicked", "OK");
    }
}

