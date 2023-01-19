using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasseAbstrata
{
    public class Iphone:Smartphone
    {
        public Iphone(string numero, string modelo, string IMEI, int memoria) : base(numero, modelo, IMEI, memoria)
        {

        }

        public void InstalarAplicativo(string nome)
        {
            Console.WriteLine("Apple Store");
            base.InstalarAplicativo(nome);

        }
    }
}
