namespace GR953500.Services
{
    public class MyServiceClass
    {
        private readonly IService _service;

        public MyServiceClass(IService srv)
        {
            _service = srv;
        }
    }
}
