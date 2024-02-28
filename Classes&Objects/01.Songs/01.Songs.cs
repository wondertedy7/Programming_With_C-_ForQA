
int numberOfSongs = int.Parse(Console.ReadLine());

List<Song> songsList = new();

for (int i = 0; i < numberOfSongs; i++)
{
    List<string> partsOfSongs = Console.ReadLine().Split("_").ToList();
    string typeList = partsOfSongs[0];
    string SongName = partsOfSongs[1];
    string time = partsOfSongs[2];

    Song songs = new Song()
    {
        TypeList = typeList, 
        Name = SongName,
        Time = time,
    };
    songsList.Add(songs);
}
string command = Console.ReadLine();

if (command != "all")
{
    songsList = songsList.Where(x => x.TypeList == command).ToList();
}

foreach (Song song in songsList)
{
    Console.WriteLine(song.Name);
}



//if (command == "All")
//{
//    foreach (Song song in songsList)
//    {
//        Console.WriteLine(song.Name);
//    }
//}
//else
//{
//    List<Song> filtetredSongs = songsList.Where(x => x.TypeList == command).ToList();
//    foreach (Song song in songsList)
//    {
//        Console.WriteLine(song.Name);
//    }
//}


public class Song
{
    public string TypeList { get; set; }

    public string Name { get; set; }

    public string Time { get; set; }
}


