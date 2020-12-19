using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceRest_20180140086_SandiEkaYuda;
using System.ServiceModel;

namespace ServerConfigRest_20180140086_SandiEkaYada
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost hostObjek = null;

            try
            {
                hostObjek = new ServiceHost(typeof(TI_UMY));
                hostObjek.Open();
                Console.WriteLine("Server Ready");
                Console.ReadLine();
                hostObjek.Close();
            }
            catch (Exception ex)
            {
                hostObjek = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}