# RadarrSharp
C# [Radarr](https://radarr.video/) API wrapper. Still in a beta phase so all methods and properties are subject to change. Some methods are yet to be implemented.

## Compatibility
Written as a .NET Standard library, so should be compatible with .NET framework, .NET core and Xamarin.

## Installation
Available as a NuGet package:
```
PM> Install-Package RadarrSharp
```

## Known Issues
- UpdateMovie method not working. Returns server exception. Under investigation.

## Available Endpoints:
**Calendar:**
*Gets upcoming movies*

**Command:**
*Initiate movie search, refresh, rss sync, rename etc.*

**Diskspace:**
*Gets information about Diskspace*

**History:**
*Gets history (grabs/failures/completed)*

**Movie:**
*Get, update, delete or add movies*

**Profile:**
*Gets all quality profiles*

**SystemStatus:**
*Returns system status*

**Wanted:**
*Returns missing, and movies that has not achieved it's cutoff quality.

## Usage
These are some examples on how to use the API. All methods are async/awaitable. Most methods includes help text on what they do. If you need more information on how the various endpoints works, visit https://github.com/Radarr/Radarr/wiki/API.

Create the client:
```c#
var radarrClient = new RadarrClient("127.0.0.1", 8989, "apiKey");
```

Get all movies:
```c#
var movies = await radarrClient.Movie.GetMovies();
foreach (var item in movies)
{
    Console.WriteLine($"{item.Title}");
}
```

Search for movies:
```c#
var command = await.sonarrClient.Command.MoviesSearch(new int[] { 123, 456, 789 });

// Get status of command
Console.WriteLine($"{command.Name}: {command.State}");
```
