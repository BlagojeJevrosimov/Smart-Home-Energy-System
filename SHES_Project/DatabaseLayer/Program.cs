using Common;
using DatabaseLayer.DAO;
using DatabaseLayer.DAO.Implementacije;
using DatabaseLayer.SERVICES;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
    [ExcludeFromCodeCoverage]
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(DBServices))){
                host.CloseTimeout = new TimeSpan(0,10,0);
                host.OpenTimeout = new TimeSpan(0, 10, 0);
                host.Open();
                while (true) ;
               
            }
        }
    }
}
