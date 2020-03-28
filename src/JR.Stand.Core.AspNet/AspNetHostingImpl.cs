using System;
using System.Web;
using JR.Stand.Abstracts;

namespace JR.Stand.Core.AspNet
{
    internal class AspNetHostingImpl : IServeHosting
    {
        private HttpContext Context=>HttpContext.Current;


        public void Stop()
        {
            AppDomain.Unload(AppDomain.CurrentDomain);
        }

        public T GetService<T>()
        {
            throw new NotImplementedException();
        }

        public string BaseDirectory()
        {
            return EnvUtil.GetBaseDirectory();
        }
    }
}