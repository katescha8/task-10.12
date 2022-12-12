using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.IO;
using System;
using Classwork13;

class Program
{
    public static void Task_13_1()
    {
        string path = Directory.GetCurrentDirectory();
        string file_name = "Transactions.txt";
        BankAccount ba = new BankAccount(1000, BankAccountType.Current);
        ba.Holder = "Alexandro";
        ba.WithdrawFromAccount();
        ba.Dispose(path +"/"+ file_name);
        Console.WriteLine(ba.AccountNumber + " - " + ba.Type + " - " + ba.Holder);
    }
    public static void Task_13_2()
    {
        BankAccount ba = new BankAccount(1000, BankAccountType.Current);
        ba[0] = ba.WithdrawFromAccount();
        ba[1] = ba.PutOnAccount();
        ba[2] = ba.WithdrawFromAccount();
        ba.Show_trans();
    }
    public static void HomeTask_13_1()
    {
        Building b = new Building(12, 120, 40, 160, 4);
        Console.WriteLine("Дом номер " + b.Number.ToString() + " высотой " + b.Height.ToString() + " метров, этажей " + b.Floors.ToString() + ", квартир " + b.Flats.ToString() + ", подъездов " + b.Entrance.ToString());
    }
    public static void HomeTask_13_2()
    {
        Yard yard1 = new Yard();
        Building b1 = new Building(5, yard1);
        Building b2 = new Building(6, yard1);
        Building b3 = new Building(7, yard1);
        Building b4 = new Building(8, yard1);
        Building b5 = new Building(12, yard1);
        Building b6 = new Building(9, yard1);
        Building b7 = new Building(10, yard1);
        Building b8 = new Building(11, yard1);
        Building b9= new Building(13, yard1);
        Building b10 = new Building(15, yard1);
        Console.WriteLine(yard1[6].Floors);
    }
    static void Main(string[] args)
        {
            HomeTask_13_2();
        }
    }
