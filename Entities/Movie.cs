namespace dotnet_movie_api.Entities;

public class Movie
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public string Description { get; set; } = string.Empty;
    public required string Genre { get; set; }
    public required int Duration { get; set; }
    public required DateTime ReleaseDate { get; set; }
    public required string Director { get; set; }
}