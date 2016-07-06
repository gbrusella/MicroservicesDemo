using Nancy;

namespace GlobalLogic.MicroservicesDemo.Modules
{
    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = _ =>
            {
                return View["index"];
            };
        }
    }
}