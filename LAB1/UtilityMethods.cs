//UtilityMethods С функциями поиска и расчета данных
public static class UtilityMethods
{
    public static Unit FindUnit(Unit[] units, Tank[] tanks, string tankName)
    {
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
