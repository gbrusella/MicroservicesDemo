using Nancy;

namespace GlobalLogic.MicroservicesDemo.Modules
{
    public class APIModule : NancyModule
    {
        public APIModule()
        {
            Get["/api"] = _ => "Hello!";
        }
    }
}