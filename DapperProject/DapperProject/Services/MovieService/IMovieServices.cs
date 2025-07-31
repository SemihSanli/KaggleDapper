using DapperProject.DTOs.MovieDTOs;

namespace DapperProject.Services.MovieService
{
    public interface IMovieServices
    {
        Task<List<ResultMovieDTOs>> GetAllMovieAsync();
        Task<(List<ResultMovieDTOs> Movies, int TotalCount, int TotalPages)> GetMoviesWithPaginationAsync(int page, int pageSize, string year = "", string sort = "", string genre = "", string search = "");

        Task<MoviesDetailDTOs> GetMovieDetailById(int id);
    }
}
