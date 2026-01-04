using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Titanic.API
{
    public abstract class APIRequest<T>
    {
        protected abstract T Execute(TitanicAPI api);
        public delegate void OnSuccess(T response);
        public delegate void OnError(Exception e);

        public void Perform(TitanicAPI api, OnSuccess onSuccess, OnError onError)
        {
            ThreadPool.QueueUserWorkItem(_ =>
            {
                try {
                    T response = Execute(api);
                    onSuccess?.Invoke(response);
                } catch (Exception e) {
                    onError?.Invoke(e);
                }
            });
        }

        public void Perform(TitanicAPI api)
        {
            Perform(api, null, null);
        }

        public void Perform(TitanicAPI api, OnSuccess onSuccess)
        {
            Perform(api, onSuccess, null);
        }

        public T BlockingPerform(TitanicAPI api)
        {
            return Execute(api);
        }
    }
}
