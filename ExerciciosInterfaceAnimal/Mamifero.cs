using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosInterfaceAnimal
{
    internal abstract class Mamifero:Animal
    {
        public int QtdeMamas { get; set; }
        public bool Pelos { get; set; }
        public string CorDoPelo { get; set; }
        public Mamifero(string nome, DateTime dataNascimento, char sexo, bool carnivoro, bool peconheto, int qtdeMamas, bool pelos, string corDoPelo) : base(nome, dataNascimento, sexo, carnivoro, peconheto)
        {
            QtdeMamas = qtdeMamas;
            Pelos = pelos; 
            CorDoPelo = corDoPelo;
        }

        public void Amamentar()
        {
            Console.WriteLine($"{Nome} amamentou ");
        }
    }
}
