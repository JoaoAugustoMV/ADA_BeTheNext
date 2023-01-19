using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasseAbstrata
{
    public class Motorola: Smartphone
    {
        public Motorola(string numero, string modelo, string IMEI,int memoria) : base(numero, modelo, IMEI, memoria)
        {

        }

        public void InstalarAplicativo(string nome)
        {
            Console.WriteLine("Play Store");
            base.InstalarAplicativo(nome);

        }
    }
}
