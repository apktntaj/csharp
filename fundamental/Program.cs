============== HOW TO DISPLAY ARGUMENTS ==============

Console.WriteLine($"paramater count = {args.Length}")

for (int i = 0; i < args.Length; i++) {
    Console.WriteLine($"arg[{i}] = {args[i]}");
}
