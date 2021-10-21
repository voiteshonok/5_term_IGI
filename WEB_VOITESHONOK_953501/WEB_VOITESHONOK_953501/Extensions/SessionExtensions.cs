using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WEB_VOITESHONOK_953501.Extensions
{
    public static class SessionExtensions 
    {
        public static void Set<T>(this ISession session, string key, T item)
        {
            var serializedItem = JsonConvert.SerializeObject(item);
            session.SetString(key, serializedItem);
        }
        public static T Get<T>(this ISession session, string key) where T : new()
        {
            var item = session.GetString(key);
            return item == null
            ? Activator.CreateInstance<T>() // или default(T)
            : JsonConvert.DeserializeObject<T>(item);
        }
    }
}
