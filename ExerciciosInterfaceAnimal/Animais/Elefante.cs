using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosInterfaceAnimal.Animais
{
    internal class Elefante:Mamifero
    {
        public Elefante(string nome, DateTime dataNascimento, char sexo, bool carnivoro, bool peconheto, int qtdeMamas, bool pelos, string corDoPelo) : base(nome, dataNascimento, sexo, carnivoro, peconheto, qtdeMamas, pelos, corDoPelo)
        {
        }
    }
}
