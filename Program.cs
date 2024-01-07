using System.Collections.Generic;
using System.Text.Json;
using Data;
using System.Linq;

namespace Program;

string filePath = "atlas.json";
string jsonData = File.ReadAllText(filePath);

List<AtlasData> myAtlasObject = JsonSerializer.Deserialize<List<AtlasData>>(jsonData);

var data = myAtlasObject.Where(x => x.latitude > 33);

foreach (var item in data)
{
    Console.WriteLine($"Country: {item.country}, Latitude: {item.latitude}");
}
