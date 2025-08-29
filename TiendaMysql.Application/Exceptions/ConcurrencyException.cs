namespace TiendaMysql.Application.Exceptions
{
    public class ConcurrencyException(string message, Exception innerException) :Exception(message)
    {
    }
}
