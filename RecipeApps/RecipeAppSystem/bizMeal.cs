namespace RecipeAppSystem
{
    public class bizMeal:bizObject<bizMeal>
    {
        private int _MealId;
        private int _UsersId;
        private string _MealName = "";
        private DateTime _DateCreated;
        private bool _Active;
        private string _MealPicture = "";
        private string _user = "";
        private int _NumCalories;
        private int _NumCourses;
        private int _NumRecipes;
        private string _MealDesc = "";

        public List<bizMeal> GetMealSummary()
        {
            List<bizMeal> lst = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("MealSummaryGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            var dt = SQLUtility.GetDataTable(cmd);
            return GetListFromDataTable(dt);
        }

        public int MealId
        {
            get { return _MealId; }
            set
            {
                if (_MealId != value)
                {
                    _MealId = value;
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

        public string MealName
        {
            get { return _MealName; }
            set
            {
                if(_MealName != value)
                {
                    _MealName = value;
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

        public int NumCalories
        {
            get { return _NumCalories; }
            set
            {
                if (_NumCalories != value)
                {
                    _NumCalories = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int NumCourses
        {
            get { return _NumCourses; }
            set
            {
                if (_NumCourses != value)
                {
                    _NumCourses = value;
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

        public string MealDesc
        {
            get { return _MealDesc; }
            set
            {
                if (_MealDesc != value)
                {
                    _MealDesc = value;
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

        public string MealPicture
        {
            get { return _MealPicture; }
            set
            {
                if (_MealPicture != value)
                {
                    _MealPicture = value;
                    InvokePropertyChanged();
                }
            }
        }
    }
}
