using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciciosInterfaceAnimal.Interfaces;

namespace ExerciciosInterfaceAnimal.Animais
{
    internal class Morcego:Mamifero, IVoar
    {
        public Morcego(string nome, DateTime dataNascimento, char sexo, bool carnivoro, bool peconheto, int qtdeMamas, bool pelos, string corDoPelo) : base(nome, dataNascimento, sexo, carnivoro, peconheto, qtdeMamas, pelos, corDoPelo)
        {
        }

        public int AtitudeMaximaEmMetros { get; set; }
        public double VelocidadeMaxima { get; set; }

        public void Voar()
        {
            Console.WriteLine("Morcego voou");
        }
    }
}
