using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork13
{
    enum BankAccountType
    {
        Current,
        Saving
    }
    internal class BankAccount
    {
        public static int i = -1;
        public const int n = 3;
        private int account_number;
        private double balance;
        private BankAccountType type;
        private Queue<BankTransaction> Transactions = new Queue<BankTransaction>();
        public BankTransaction[] transactions;
        private string holder;
        public BankTransaction this[int index]
        {
            get { return transactions[index]; }
            set { transactions[index] = value; }
        }
        public void Show_trans()
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
        public int AccountNumber { get { return account_number; } }
        public BankAccountType Type { get { return type; } }
        public string Holder { get; set; }
        public BankTransaction PutOnAccount()
        {
            Console.Write("Введите сумму для пополнения ");
            double temp = Convert.ToDouble(Console.ReadLine());
            BankTransaction b = new BankTransaction(temp);
            Transactions.Enqueue(b);
            transactions[i++]=b;
            return b;
        }
        public BankTransaction WithdrawFromAccount()
        {

            Console.Write("Введите сумму для снятия ");
            double temp = Convert.ToDouble(Console.ReadLine());
            BankTransaction b = new BankTransaction(temp);
            Transactions.Enqueue(b);
            transactions[i++] = b;
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
    }
}
