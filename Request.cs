using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace MovieApiX
{
    class Request
    {
        /// <summary>
        /// Sets the API key for request 
        /// Get your API key from http://www.omdbapi.com/
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// Returns information for given movie title.
        /// Check <c>Error</c> and <c>Response</c> for invalid operation.
        /// </summary>
        /// <param name="movieTitle"></param>
        /// <returns></returns>
        public async Task<MovieModel> GetMovieDataByNameAsync(string movieTitle)
        {
            var http = new HttpClient();
            var response = await http.GetAsync(
                string.Format("http://www.omdbapi.com/?apikey={1}&t={0}",
                movieTitle.Replace(' ', '+'), Key));
            var result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<MovieModel>(result);
        }
        /// <summary>
        /// Returns information for given imdb id.
        /// Check <c>Error</c> and <c>Response</c> for invalid operation.
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public async Task<MovieModel> GetMovieDataByIdAsync(string ID)
        {
            var http = new HttpClient();
            var response = await http.GetAsync(
                string.Format("http://www.omdbapi.com/?apikey={1}&i={0}",
                    ID, Key));
            var result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<MovieModel>(result);
        }
        /// <summary>
        /// Returns search result for given query.
        /// Check <c>Error</c> and <c>Response</c> for invalid operation.
        /// </summary>
        /// <param name="query"></param>
        /// <returns>Returns <c>PerformSearch</c> object.</returns>
        public async Task<PerformSearch> GetMovieSearchResult(string query)
        {
            var http = new HttpClient();
            var response = await http.GetAsync(
                string.Format("http://www.omdbapi.com/?apikey={1}&s={0}", 
                query.Replace(' ', '+'),Key));
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<PerformSearch>(content);            
        }
    }
}
