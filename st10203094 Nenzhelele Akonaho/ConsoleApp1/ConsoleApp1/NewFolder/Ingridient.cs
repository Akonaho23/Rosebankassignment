using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.NewFolder
{
    internal class Ingridient
    {
        decimal Measurement;
        String Name;
        int originalQuantity;
        int Quantity;
        
        

        public Ingridient(String name, int Quantity, decimal measurement) { 
            this.Name = name;
            this.Quantity = Quantity; 
            this.Measurement = measurement;
            this.originalQuantity= Quantity;
            
        }

        public String getName { get { return this.Name; } }
        public int getQuantity { get { return this.Quantity; } }
        public decimal getMeasurement { get { return this.Measurement; } }

        public int getOriginalQuantity { get { return this.originalQuantity; } }
        public void setQuantity(int quantity) { this.Quantity = quantity;}

    }
}
