namespace WebApplication.Middleware
{
    public interface IHeaderOption
    {
        string Header { get; }
        string Value { get; set; }
    }
}