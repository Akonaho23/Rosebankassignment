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
        decimal measurement;
        String Name;
        int originalQuantity;
        int Quantity;
        decimal numCalories;
        String foodGroup;



        public Ingridient(String name, int Quantity,decimal measurement, decimal numCalories, String foodGroup ) { 
            this.Name = name;
            this.Quantity = Quantity; 
            this.measurement = measurement;
            this.originalQuantity= Quantity;
            this.numCalories = numCalories; 
            this.foodGroup = foodGroup; 
            
        }

        public String getName { get { return this.Name; } }
        public int getQuantity { get { return this.Quantity; } }
        
        public decimal getMeasurement() { return this.measurement; }    

        public decimal getnumCalories { get { return this.numCalories; } }
        public String getfoodGroup { get { return this.foodGroup; } }
        public int getOriginalQuantity { get { return this.originalQuantity; } }
        public void setQuantity(int quantity) { this.Quantity = quantity;}

    }
}
