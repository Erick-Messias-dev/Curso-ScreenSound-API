using System.Text.Json;

namespace ScreenSound_API.Modelos;


internal class MusicasPreferidas
{
    public string Nome { get; set; }
    public List<Musica> ListaDeMusicasFavoritas;

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    }
    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMuscasFavoritas()
    {
        Console.WriteLine($"Essas são as músicas favoritas -> {Nome}");
        foreach (var musica in ListaDeMusicasFavoritas)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }
        Console.WriteLine();
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas,
        });
        string nomeDoAquivo = $"Musicas-favoritas-{Nome}.json";

        File.WriteAllText(nomeDoAquivo, json);

        Console.WriteLine($"O arquivo Json foi criado com sucesso!{Path.GetFullPath(nomeDoAquivo)}");
    }
}
