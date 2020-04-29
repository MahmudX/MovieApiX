using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApiX
{
    class PerformSearch
    {
        /// <summary>
        /// List of search results
        /// </summary>
        public List<MovieModel> Search { get; set; }
        public string TotalResults { get; set; }
        public string Response { get; set; }
        public string Error { get; set; }
    }
}
