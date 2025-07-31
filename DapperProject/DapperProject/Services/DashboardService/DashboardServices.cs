using Dapper;
using DapperProject.Context;
using DapperProject.DTOs.DashboardDTOs;
using Microsoft.Data.SqlClient;

namespace DapperProject.Services.DashboardService
{
    public class DashboardServices : IDashboardServices
    {
        private readonly DapperContext _dapperContext;

        public DashboardServices(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public async Task<List<Choosen5MovieByMaxRevenueAndMaxVoteCountDTOs>> GetChoosen5MovieByMaxRevenueAndMaxVoteCount()
        {
            string query = "select top 5 title,revenue,vote_count from TMDB_movie_dataset_v11 where revenue>0 and vote_count>0 order by revenue desc,vote_count desc ";
            var connection = _dapperContext.CreateConnection();
            var value = await connection.QueryAsync<Choosen5MovieByMaxRevenueAndMaxVoteCountDTOs>(query);
            return value.ToList();
        }

        public async Task<int> GetMovieCountAsync()
        {
            var query = "SELECT COUNT(*) FROM TMDB_movie_dataset_v11";
            var connection = _dapperContext.CreateConnection();
            return await connection.QuerySingleAsync<int>(query);

        }

        public async Task<List<TopRatedMovieDTOs>> GetTopRatedMoviesAsync()
        {
            string query = "select top 4 * from TMDB_movie_dataset_v11 order by vote_count desc";
            var connection = _dapperContext.CreateConnection();
            var value = await connection.QueryAsync<TopRatedMovieDTOs>(query);
            return value.ToList();
        }

        public async Task<MostVotedMovieNameDTOs> MostVotedMovieNameAsync()
        {
            string query = "select top 1 title,vote_count,production_countries from TMDB_movie_dataset_v11 where vote_count > 0 order by vote_count desc ";
            var connection = _dapperContext.CreateConnection();
            return await connection.QuerySingleAsync<MostVotedMovieNameDTOs>(query);
        }
    }
}
