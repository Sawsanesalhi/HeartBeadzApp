namespace HeartBeadzApp;

public partial class Login : ContentPage
{
	string username; //Store the text input by the user

	public Login()
	{
		InitializeComponent();
		BindingContext = this;

		username = userEntry.Text;
	}

    private void OnSubmitButtonClicked(object sender, EventArgs e)
    {

    }
}