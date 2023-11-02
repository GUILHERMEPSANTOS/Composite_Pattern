using CompositePattern;

var moviesfolder = new Folder("Filmes");
var actionFolder = new Folder("Action Movies");

var batmanMovie = new CompositePattern.File("batman", 50);
var flashMovie = new CompositePattern.File("flash", 100);

moviesfolder.Add(actionFolder);
moviesfolder.Add(batmanMovie);
moviesfolder.Add(flashMovie);

Console.WriteLine($"Total Size: {moviesfolder.GetSizeInMB()}");