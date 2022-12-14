using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Classwork13
{
    public enum BankAccountType
    {
        Current,
        Saving
    }
    public class BankAccount
    {
        public static int i = -1; //поле для индексации
        public static int n = 3; //точное число операций
        private int account_number;
        private double balance;
        private BankAccountType type;
        private Queue<BankTransaction> Transactions = new Queue<BankTransaction>();
        public BankTransaction[] transactions; //масссив для индексатора
        private string holder; //держатель карты
        public BankTransaction this[int index] //индексатор
        {
            get { return transactions[index]; }
            set { transactions[index] = value; }
        }
        public void Show_trans()//демонстрация обращения к транзакциям по индексу
        {
            for( int i = 0; i < transactions.Length; i++ )
            {
                Console.WriteLine( this[i].CurrentTime.ToString() + " -- " + this[i].Sum.ToString());
            }
        }
        public BankAccount(double balance)
        {
            this.balance = balance;
            Generic();
        }
        public BankAccount(BankAccountType type)
        {
            this.type = type;
            Generic();
        }
        public BankAccount(double balance, BankAccountType type)
        {
            this.balance = balance;
            this.type = type;
            Generic();
            transactions = new BankTransaction[n];
        }

        public void Generic()
        {
            Random r = new Random();
            account_number = r.Next(999, 10000);
        }
        public int AccountNumber { get { return account_number; } } //новое свойство
        public BankAccountType Type { get { return type; } } //новое свойство
        public string Holder { get; set; } //новое свойство
        public BankTransaction PutOnAccount()
        {
            Console.Write("Введите сумму для пополнения ");
            double temp = Convert.ToDouble(Console.ReadLine());
            BankTransaction b = new BankTransaction(temp);
            Transactions.Enqueue(b);
            i++;
            transactions[i]=b;
            return b;
        }
        public BankTransaction WithdrawFromAccount()
        {

            Console.Write("Введите сумму для снятия ");
            double temp = Convert.ToDouble(Console.ReadLine());
            BankTransaction b = new BankTransaction(temp);
            Transactions.Enqueue(b);
            i++; 
            transactions[i] = b;
            if (balance >= temp)
            {
                return b;
            }
            else
            { Console.WriteLine("На вашем счёте недостаточно средств!"); return null; }
        }
        public void Dispose(string path)
        {
            string line;
            StreamWriter sw = File.CreateText(path);
            foreach (BankTransaction t in Transactions)
            {
                line = t.CurrentTime.ToString() + " -- " + t.Sum.ToString();
                sw.WriteLine(line);
            }
            sw.Close();
            GC.SuppressFinalize(this);
        }
        public void DumpToScreen() //для 14 главы
        {
            Console.WriteLine(Holder +": "+ account_number +" - "+ type);
            Show_trans();
        }
    }
}
