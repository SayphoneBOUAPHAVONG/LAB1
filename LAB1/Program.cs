
using System;
using System.Linq;
namespace LAB1;
public class Program
{
    static void Main(string[] args)
    {
        //Для получения данных о резервуарах, отделах и заводах
        var tanks = DataInitialization.GetTanks();// фываф
        var units = DataInitialization.GetUnits();
        var factories = DataInitialization.GetFactories();

        Console.WriteLine($"Количество резервуаров: {tanks.Length}, установок: {units.Length}");

        var foundUnit = UtilityMethods.FindUnit(units, tanks, "Резервуар 2");
        var factory = UtilityMethods.FindFactory(factories, foundUnit);
        Console.WriteLine($"Резервуар 2 принадлежит установке {foundUnit?.Name} и заводу {factory?.Name}");

        var totalVolume = UtilityMethods.GetTotalVolume(tanks);
        Console.WriteLine($"Общий объем резервуаров: {totalVolume}");

        // Output all reservoirs with their unit and factory names
        foreach (var tank in tanks)
        {
            var unit = units.FirstOrDefault(u => u.Id == tank.UnitId);
            var Factory = factories.FirstOrDefault(f => f.Id == unit?.FactoryId);
            Console.WriteLine($"Резервуар: {tank.Name}, Установка: {unit?.Name}, Завод: {Factory?.Name}");
        }

        // Search functionality
        Console.Write("Введите название резервуара для поиска: ");
        string searchName = Console.ReadLine();
        var foundTank = tanks.FirstOrDefault(t => t.Name == searchName);
        if (foundTank != null)
        {
            Console.WriteLine($"Резервуар найден: {foundTank.Name}, Установка: {units.FirstOrDefault(u => u.Id == foundTank.UnitId)?.Name}");
        }
        else
        {
            Console.WriteLine("Резервуар не найден.");
        }
    }
}
