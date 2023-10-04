using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserveParrern.Models
{
    internal class NewAgencys : IAgencys
    {
        private string Name { get; set; }
        public NewAgencys(string name) 
        {
            Name = name;
        }

        public void UpdateTEmperature(float Temperature)//this upadate when subject state changes
        {
           
            
           
                Console.WriteLine($"Name of Agency provided state\t{Name}\t" +
                $"Updated Temperature : {Temperature}");
               
            
            Console.WriteLine("=================================================");
        }
    }
}
