using System.Collections.Concurrent;
using System.Text.Json.Serialization;

namespace NovaPoshtaParalle;

public class NovaPoshtaResponseArea<T>
{
    public ConcurrentBag<T> Data { get; set; }
}

public class NovaPoshtaResponseCity<T>
{
    public T[] Data { get; set; }

    [JsonPropertyName("info")]
    public NovaPoshtaInfoCity Info { get; set; }
}

public class NovaPoshtaInfoCity
{
    [JsonPropertyName("totalCount")]
    public int TotalCount { get; set; }
}
