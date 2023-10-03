namespace NavaigationPage;

public partial class Detail : ContentPage
{
	public Detail(string Name ,string Image ,string Description)
	{
		InitializeComponent();
		fruitName.Text = Name;
		fruitImg.Source = Image;
		fruitDescription.Text = Description;
	}
}