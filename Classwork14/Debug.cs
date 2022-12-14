using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Classwork13;

public class Debug_Account
 {
       [Conditional("DEBUG_ACCOUNT")] 
       public static void MyMethod(BankAccount ba) 
       {
        ba.DumpToScreen();
       }
 }