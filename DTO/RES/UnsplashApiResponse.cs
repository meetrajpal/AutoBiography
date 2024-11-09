using Newtonsoft.Json;

namespace AutoBiography.DTO.RES;
public class UnsplashApiResponse
{
    [JsonProperty("total")]
    public int Total { get; set; }
    [JsonProperty("total_pages")]
    public int TotalPages { get; set; }
    [JsonProperty("results")]
    public List<Result> Results { get; set; }
}

public class Result
{
    public string Id { get; set; }
    public string Slug { get; set; }
    public Urls Urls { get; set; }
}

public class Urls
{
    public string Small { get; set; }
    public string Full { get; set; }
}
