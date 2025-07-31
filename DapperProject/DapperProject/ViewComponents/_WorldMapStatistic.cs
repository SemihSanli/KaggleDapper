using DapperProject.Services.DashboardService;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.ViewComponents
{
    public class _WorldMapStatistic:ViewComponent
    {
        private readonly IDashboardServices _dashboardServices;

        public _WorldMapStatistic(IDashboardServices dashboardServices)
        {
            _dashboardServices = dashboardServices;
        }

        public async Task< IViewComponentResult> InvokeAsync()
        {
            var choosenMovies = await _dashboardServices.GetChoosen5MovieByMaxRevenueAndMaxVoteCount();
            return View(choosenMovies);
        }
    }
}
