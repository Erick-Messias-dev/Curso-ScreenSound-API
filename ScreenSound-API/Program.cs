using ScreenSound_API.Filtros;
using ScreenSound_API.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        LinqFilter.FiltrarMusicasEmCSharp(musicas);
        //musicas[1].ExibirFichaTecnica();

        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michel Teló");

//        var musicasPreferidasDoDaniel = new
//MusicasPreferidas("Daniel");
//        musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1]);
//        musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[377]);
//        musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[4]);
//        musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[6]);
//        musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1467]);

//        musicasPreferidasDoDaniel.ExibirMuscasFavoritas();

        //var musicasPreferidasEmilly = new MusicasPreferidas("Emilly");

        //musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[7]);
        //musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[637]);
        //musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[428]);
        //musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[13]);
        //musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[71]);

        //musicasPreferidasEmilly.ExibirMuscasFavoritas();

        //musicasPreferidasEmilly.GerarArquivoJson();


    }
    catch(Exception ex) 
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
    
    
}