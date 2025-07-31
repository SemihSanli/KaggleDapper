using DapperProject.Services.DashboardService;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.ViewComponents
{
    public class _WidgetPart:ViewComponent
    {
        private readonly IDashboardServices _dashboardServices;

        public _WidgetPart(IDashboardServices dashboardServices)
        {
            _dashboardServices = dashboardServices;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var totalMovies = await _dashboardServices.GetMovieCountAsync();
            var mostVotedMovieName = await _dashboardServices.MostVotedMovieNameAsync();



            ViewBag.TotalMovies = totalMovies;
            ViewBag.MostVotedMovieName = mostVotedMovieName.title;        
            ViewBag.MostVotedMovieVotes = mostVotedMovieName.vote_count; 
            ViewBag.MostVotedMovieProducerCountry = mostVotedMovieName.production_countries.Substring(0,14).ToString(); 
            return View();
        }
    }
}
