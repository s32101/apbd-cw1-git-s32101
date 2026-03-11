// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, PJATK!");
Console.WriteLine();

Console.WriteLine("Super Kalkulator 6000 PRO MAX Ultra Galaxy 2");

Console.WriteLine("Trwa uruchamianie...........");
Thread.Sleep(1000); // a niech sobie poczekają użytkownicy

int podajLiczbe(string jaką) {
    Console.Write($"Podaj liczbe {jaką}: ");
    return int.Parse(Console.ReadLine() ?? throw new ArgumentNullException("nie"));
}

var a = podajLiczbe("A");
var b = podajLiczbe("B");

Console.WriteLine("Trwa liczenie.. (:");
Thread.Sleep(2000); // teraz program jest lepszy

Console.WriteLine("a + b = " + (a + b));
Console.WriteLine();

int[] array = new int[] { 1, 2, 3 };
Console.WriteLine("zobacz zobacz mamy array int[] { 1, 2, 3 } to teraz wywolamy klase z zadania:");
Console.WriteLine("srednia: " + StatisticsHelper.CalculateAverage(array));
Console.WriteLine("max: " + StatisticsHelper.CalculateMax(array));