using System.Text.Json;

namespace JsonCombine;
public static class JsonTools
{
    public static string ToArray(params string[] jsons)
    {
        return JsonSerializer.Serialize(jsons.Select(json => JsonSerializer.Deserialize<JsonElement>(json)));
    }
}
