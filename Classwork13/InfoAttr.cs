using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[AttributeUsage(AttributeTargets.Class)]
    public class DevInfoAttribute : Attribute //для домашнего задания 14.1
    {
        public DevInfoAttribute(string developer, string firma)
        { this.developer = developer; this.firma = firma; }
        public string developer;
        public string firma;
    }