namespace HeartBeadzApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnImageButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Login());
            //SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
