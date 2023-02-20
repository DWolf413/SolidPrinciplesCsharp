using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class Tester : IWorkTeamActivities, ITestActivities
    {
        public Tester()
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
        public void Test()
        {
            throw new ArgumentException();
        }
    }
}
