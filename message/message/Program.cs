using system;


class PLManager
{


    public readonly String filepath;

    private String _currentSong;

    public string CurrentSong {
        get ==> _currentSong;
    }

    private String _listName;

    public readonly List<String> _playlist = new List<string>();


    public List<string> Playlist
    {
        get
        {

            List<String> newLIST = new List<string>();
