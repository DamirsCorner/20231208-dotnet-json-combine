using FluentAssertions.Json;
using Newtonsoft.Json.Linq;
using static JsonCombine.JsonTools;

namespace JsonCombine;

public class JsonToolsTests
{
    private readonly string json1 = """{"firstName": "John", "lastName": "Doe", "age": 42}""";
    private readonly string json2 = """{"firstName": "Jane", "lastName": "Doe", "height": 172}""";

    [Test]
    public void ToArrayCombinesMultipleJsonsIntoJsonArray()
    {
        var actual = ToArray(json1, json2);
        var expected = $"[{json1},{json2}]";

        JToken.Parse(actual).Should().BeEquivalentTo(JToken.Parse(expected));
    }
}