namespace TickerPerformanceViewer.Web.Modules
{
    public class HomeModule : AppModule
    {
        public HomeModule()
        {
            Get["/"] = x => View["index"];
        }
    }
}
