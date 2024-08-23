using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula3_cs_ex5
{
    public class Converter
    {
        public List<double> convertor(List<string> listaS) 
        {
            List<double> listaI = new List<double>();

            listaI= listaS.ConvertAll(double.Parse);

            return listaI;
        }
        public double logica(List<double> listaD) 
        {
            double resultado1 = (listaD[0] + listaD[1] + listaD[2]) / 2.0;
            double area = Math.Sqrt(resultado1 * (resultado1 - listaD[0]) * (resultado1 - listaD[1]) * (resultado1 - listaD[2]));

            return area;
        } 
    }
}
