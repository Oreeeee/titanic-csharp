namespace Titanic.Updater.Http;

public interface IHttpInterface : IDisposable
{
    string RequestString(HttpMethodType methodType, string endpoint, string? content, Dictionary<string, string>? headers);
    byte[] RequestBytes(HttpMethodType methodType, string endpoint, string? content, Dictionary<string, string>? headers);
    void AddDefaultHeader(string key, string value);
    void RemoveDefaultHeader(string key);
}