public sealed class ServiceProxy : IService
{
    private readonly object _sync = new object();
    private volatile IService _realService;

    public string GetData()
    {
        if (_realService == null)
        {
            lock (_sync)
            {
                if (_realService == null)
                {
                    _realService = new RealService();
                }
            }
        }

        return _realService.GetData();
    }
}