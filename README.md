# RadarrSharp
C# Radarr API wrapper. Still in a beta phase, all methods and properties are subject to change.

## Compatibility
.NET framework, .NET core and Xamarin

## Installation
Available as a NuGet package:
```
PM> Install-Package RadarrSharp
```

## Usage
These are some examples on how to use the API. All methods are async/awaitable. Most methods includes help text on what they do. If you need more information on how the various endpoints works, visit https://github.com/Radarr/Radarr/wiki/API.

Create the client:
```c#
var radarrClient = new RadarrClient("127.0.0.1", 8989, "apiKey");
```

Get all movies:
```c#
var movies = await radarrClient.Movie.GetMovies();
foreach (var movie in movies)
{
    Console.WriteLine($"{movie.Title}");
}
```

Search for movies:
```c#
var command = await.sonarrClient.Command.MoviesSearch(new int[] { 123, 456, 789 });

// Get status of command
Console.WriteLine($"{command.Name}: {command.State}");
```
