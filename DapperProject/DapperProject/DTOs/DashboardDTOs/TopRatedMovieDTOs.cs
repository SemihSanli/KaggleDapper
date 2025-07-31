namespace DapperProject.DTOs.DashboardDTOs
{
    public class TopRatedMovieDTOs
    {
        public string poster_path { get; set; }
        public string title { get; set; }
        public double vote_average { get; set; }
        public int vote_count { get; set; }
        public DateTime? release_date { get; set; }
        public int? runtime { get; set; }

        public long budget { get; set; }
        public long revenue { get; set; }
    }
}
