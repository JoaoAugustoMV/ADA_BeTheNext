using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciciosInterfaceAnimal.Interfaces;

namespace ExerciciosInterfaceAnimal.Animais
{
    internal class Cisne:Animal, IAquatico
    {
        public Cisne(string nome, DateTime dataNascimento, char sexo, bool carnivoro, bool peconheto) : base(nome, dataNascimento, sexo, carnivoro, peconheto)
        {
        }

        public bool ViveEmTerra { get; set; }
        public bool Mergulho { get; set; }
        public bool AguaDoce { get; set; }
    }
}
