namespace MauiApp3
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            Lavel.Style = Set;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {

            Lavel.Style = Sets;
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
