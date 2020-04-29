using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApiX
{
    class SearchModel
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string ImdbId { get; set; }
        private string _type;
        public string Type
        {
            get
            {
                return _type.ToUpperInvariant();
            }
            set
            {
                _type = value;
            }
        }
        public string Poster { get; set; }        
    }
}
