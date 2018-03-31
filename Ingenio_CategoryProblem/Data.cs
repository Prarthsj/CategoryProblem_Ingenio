namespace Ingenio_CategoryProblem
{
    class Data
    {
        private int _key;
        private Category _category;
        public int Key
        {
            get
            {
                return _key;
            }

            set
            {
                _key = value;
            }
        }       
        public Category Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
        }     
        public Data Left { get; set; }    
        public Data Right { get; set; }
        public Data(int key, Category category)
        {
            _key = key;
            _category = new Category(category);
            Left = null;
            Right = null;
        }     
        public override string ToString()
        {
            return Key.ToString();
        }
    }
}
