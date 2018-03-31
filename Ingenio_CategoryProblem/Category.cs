namespace Ingenio_CategoryProblem
{
    class Category
    {
        private int _categoryId;
        private int _parentCategoryId;
        private string _name;
        private string _keywords;        
        public int CategoryId
        {
            get
            {
                return _categoryId;
            }
            set
            {
                _categoryId = value;
            }
        }    
        public int ParentCategoryId
        {
            get
            {
                return _parentCategoryId;
            }

            set
            {
                _parentCategoryId = value;
            }

        }
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }
        public string Keywords
        {
            get
            {
                return _keywords;
            }

            set
            {
                _keywords = value;
            }
        }       
        public Category(int categoryId, int parentCategoryId, string name, string keywords)
        {
            _categoryId = categoryId;
            _parentCategoryId = parentCategoryId;
            _name = name;
            _keywords = keywords;
        }
        public Category()
        {

        }       
        public Category(Category category)
        {
            _categoryId = category._categoryId;
            _parentCategoryId = category._parentCategoryId;
            _name = category._name;
            _keywords = category._keywords;
        }
    }
}
