using System.Text.Json;

namespace DesktopApp
{
    public class CommonFunctions
    {
        public static T Clone<T>(T sourceObject)
        {
            var json = JsonSerializer.Serialize(sourceObject);
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}