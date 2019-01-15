namespace GixDotnet.Infrastructure.Http
{
    public class GixResponse
    {
    }

    public class GixResponse<T>
    {
        public T Data { get; set; }
    }
}