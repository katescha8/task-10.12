using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork13
{
    [DevInfo("katescha8", "K(P)FU IVMIIT")] //для домашнего задания 14.1
    public class Building
    {
        public static int i = -1;
        private int number;
        public int Number
        {
            get => number;
            set => number = value;
        }
        private ushort height;
        public ushort Height
        {
            get => height;
            set => height = value;
        }
        private byte number_of_floors;
        public byte Floors
        {
            get => number_of_floors;
            set => number_of_floors = value;
        }
        private ushort number_of_flats;
        public ushort Flats
        {
            get => number_of_flats;
            set => number_of_flats = value;
        }
        private byte number_of_entrances;
        public byte Entrance
        {
            get => number_of_entrances;
            set => number_of_entrances = value;
        }
        static Random r = new Random();
        public static int generic_number = r.Next(1000);
        public Building(int n, ushort h, byte floors, ushort flats, byte entrances)
        {
            this.number = n;
            this.height = h;
            this.number_of_floors = floors;
            this.number_of_flats = flats;
            this.number_of_entrances = entrances;
        }
        internal Building(byte floors, Yard y)
        {
            this.number_of_floors = floors;
            y.yard[++i] = this;
        }
        public int FloorHeight(ushort h, byte f)
        {
            int temp = h / f;
            return temp;
        }
        public int FlatsInEntrance(ushort f, byte e)
        {
            int temp = f / e;
            return temp;
        }
        public int FlatsOnFloor(ushort flats, byte e, byte floors)
        {
            int temp = (flats / e) / (floors - 1);
            return temp;
        }
    }
}
