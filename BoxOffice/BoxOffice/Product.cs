using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOffice
{
    class Product
    {
        private int _article = 123;
        public virtual int Article
        {
            get
            {
                return _article;
            }
            set
            {
                _article = value;
            }
        }

        private int _stock = 0;
        public virtual int Stock
        {
            get
            {
                return _stock;
            }
            set
            {
                _stock = value;
            }
        }
    }
}
