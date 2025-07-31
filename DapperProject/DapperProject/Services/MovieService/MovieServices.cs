using Dapper;
using DapperProject.Context;
using DapperProject.DTOs.MovieDTOs;
using NuGet.Protocol.Plugins;
using System.Linq;

namespace DapperProject.Services.MovieService
{
    public class MovieServices : IMovieServices
    {
        private readonly DapperContext _dapperContext;

        public MovieServices(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public async Task<List<ResultMovieDTOs>> GetAllMovieAsync()
        {
            string query = "select * from TMDB_movie_dataset_v11 WHERE adult = 'False'";
            var connection =_dapperContext.CreateConnection();
            var values = await connection.QueryAsync<ResultMovieDTOs>(query);
            return values.ToList();
        }

        public async Task<MoviesDetailDTOs> GetMovieDetailById(int id)
        {
            var query = "SELECT id, title, vote_average, vote_count, status, release_date, revenue, runtime, adult, backdrop_path, budget, homepage, imdb_id, original_language, original_title, overview, popularity, poster_path, tagline, genres, production_companies, production_countries, spoken_languages, keywords FROM TMDB_movie_dataset_v11 WHERE id = @id";
            var connection = _dapperContext.CreateConnection();
            var movie = await connection.QueryFirstOrDefaultAsync<MoviesDetailDTOs>(query, new { id = id });
            return movie;
        }

        public async Task<(List<ResultMovieDTOs> Movies, int TotalCount, int TotalPages)> GetMoviesWithPaginationAsync(int page, int pageSize, string year = "", string sort = "", string genre = "", string search = "")
        {
            var offset = (page - 1) * pageSize;
            var whereConditions = new List<string>();
            var parameters = new DynamicParameters();

            // Varsayılan olarak yetişkin içerikleri hariç tut (string olarak karşılaştır)
            whereConditions.Add("adult = 'False'");

            if (!string.IsNullOrEmpty(year))
            {
                whereConditions.Add("YEAR(release_date) = @Year");
                parameters.Add("@Year", year);
            }

            if (!string.IsNullOrEmpty(genre))
            {
                whereConditions.Add("genres LIKE @Genre");
                parameters.Add("@Genre", $"%{genre}%");
            }

            if (!string.IsNullOrEmpty(search))
            {
                whereConditions.Add("(title LIKE @Search OR overview LIKE @Search OR genres LIKE @Search)");
                parameters.Add("@Search", $"%{search}%");
            }

            var whereClause = "WHERE " + string.Join(" AND ", whereConditions);

            // Determine ORDER BY clause based on sort parameter
            var orderByClause = "ORDER BY vote_average DESC"; // Default
            switch (sort?.ToLower())
            {
                case "high_to_low":
                    orderByClause = "ORDER BY vote_average DESC";
                    break;
                case "low_to_high":
                    orderByClause = "ORDER BY vote_average ASC";
                    break;
                case "newest":
                    orderByClause = "ORDER BY release_date DESC";
                    break;
                case "oldest":
                    orderByClause = "ORDER BY release_date ASC";
                    break;
                case "most_voted":
                    orderByClause = "ORDER BY vote_count DESC";
                    break;
                case "least_voted":
                    orderByClause = "ORDER BY vote_count ASC";
                    break;
                default:
                    orderByClause = "ORDER BY vote_average DESC";
                    break;
            }

            // Get total count
            var countQuery = $@"
                SELECT COUNT(*) 
                FROM TMDB_movie_dataset_v11 
                {whereClause}";

            // Get movies for current page
            var moviesQuery = $@"
                SELECT * FROM TMDB_movie_dataset_v11 
                {whereClause}
                {orderByClause}
                OFFSET @Offset ROWS 
                FETCH NEXT @PageSize ROWS ONLY";

            parameters.Add("@Offset", offset);
            parameters.Add("@PageSize", pageSize);

            var connection = _dapperContext.CreateConnection();
            var totalCount = await connection.QueryFirstOrDefaultAsync<int>(countQuery, parameters);
            var movies = await connection.QueryAsync<ResultMovieDTOs>(moviesQuery, parameters);
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);

            return (movies.ToList(), totalCount, totalPages);
        }
    }
}
