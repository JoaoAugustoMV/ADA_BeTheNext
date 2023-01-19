using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosInterfaceAnimal.Animais
{
    internal class Leao:Mamifero
    {
        public Leao(string nome, DateTime dataNascimento, char sexo, bool carnivoro, bool peconheto) : base(nome, dataNascimento, sexo, carnivoro, peconheto)
        {
        }
    }
}
