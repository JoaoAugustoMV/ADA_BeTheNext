using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciciosInterfaceAnimal.Interfaces;

namespace ExerciciosInterfaceAnimal.Animais
{
    internal class Arara:Animal, IVoar
    {
        public Arara(string nome, DateTime dataNascimento, char sexo, bool carnivoro, bool peconheto) : base(nome, dataNascimento, sexo, carnivoro, peconheto)
        {
        }

        public int AtitudeMaximaEmMetros { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double VelocidadeMaxima { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Voar()
        {
            throw new NotImplementedException();
        }
    }
}
