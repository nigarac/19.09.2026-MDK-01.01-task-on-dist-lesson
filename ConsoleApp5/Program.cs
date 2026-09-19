using ConsoleApp5;

Parent parent = new Parent();
Thermometer thermometer = new Thermometer();
Weight weight = new Weight();
Barometr barometr = new Barometr();

Console.WriteLine("Введите Инв.Номер");
parent.number = Console.ReadLine();

Console.WriteLine("Введите название");
parent.name = Console.ReadLine();

Console.WriteLine("Введите цвет");
parent.color = Console.ReadLine();

Console.WriteLine("Введите исполнение");
parent.doo = Console.ReadLine();

thermometer.WarningSound();
thermometer.TempSearch();

weight.WarningSound();
weight.WeightSearch();


barometr.WarningSound();
barometr.BarSearch();
