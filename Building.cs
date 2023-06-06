using System;

namespace TheBuilding;

    public class Building
    {
        private int _floorCount;
        private int _size;

    public Building(int floorCount, int size)
    {
        _floorCount = floorCount;
        _size = size;
    }

    public Building(int floorCount)
    {
        _floorCount = floorCount;
        _size = 3 * floorCount;
    }

    public int GetFloorMaxSize()
    {
        return _size / _floorCount;
    }

    public int GetFloorCount()
    {
        return _floorCount;
    }

    public int GetSize()
    {
        return _size;
    } 
    }


