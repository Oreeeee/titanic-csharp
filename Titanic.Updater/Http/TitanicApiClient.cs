using Newtonsoft.Json.Serialization;
using Titanic.API.Http;
using Titanic.Updater.Models;

namespace Titanic.Updater.Http;

public class TitanicApiClient : IDisposable
{
#pragma warning disable CA1859
    private readonly IHttpInterface _http;
#pragma warning restore CA1859

    public TitanicApiClient(string baseAddress = "https://api.titanic.sh")
    {
        #if SUPPORT_HTTPCLIENT
        this._http = new HttpClientInterface(baseAddress);
        #else
        this._http = new WebClientInterface(baseAddress);
        #endif
    }

    private static readonly JsonSerializerSettings _settings = new()
    {
        ContractResolver = new DefaultContractResolver
        {
            NamingStrategy = new SnakeCaseNamingStrategy()
        }
    };

    private T Send<T>(HttpMethodType methodType, string endpoint, object? content = null, Dictionary<string, string>? headers = null)
    {
        string jsonContent = JsonConvert.SerializeObject(content, _settings);
        string str = this._http.RequestString(methodType, endpoint, jsonContent, headers);

        T? obj = JsonConvert.DeserializeObject<T>(str, _settings);
        if (obj == null)
            throw new Exception("Response had null content");

        return obj;
    }

    private T Get<T>(string endpoint, Dictionary<string, string>? headers = null)
    {
        return this.Send<T>(HttpMethodType.GET, endpoint, null, headers);
    }

    private T Post<T>(string endpoint, object? content, Dictionary<string, string>? headers = null)
    {
        return this.Send<T>(HttpMethodType.GET, endpoint, content, headers);
    }
    
    public ModdedRelease GetModdedRelease(string clientName)
    {
        return this.Get<ModdedRelease>("/releases/modded/" + clientName);
    }

    public IEnumerable<ModdedRelease> GetModdedReleases()
    {
        return this.Get<ModdedRelease[]>("/releases/modded");
    }

    public IEnumerable<ModdedReleaseEntry> GetModdedReleaseEntries(string clientName)
    {
        return this.Get<ModdedReleaseEntry[]>($"/releases/modded/{clientName}/entries");
    }

    public byte[] Download(string url)
    {
        return this._http.RequestBytes(HttpMethodType.GET, url, null, null);
    }

    public void Dispose()
    {
        this._http.Dispose();
        GC.SuppressFinalize(this);
    }
}