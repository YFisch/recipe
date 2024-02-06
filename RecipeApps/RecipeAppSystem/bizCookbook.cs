namespace RecipeAppSystem
{
    public class bizCookbook:bizObject<bizCookbook>
    {
        private int _CookbookId;
        private int _UsersId;
        private string _CookbookName = "";
        private decimal _Price;
        private DateTime _DateCreated;
        private bool _Active;
        private string _CookbookPicture = "";
        private string _user = "";
        private int _NumRecipes;
        private string _Skill = "";

        public List<bizCookbook> GetCookbookSummary()
        {
            List<bizCookbook> lst = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookbookSummaryGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            var dt = SQLUtility.GetDataTable(cmd);
            return GetListFromDataTable(dt);
        }


        public int CookbookId
        {
            get { return _CookbookId; }
            set
            {
                if (_CookbookId != value)
                {
                    _CookbookId = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int UsersId
        {
            get { return _UsersId; }
            set
            {
                if (_UsersId != value)
                {
                    _UsersId = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string CookbookName
        {
            get { return _CookbookName; }
            set
            {
                if (_CookbookName != value)
                {
                    _CookbookName = value;
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

        public int NumRecipes
        {
            get { return _NumRecipes; }
            set
            {
                if (_NumRecipes != value)
                {
                    _NumRecipes = value;
                    InvokePropertyChanged();
                }
            }
        }

        public decimal Price
        {
            get { return _Price; }
            set
            {
                if (_Price != value)
                {
                    _Price = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string Skill
        {
            get { return _Skill; }
            set
            {
                if (_Skill != value)
                {
                    _Skill = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime DateCreated
        {
            get { return _DateCreated; }
            set
            {
                if (_DateCreated != value)
                {
                    _DateCreated = value;
                    InvokePropertyChanged();
                }
            }
        }

        public bool Active
        {
            get { return _Active; }
            set
            {
                if (_Active != value)
                {
                    _Active = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string CookbookPicture
        {
            get { return _CookbookPicture; }
            set
            {
                if (_CookbookPicture != value)
                {
                    _CookbookPicture = value;
                    InvokePropertyChanged();
                }
            }
        }
    }
}
