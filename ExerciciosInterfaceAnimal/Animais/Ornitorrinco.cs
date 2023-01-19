using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciciosInterfaceAnimal.Interfaces;

namespace ExerciciosInterfaceAnimal.Animais
{
    internal class Ornitorrinco:Mamifero, IAquatico, IOviparo
    {
        public Ornitorrinco(string nome, DateTime dataNascimento, char sexo, bool carnivoro, bool peconheto, int qtdeMamas, bool pelos, string corDoPelo) : base(nome, dataNascimento, sexo, carnivoro, peconheto, qtdeMamas, pelos, corDoPelo)
        {
        }

        public bool ViveEmTerra { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Mergulho { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool AguaDoce { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Botar()
        {
            throw new NotImplementedException();
        }

        public void Chocar()
        {
            throw new NotImplementedException();
        }
    }
}
