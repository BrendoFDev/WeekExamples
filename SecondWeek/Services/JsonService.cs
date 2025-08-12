using System.Text.Json;
using System.Text.Json.Serialization;

namespace SecondWeek.Services
{
    public class JsonService
    {
        public JsonService() { }
        public string Serialize(object obj)
        {
            return JsonSerializer.Serialize(obj);
        }

        public T? Deserialize<T>(string json)
        {
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
