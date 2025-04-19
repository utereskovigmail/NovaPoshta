﻿using Newtonsoft.Json;

namespace NovaPoshtaParalle;

public class NovaPostaRequest
{
    [JsonProperty(PropertyName = "apiKey")]
    public string ApiKey { get; init; }

    [JsonProperty(PropertyName = "modelName")]
    public string ModelName { get; init; }

    [JsonProperty(PropertyName = "calledMethod")]
    public string CalledMethod { get; init; }

    [JsonProperty(PropertyName = "methodProperties")]
    public NovaPoshtaMethodProperties MethodProperties { get; init; }
}

public class NovaPoshtaMethodProperties
{
    /// <summary>
    /// Номер сторінки
    /// </summary>
    public string Page { get; set; } = "1";

    /// <summary>
    /// Кількість населених пунктів за 1 запит
    /// </summary>
    public int Limit { get; set; }
}
