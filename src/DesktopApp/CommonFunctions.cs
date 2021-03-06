using System.Text.Json;

namespace DesktopApp
{
    public static class CommonFunctions
    {
        public static T Clone<T>(T sourceObject)
        {
            var json = JsonSerializer.Serialize(sourceObject);
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}