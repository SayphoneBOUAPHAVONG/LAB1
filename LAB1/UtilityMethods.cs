
//Поиск подразделений и заводов или расчет общего количества

using LAB1.Models;

namespace LAB1;
public static class UtilityMethods
{
    public static Unit FindUnit(Unit[] units, Tank[] tanks, string tankName)
    {
        // LINQ
        var tank = tanks.FirstOrDefault(t => t.Name == tankName);
        if (tank != null)
        {
            return units.FirstOrDefault(u => u.Id == tank.UnitId);
        }
        return null;
    }

    public static Factory FindFactory(Factory[] factories, Unit unit)
    {
        return factories.FirstOrDefault(f => f.Id == unit.FactoryId);
    }

    public static int GetTotalVolume(Tank[] tanks)
    {
        return tanks.Sum(t => t.Volume);
    }
}
