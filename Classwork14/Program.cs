#define DEBUG_ACCOUNT //символ условной компиляции
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.IO;
using System;
using Classwork13;
using System.Diagnostics;

class Program
{
    public static void Task_14_1()
    {
        BankAccount ba = new BankAccount(1000, BankAccountType.Current);
        ba.Holder = "Alexandro";
        ba.WithdrawFromAccount();
        ba.PutOnAccount();
        ba.WithdrawFromAccount();
        Debug_Account.MyMethod(ba);
    }
    public static void Task_14_2()
    {
        Q q = new Q();
    }
    public static void HomeTask_14_1()
    {
        Building b = new Building(12, 120, 40, 160, 4);
    }
    static void Main(string[] args)
    {
        HomeTask_14_1();
    }
}