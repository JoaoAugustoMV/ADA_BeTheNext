using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciciosInterfaceAnimal.Interfaces;

namespace ExerciciosInterfaceAnimal.Animais
{
    internal class Jacare:Reptil, IAquatico
    {
        public Jacare(string nome, DateTime dataNascimento, char sexo, bool carnivoro, bool peconheto, bool temEscamas, bool temCasco) : base(nome, dataNascimento, sexo, carnivoro, peconheto, temEscamas, temCasco)
        {
        }

        public bool ViveEmTerra { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Mergulho { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool AguaDoce { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
