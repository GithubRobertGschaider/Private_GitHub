using System;
using namespace_Panda;
using namespace_Dude;
using System.Text;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;

class Main_Class
{
    static void Main()
    {
        Panda p1 = new Panda("Fox");
        Panda p2 = new Panda("Rabbit");

        // These types are in System.Diagnostics:
        string procName = Process.GetCurrentProcess().ProcessName;
        using (PerformanceCounter pc = new PerformanceCounter
        ("Process", "Private Bytes", procName))
            Console.WriteLine(pc.NextValue());

        Console.WriteLine(p1.Name);
        Console.WriteLine(p2.Name);
        Console.WriteLine(p1.Population_instance);
        Console.WriteLine(p2.Population_instance);
        Console.WriteLine(Panda.Population);
        int i = new int();
        Console.WriteLine(i);

        Dude d1 = new Dude("John");
        Dude d2 = new Dude("John");
        Dude d3 = d1;                   //d3 refererar till data i d1
        d1.DudeSetName("Guidetti");
        Console.WriteLine(d1.Name);
        Console.WriteLine(d2.Name);
        Console.WriteLine(d3.Name);     //Pekar och skriver ut datat från p1.Name
        Console.WriteLine(d1.Name == d1.Name);  // True för att det är samma data
        Console.WriteLine(d1.Name == d2.Name);  // False för att det inte är samma data, men innehållet i d1 och d2 är detsamma
        Console.WriteLine(d1.Name == d3.Name);  // True för att det är samma data då d3 pekar mot d1  
        System.IO.File.WriteAllText("data.txt", d1.Name + " " + d2.Name + " " + d3.Name + " ", Encoding.Unicode);
        Console.WriteLine(DateTime.Now); // 11/11/2015 1:23:45 PM
        Console.WriteLine(DateTimeOffset.Now); // 11/11/2015 1:23:45 PM -06:00
        Random r1 = new Random(1);
        Random r2 = new Random(1);
        Console.WriteLine(r1.Next(100) + ", " + r1.Next(100)); // 24, 11
        Console.WriteLine(r2.Next(100) + ", " + r2.Next(100)); // 24, 11
        var rand = System.Security.Cryptography.RandomNumberGenerator.Create();
        byte[] bytes = new byte[32];
        rand.GetBytes(bytes); // Fill the byte array with random numbers.
        Console.WriteLine(bytes[0]);
        Guid g = Guid.NewGuid();
        Console.WriteLine(g.ToString()); // 0d57629c-7d6e-4847-97cb-9e2fc25083fe
        Console.WriteLine("Beck".CompareTo("Anne")); // 1
        Console.WriteLine("Beck".CompareTo("Beck")); // 0
        Console.WriteLine("Beck".CompareTo("Chris")); // -1
        Console.WindowWidth = Console.LargestWindowWidth;
        Console.ForegroundColor = ConsoleColor.Green;
        // First save existing output writer:
        System.IO.TextWriter oldOut = Console.Out;
        // Redirect the console's output to a file:
        ProcessStartInfo psi = new ProcessStartInfo
        {
            FileName = "cmd.exe",
            Arguments = "/c ipconfig /all",
            RedirectStandardOutput = true,
            UseShellExecute = false
        };
        Process p = Process.Start(psi);
        string result = p.StandardOutput.ReadToEnd();
        Console.WriteLine(result);
        using (System.IO.TextWriter w = System.IO.File.CreateText("c:\\temp\\output.txt"))
        {
            Console.SetOut(w);
            Console.WriteLine(result);
        }
        // Restore standard console output
        Console.SetOut(oldOut);
        // Open the output.txt file in Notepad:
        System.Diagnostics.Process.Start("c:\\temp\\output.txt");
        string[] names = { "Tom", "Dick", "Harry" };
        var filteredNames = names.Where(n => n.Length >= 4);
        foreach (string name in filteredNames) Console.WriteLine(name);
        foreach (char c in "string1") Console.Write(c);
        foreach (char c in "string2") Console.Write(c);
        foreach (char c in "string3") Console.Write(c);
        var filtered = names.Where(n => n.Contains("a"));
        var sorted = filtered.OrderBy(n => n);
        var query = sorted.Select(n => n.ToUpper());

        // These types are in System.Diagnostics:
        using (PerformanceCounter pc = new PerformanceCounter
        ("Process", "Private Bytes", procName))
            Console.WriteLine(pc.NextValue());


        Console.ReadKey();

    }
}