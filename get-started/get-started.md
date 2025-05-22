# GET STARTED WITH C SHARP

## Tour of CSharp

CSharp adalah bahasa yang menyediakan banyak fitur untuk developer berpengalaman dan juga mudah dipelajari untuk pemula.

Strongly typed dan secara sintaks sangat dekat dengan C.

### Hello world

Ini adalah cara menuliskan "Hello world" di CSharp

```C#
// This line prints "Hello, World" 
Console.WriteLine("Hello, World");
```

Code di atas sudah mengalami penyederhanaan. Dulu untuk menuliskan hello world kita menuliskannya seperi ini.

```C#
using System;
﻿namespace TourOfCsharp;

class Program
{
    static void Main()
    {
        // This line prints "Hello, World" 
        Console.WriteLine("Hello, World");
    }
}
```

Tapi sekarang kita tidak perlu berbelit-belit menuliskan class Program. Semua sudah dilakukan di balik layar oleh compiler.

### Fitur CSharp

CSharp merupakan tools yang kaya fitur. Programmer berpengalaman akan sangat dimanjakan oleh kayanya fitur tapi tidak membuat pemula menjadi segan.

Beberapa fitur CSharp:

- automatic memory menagement
- ekosistem yang komplit dengan dukungan .NET dan NuGet
- strongly typed
- pattern matching

```C#
public static bool Or(bool left, bool right) =>
    (left, right) switch
    {
        (true, true) => true,
        (true, false) => true,
        (false, true) => true,
        (false, false) => false,
    };

public static bool And(bool left, bool right) =>
    (left, right) switch
    {
        (true, true) => true,
        (true, false) => false,
        (false, true) => false,
        (false, false) => false,
    };
public static bool Xor(bool left, bool right) =>
    (left, right) switch
    {
        (true, true) => false,
        (true, false) => true,
        (false, true) => true,
        (false, false) => false,
    };

    // gunakan _ sebagai wildcard.
    public static bool ReducedAnd(bool left, bool right) =>
    (left, right) switch
    {
        (true, true) => true,
        (_, _) => false,
    };

```

- sintaks sederhana untuk collections data type

```C#
int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
List<string> names = ["Alice", "Bob", "Charlie", "David"];

IEnumerable<int> moreNumbers = [.. numbers, 11, 12, 13];
IEnumerable<string> empty = [];

string second = names[1]; // 0-based index
string last = names[^1]; // ^1 artinya ambil item kesatu tapi dari belakang.
int[] smallNumbers = numbers[0..5]; // 0 to 4
```

- LINQ dan

```C#
var honorRoll = from student in Students
                where student.GPA > 3.5
                select student;
```

- async await

```C#
public static async Task<int> GetPageLengthAsync(string endpoint)
{
    var client = new HttpClient();
    var uri = new Uri(endpoint);
    byte[] content = await client.GetByteArrayAsync(uri);
    return content.Length;
}

// Untuk tugas asynchronous yang jamak.
public static async IAsyncEnumerable<int> ReadSequence()
{
    int index = 0;
    while (index < 100)
    {
        int[] nextChunk = await GetNextChunk(index);
        if (nextChunk.Length == 0)
        {
            yield break;
        }
        foreach (var item in nextChunk)
        {
            yield return item;
        }
        index++;
    }
}
```
