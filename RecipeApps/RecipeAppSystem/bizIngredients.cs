namespace RecipeAppSystem
{
    public class bizIngredients: bizObject<bizIngredients>
    {
        private int _IngredientsId;
        private string _Ingredient = "";

        public List<bizIngredients> Search(string ingredientval)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(GetSprocName);
            SQLUtility.SetParamValue(cmd, "Ingredient", ingredientval);
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }

        public int IngredientsId
        {
            get { return _IngredientsId;}
            set
            {
                if(_IngredientsId != value)
                {
                    _IngredientsId = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string Ingredient
        {
            get { return _Ingredient; }
            set
            {
                if (_Ingredient != value)
                {
                    _Ingredient = value;
                    InvokePropertyChanged();
                }
            }
        }
    }
}
