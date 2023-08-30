using RecipeAppSystem;
using System.Data;

namespace RecipeMAUI;

public partial class RecipeList : ContentPage
{
	public RecipeList()
	{
		InitializeComponent();
        this.Loaded += RecipeList_Loaded;

	}

    private void RecipeList_Loaded(object sender, EventArgs e)
    {
        RecipeSummary();
    }

    private void RecipeSummary()
	{
		DataTable dt = Recipes.GetRecipeSummary();
		RecipeLst.ItemsSource = dt.Rows;
	}		
}