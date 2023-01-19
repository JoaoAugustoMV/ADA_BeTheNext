using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosInterfaceAnimal
{
    internal class Ave:Animal
    {
        public bool Rapina { get; set; }
        public string CorPena { get; set; }
        public Ave(string nome, DateTime dataNascimento, char sexo, bool carnivoro, bool peconheto, bool rapina, string corPena) : base(nome, dataNascimento, sexo, carnivoro, peconheto)
        {
            Rapina = carnivoro;
            CorPena = corPena;
        }

        public void Ciscar()
        {
            Console.WriteLine($"{Nome} cicou");
        }
    }
}
