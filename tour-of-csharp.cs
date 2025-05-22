// This is how to write a simple C# program
Console.WriteLine("Hello, World!");


=================== C# Tour ===================

// Menyediakan banyak fitur modern tapi juga ramah untuk dipelajari untuk programmer pemula.
// Strongly typed
// Mendukung overloading, event, dan OOP.
Menggunakan exception saat terjadi error
// Menggunakan garbage collector untuk mengelola memory
// Mendukung multi-threading
// Mendukung asynchronous programming
// Mendukung async/await


// Mendukung pattern matching
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
        (true, true) => true, // (true, true) adalah tuple, data structure ringan (seperti array)
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

    // Gunakan _ untuk menangkap semua nilai
    public static bool ReducedAnd(bool left, bool right) =>
    (left, right) switch
    {
        (true, true) => true,
        (_, _) => false, // nilai apapun akan menghasilkan false (kecuali true, true karena sudah ditangkap di atas)
    };


// Beberapa cara membuat koleksi data dan cara untuk mangaksesnya.
int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
List<string> names = ["Alice", "Bob", "Charlie", "David"];

IEnumerable<int> moreNumbers = [.. numbers, 11, 12, 13]; // sintaks .. digunakan untuk menggabungkan array
IEnumerable<string> empty = [];

string second = names[1];
string last = names[^1]; // ^1 artinya ambil 1 dari belakang
int[] smallNumbers = numbers[0..5]; // 0 to 4


// Mendukung LINQ
var honorRoll = from student in Students
                where student.GPA > 3.5
                select student;

Console.WriteLine(honorRoll);