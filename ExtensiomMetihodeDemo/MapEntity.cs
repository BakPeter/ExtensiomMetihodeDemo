using Newtonsoft.Json;

namespace ExtensiomMetihodeDemo;
internal class MapEntity
{
    public string? Name { get; set; }
    public int Y { get; set; }
    public int X { get; set; }

    public override string ToString()
    {
        return JsonConvert.SerializeObject(this);
    }
}
