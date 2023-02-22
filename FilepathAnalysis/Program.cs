using AdippNet;
using AdippNet.Models;

var cwd = AppDomain.CurrentDomain.BaseDirectory;
var watchlist = new Watchlist(Path.Combine(cwd, "watchlist.json"));

void FilepathAnalysis(MediaFile file)
{
    var bookmarks = new List<Bookmark>();
    foreach (var filesystemMetadata in file.Files)
    {
        bookmarks.AddRange(watchlist.Search(filesystemMetadata.DisplayDirectory, "FilepathAnalysis"));
    }
    file.AddBookmarks(bookmarks);
    
}

var plugin = new Adipp();
plugin.AddAction(FilepathAnalysis);

plugin.Run();