
//Этот файл содержит классы. Инициализация данных С функциями создания исходных данных для танков, агрегатов и заводов.
public static class DataInitialization
{
    public static Tank[] GetTanks()
    {
        //возвращает массив объектов Tank, содержащий информацию о танках.
        return new Tank[]
        {
            new Tank { Id = 1, Name = "Резервуар 1", Description = "Надземный - вертикальный", Volume = 1500, MaxVolume = 2000, UnitId = 1 },
            new Tank { Id = 2, Name = "Резервуар 2", Description = "Надземный - горизонтальный", Volume = 2500, MaxVolume = 3000, UnitId = 1 },
            new Tank { Id = 3, Name = "Дополнительный резервуар 24", Description = "Надземный - горизонтальный", Volume = 3000, MaxVolume = 3000, UnitId = 2 },
            new Tank { Id = 4, Name = "Резервуар 35", Description = "Надземный - вертикальный", Volume = 3000, MaxVolume = 3000, UnitId = 2 },
            new Tank { Id = 5, Name = "Резервуар 47", Description = "Подземный - двустенный", Volume = 4000, MaxVolume = 5000, UnitId = 2 },
            new Tank { Id = 6, Name = "Резервуар 256", Description = "Подводный", Volume = 500, MaxVolume = 500, UnitId = 3 }
        };
    }

    public static Unit[] GetUnits()
    {
        return new Unit[]
        {
            new Unit { Id = 1, Name = "ГФУ-2", Description = "Газофракционирующая установка", FactoryId = 1 },
            new Unit { Id = 2, Name = "ABT-6", Description = "Атмосферно-вакуумная трубчатка", FactoryId = 1 },
            new Unit { Id = 3, Name = "ABT-10", Description = "Атмосферно-вакуумная трубчатка", FactoryId = 2 }
        };
    }

    public static Factory[] GetFactories()
    {
        return new Factory[]
        {
            new Factory { Id = 1, Name = "НПЗNФ1", Description = "Первый нефтеперерабатывающий завод" },
            new Factory { Id = 2, Name = "НПЗNФ2", Description = "Второй нефтеперерабатывающий завод" }
        };
    }
}
