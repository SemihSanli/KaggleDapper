using DapperProject.DTOs.DashboardDTOs;

namespace DapperProject.Services.DashboardService
{
    public interface IDashboardServices
    {
        Task<List<TopRatedMovieDTOs>> GetTopRatedMoviesAsync();
        Task<List<Choosen5MovieByMaxRevenueAndMaxVoteCountDTOs>> GetChoosen5MovieByMaxRevenueAndMaxVoteCount();
        Task<int> GetMovieCountAsync();
        Task<MostVotedMovieNameDTOs> MostVotedMovieNameAsync();
    }
}
