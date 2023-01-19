using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosInterfaceAnimal
{
    public abstract class Animal
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public char Sexo { get; set; }
        public bool Carnivoro { get; set; }
        public bool Peconheto { get; set; }
        public Animal(string nome, DateTime dataNascimento, char sexo, bool carnivoro, bool peconheto)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Sexo = sexo;
            Carnivoro = carnivoro;
            Peconheto = peconheto;  
        }

        public int Idade()
        {
            return DateTime.Now.Year - this.DataNascimento.Year;
        }

        public void Movimentar()
        {
            Console.WriteLine($"{Nome} se movimentou");
        }
        public void Comunicar()
        {
            Console.WriteLine($"{Nome} se comunicou");
        }
        public void Alimentar()
        {
            Console.WriteLine($"{Nome} se alimentou");

        }
      
    }
}
