using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciciosInterfaceAnimal.Interfaces;

namespace ExerciciosInterfaceAnimal.Animais
{
    internal class DragaoDeKomodo:Reptil, IOviparo
    {
        public DragaoDeKomodo(string nome, DateTime dataNascimento, char sexo, bool carnivoro, bool peconheto, bool temEscamas, bool temCasco) : base(nome, dataNascimento, sexo, carnivoro, peconheto, temEscamas, temCasco)
        {
        }

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
