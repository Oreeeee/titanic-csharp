#if !SUPPORT_HTTPCLIENT
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Titanic.API.Http;

public class WebClientInterface : IHttpInterface
{
    private readonly WebClient _client;
    private readonly Dictionary<string, string> _defaultHeaders = [];

    public WebClientInterface(string baseAddress)
    {
        this._client = new WebClient
        {
            BaseAddress = baseAddress
        };
    }

    private void PrepareRequest(Dictionary<string, string>? headers)
    {
        _client.Headers.Clear();
        foreach (KeyValuePair<string, string> kvp in _defaultHeaders)
        {
            _client.Headers.Add(kvp.Key, kvp.Value);
        }

        if (headers != null)
        {
            foreach (KeyValuePair<string, string> kvp in headers)
            {
                _client.Headers.Add(kvp.Key, kvp.Value);
            }
        }
    }

    public string RequestString(HttpMethodType methodType, string endpoint, string? content, Dictionary<string, string>? headers)
    {
        lock (_client)
        {
            this.PrepareRequest(headers);
            return methodType switch
            {
                HttpMethodType.GET => this._client.DownloadString(endpoint),
                HttpMethodType.POST => this._client.UploadString(endpoint, content ?? ""),
                _ => throw new ArgumentOutOfRangeException(nameof(methodType), methodType, null)
            };
        }
    }

    public byte[] RequestBytes(HttpMethodType methodType, string endpoint, string? content, Dictionary<string, string>? headers)
    {
        lock (_client)
        {
            this.PrepareRequest(headers);
            return methodType switch
            {
                HttpMethodType.GET => this._client.DownloadData(endpoint),
                HttpMethodType.POST => this._client.UploadData(endpoint, Encoding.UTF8.GetBytes(content ?? "")),
                _ => throw new ArgumentOutOfRangeException(nameof(methodType), methodType, null)
            };
        }
    }

    public void AddDefaultHeader(string key, string value)
    {
        this._defaultHeaders.Add(key, value);
    }

    public void RemoveDefaultHeader(string key)
    {
        this._defaultHeaders.Remove(key);
    }
    
    public void Dispose()
    {
        this._client.Dispose();
        GC.SuppressFinalize(this);
    }
}
#endif