using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Team
    {
       
        public List<Worker> Workers { get; set; }

        public Team(List<Worker> workers)
        {
          
            Workers = workers;
        }

        public void AddWorker (Worker worker){
            Workers.Add(worker);
        }

        public Team()
        {
            Workers = new List<Worker>();
        }
    }
}
