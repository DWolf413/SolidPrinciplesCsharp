using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class Developer : IWorkTeamActivities, IDevelopActivities
    {
        public Developer()
        {
        }

        public void Plan()
        {
            throw new ArgumentException();
        }

        public void Comunicate()
        {
            throw new ArgumentException();
        }
              
        public void Develop()
        {
            Console.WriteLine("I'm developing the functionalities required");
        }

    }
}

