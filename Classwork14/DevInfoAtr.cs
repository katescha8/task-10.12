using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[AttributeUsage(AttributeTargets.Class)]
public class DeveloperInfoAttribute : Attribute //для упражнения 14.2
{
    public DeveloperInfoAttribute(string developer)
    { this.developer = developer; }
    public string developer;
    public string date;
}


