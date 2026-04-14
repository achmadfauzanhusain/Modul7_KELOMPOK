using System;
using System.IO;
using System.Text.Json;

public class FilmFavorit_103022400139
{
    public string title { get; set; }
    public string director { get; set; }
    public string year { get; set; }
    public string genre { get; set; }
    public string rating { get; set; }
    public string durationMinutes { get; set; }
    public string isWatched { get; set; }

    public static void ReadJSON()
    {
        string jsonString = File.ReadAllText("jurnal7_1_103022400139.json");

        var data = JsonSerializer.Deserialize<FilmFavorit_103022400139 > (jsonString);

        Console.WriteLine($"Judul film : {data.title} Nama director : {data.director} Tahun : {data.year} Genre : {data.genre} Rating : {data.rating}" +
            $" Durasi : {data.durationMinutes} Sudah menonton? {data.isWatched}");
    }
}