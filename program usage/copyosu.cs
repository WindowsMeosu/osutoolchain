 public static void Main()
    {    
        string scat = Environment.ExpandEnvironmentVariables("%localAppData%\\osu!/mappool");
        string tcat = Environment.ExpandEnvironmentVariables("%localAppData%\\osu!tourney/Songs");
        DirectoryInfo sourcedir = new DirectoryInfo(scat);
        DirectoryInfo targetdir = new DirectoryInfo(tcat);

        CopyDir(sourcedir, targetdir);
    }

 }
 
 /* full code seen here: https://github.com/WindowsMeosu/osu-tourney-setup/blob/master/Program.cs */
