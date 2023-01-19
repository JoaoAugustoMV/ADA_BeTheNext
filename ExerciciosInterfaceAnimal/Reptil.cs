using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosInterfaceAnimal
{
    internal class Reptil:Animal
    {
        public bool TemEscamas { get; set; }
        public bool TemCasco { get; set; }
        public Reptil(string nome, DateTime dataNascimento, char sexo, bool carnivoro, bool peconheto, bool temEscamas, bool temCasco) : base(nome, dataNascimento, sexo, carnivoro, peconheto)
        {
            TemEscamas = temEscamas;
            TemCasco = temCasco;    
        }
    }
}
