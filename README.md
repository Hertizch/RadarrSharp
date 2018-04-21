# RadarrSharp
C# [Radarr](https://radarr.video/) API wrapper. Still in a beta phase so all methods and properties are subject to change. Some methods are yet to be implemented, and others may not even work.

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
>**Calendar:** Returns upcoming movies

>**Command:** Initiate movie search, refresh, rss sync, rename etc.

>**Diskspace:** Returns information about Diskspace

>**History:** Returns history (grabs/failures/completed)

>**Movie:** Get, update, delete or add movies

>**Profile:** Gets all quality profiles

>**SystemStatus:** Returns system status

>**Wanted:** Returns missing, and movies that has not achieved it's cutoff quality.

>**Queue:** Returns currently downloading info

>**Release:** Returns releases from Radarr's search cache

>**QualityDefinition:** Returns quality definitions

>**Indexer:** Returns configured indexers

## Usage
These are some examples on how to use the API. All methods are async/awaitable. Most methods includes help text on what they do. If you need more information on how the various endpoints works, visit https://github.com/Radarr/Radarr/wiki/API.

Create the client:
```c#
var radarrClient = new RadarrClient("127.0.0.1", 7878, "apiKey");
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
var command = await radarrClient.Command.MoviesSearch(new int[] { 123, 456, 789 });

// Get status of command
Console.WriteLine($"{command.Name}: {command.State}");
```

Get downloading movies:
```c#
var queue = await radarrClient.Queue.GetQueue();
foreach (var item in queue)
{
    Console.WriteLine($"{item.Status}: {item.Title}");
}
```
