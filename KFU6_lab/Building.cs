using System;
namespace KFU6_lab
{
    public class Building
    {
        private int uniqueNumber;
        private int Height;
        private int Floors;
        private int Apartments;
        private int Entrances;

        public Building(int height, int floors, int apartments, int entrances)
        {
            Height = height;
            Floors = floors;
            Apartments = apartments;
            Entrances = entrances;
            uniqueNumber = getNextUniqueNumber();
        }
        private static int nextUniqueNumber = 1;

        public int GetUniqueNumber()
        {
            return uniqueNumber;
        }

        public int GetHeight()
        {
            return Height;
        }

        public int GetFloors()
        {
            return Floors;
        }

        public int GetApartments()
        {
            return Apartments;
        }

        public int GetEntrances()
        {
            return Entrances;
        }

        public int GetApartmentsOnFloor()
        {
            return Apartments / Floors;
        }

        public int GetApartmentsInEntrance()
        {
            return Apartments / Entrances;
        }

        public int GetFloorHeight()
        {
            return Height / Floors;
        }
        private static int getNextUniqueNumber()
        {
            int uniqueNumber = nextUniqueNumber;
            nextUniqueNumber++;
            return uniqueNumber;
        }

        public override string ToString()
        {
            return $"Номер здания: {uniqueNumber}, высота: {Height}, этажность: {Floors}, количество квартир: {Apartments}, количество подъездов: {Entrances}";
        }


    }
}

