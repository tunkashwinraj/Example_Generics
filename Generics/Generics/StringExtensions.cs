using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Generics
{
    public static class StringExtensions
    {
        public static T DeserializeJson<T>(this string json)
        {
            return JsonSerializer.Deserialize<T>(json);
        }
        public static string SerializeJson<T>(this T obj)
        {
            return JsonSerializer.Serialize(obj);
        }
    }
}
