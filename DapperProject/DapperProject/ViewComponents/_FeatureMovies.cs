using DapperProject.Services.DashboardService;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.ViewComponents
{
    public class _FeatureMovies:ViewComponent
    {
        private readonly IDashboardServices _dashboardServices;

        public _FeatureMovies(IDashboardServices dashboardServices)
        {
            _dashboardServices = dashboardServices;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var topMovies = await _dashboardServices.GetTopRatedMoviesAsync();
            return View(topMovies);
        }
    }
}
