using System.Text.Json.Nodes;

namespace JsonCombine;
public static class JsonTools
{
    public static string ToArray(params string[] jsons)
    {
        return new JsonArray(jsons.Select(json => JsonNode.Parse(json)).ToArray()).ToJsonString();
    }
}
