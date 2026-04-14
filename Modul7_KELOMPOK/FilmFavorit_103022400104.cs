using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Modul7_KELOMPOK
{
    internal class FilmFavorit_103022400104
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
            string json = File.ReadAllText("jurnal7_1_103022400104.json");
            var data = JsonSerializer.Deserialize<FilmFavorit_103022400104>(json);

            Console.WriteLine($"Judul Film :{data.title} Nama director :{data.director} Tahun : {data.year} Genre : {data.genre} Rating : {data.rating} Durasi : {data.durationMinutes} Sudah menonton? : {data.isWatched}");
        }
    }
}