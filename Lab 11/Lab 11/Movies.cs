using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_11
{
    class Movies
    {
        private string _title;
        private Category _category;

        public Movies(string title, Category category)
        {
            _title = title;
            _category = category;
        }

        public string GetTitle()
        {
            return _title;
        }
        
        public Category GetCategory()
        {
            return _category;
        }
    }
}
