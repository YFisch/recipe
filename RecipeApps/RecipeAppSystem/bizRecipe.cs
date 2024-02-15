        namespace RecipeAppSystem
{
    public class bizRecipe : bizObject<bizRecipe>
    {
        public bizRecipe()
        {

        }
        private int _recipeid;
        private int _usersid;
        private int _cuisinetypeid;
        private string _recipename;
        private int _calories;
        private DateTime _datedrafted;
        private DateTime? _datepublished;
        private DateTime? _datearchived;
        private string _recipestatus;
        private string _recipepicture;
        private string _user;
        private int _numingredients;
        private bool _vegan;

        public List<bizRecipe> GetRecipeSummary()
        {
            List<bizRecipe> lst = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeSummaryGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            var dt = SQLUtility.GetDataTable(cmd);
            return GetListFromDataTable(dt);
        }

        public List<bizRecipe> GetRecipeCookbook(string cookbookdesc)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeByCookbookGet");
            SQLUtility.SetParamValue(cmd, "@CookbookDesc", cookbookdesc);
            dt = SQLUtility.GetDataTable(cmd);
            return GetListFromDataTable(dt);
        }

        public DataTable SearchRecipes(string recipenameval)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand(GetSprocName);
            SQLUtility.SetParamValue(cmd, "@RecipeName", recipenameval);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public int Recipeid
        {
            get { return _recipeid; }
            set
            {
                if (_recipeid != value)
                {
                    _recipeid = value;
                    InvokePropertyChanged();
                }
            }
        }
        public int UsersId
        {
            get { return _usersid; }
            set
            {
                if (_usersid != value)
                {
                    _usersid = value;
                    InvokePropertyChanged();
                }
            }
        }
        public int CuisineTypeId
        {
            get { return _cuisinetypeid; }
            set
            {
                if (_cuisinetypeid != value)
                {
                    _cuisinetypeid = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string RecipeName
        {
            get { return _recipename; }
            set
            {
                if (_recipename != value)
                {
                    _recipename = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string RecipeStatus
        {
            get { return _recipestatus; }
            set
            {
                if (_recipestatus != value)
                {
                    _recipestatus = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string Users
        {
            get { return _user; }
            set
            {
                if (_user != value)
                {
                    _user = value;
                    InvokePropertyChanged();
                }
            }
        }


        public int Calories
        {
            get { return _calories; }
            set
            {
                if (_calories != value)
                {
                    _calories = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int NumIngredients
        {
            get { return _numingredients; }
            set
            {
                if (_numingredients != value)
                {
                    _numingredients = value;
                    InvokePropertyChanged();
                }
            }
        }

        public bool Vegan
        {
            get { return _vegan; }
            set
            {
                if (_vegan != value)
                {
                    _vegan = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime DateDrafted
        {
            get { return _datedrafted; }
            set
            {
                if (_datedrafted != value)
                {
                    _datedrafted = value;
                    InvokePropertyChanged();
                }
            }
        }
        public DateTime? DatePublished
        {
            get { return _datepublished; }
            set
            {
                if (_datepublished != value)
                {
                    _datepublished = value;
                    InvokePropertyChanged();
                }
            }
        }
        public DateTime? DateArchived
        {
            get { return _datearchived; }
            set
            {
                if (_datearchived != value)
                {
                    _datearchived = value;
                    InvokePropertyChanged();
                }
            }
        }
      
        public string RecipePicture
        {
            get { return _recipepicture; }
            set
            {
                if (_recipepicture != value)
                {
                    _recipepicture = value;
                    InvokePropertyChanged();
                }
            }        
        }
    }
}
