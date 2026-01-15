using System;

namespace Titanic.API.Http;

public static class HttpInterfaceFactory
{
    public static IHttpInterface Create(string baseAddress)
    {
#if SUPPORT_HTTPCLIENT
        return new HttpClientInterface(baseAddress);
#else
        return new WebClientInterface(baseAddress);
#endif
    }
}
