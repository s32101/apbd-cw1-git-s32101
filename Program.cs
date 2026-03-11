// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, PJATK!");
Console.WriteLine();

Console.WriteLine("Super Kalkulator 6000 PRO MAX Ultra Galaxy 2");

Console.WriteLine("Trwa uruchamianie...........");
Thread.Sleep(2000); // a niech sobie poczekają użytkownicy

int podajLiczbe(string jaką) {
    Console.Write($"Podaj liczbe {jaką}: ");
    return int.Parse(Console.ReadLine() ?? throw new ArgumentNullException("nie"));
}

var a = podajLiczbe("A");
var b = podajLiczbe("B");

Console.WriteLine("Trwa liczenie.. (:");
Thread.Sleep(5000); // teraz program jest lepszy

Console.WriteLine("a + b = " + (a + b));