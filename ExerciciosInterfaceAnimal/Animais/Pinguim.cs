using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciciosInterfaceAnimal.Interfaces;

namespace ExerciciosInterfaceAnimal.Animais
{
    internal class Pinguim:Ave, IVoar
    {
        public Pinguim(string nome, DateTime dataNascimento, char sexo, bool carnivoro, bool peconheto, bool rapina, string corPena) : base(nome, dataNascimento, sexo, carnivoro, peconheto, rapina, corPena)
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
