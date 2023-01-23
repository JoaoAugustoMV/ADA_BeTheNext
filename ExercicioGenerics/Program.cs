//Você foi contratado pela escola de idiomas “Let’s Speak” para a construção de uma aplicação de dicionário para os alunos.
//A aplicação deve ser construída conforme os requisitos a seguir.

//A aplicação deve armazenar termosSalvos e seus significados. Os termosSalvos podem ser compostos de uma ou mais palavras (como, por exemplo, no caso de phrasal verbs e expressões idiomáticas). OK

//A aplicação deve permitir que o aluno insira novos termosSalvos sempre que julgar necessário. A aplicação deve permitir a busca de termosSalvos, não havendo distinção entre maiúsculas e minúsculas. OK

//A busca deve ser feita apenas nos termosSalvos (não deve fazer buscas nas definições). Quando nenhum termo correspondente à busca for encontrado, a aplicação deve exibir na tela a mensagem “Nenhum termo encontrado” OK
//.
//Caso contrário, devem ser exibidos todos os termosSalvos que correspondem à palavra buscada. A aplicação não deve aceitar Wildcards (* e ?), a busca será feita usando-se somente palavras inteiras ou parte de palavras. OK

//Por exemplo, ao buscar por pea, o sistema deve retornar termosSalvos como speak, pear, peacock, spears, etc.

//A aplicação deve salvar os dados em um arquivo no disco de forma que, ao ser iniciada, todos os termosSalvos salvos sejam carregados. OK
namespace ExercicioGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> termosSalvos = new();
            string uri = "C:/ADA/POO_2/ExercicioGenerics/TermosSalvos.txt";

            StreamReader streamReader;
            streamReader = File.OpenText(uri);

            while(!streamReader.EndOfStream)
            {
                string linha = streamReader.ReadLine(); // Linha Atual
                string[] subString = linha.Split(":");
                termosSalvos.Add(subString[0], subString[1]);
            }

            streamReader.Close();

            bool continuar = true;
            do 
            {
                Console.Clear();

                Console.WriteLine("1 - Adicionar Novo Termo");
                Console.WriteLine("2 - Procurar Termo");
                Console.WriteLine("3 - Sair");

                bool validacao = int.TryParse(Console.ReadLine(), out int opcao);
                if(validacao)
                {
                    switch(opcao)
                    {
                        case 1:
                            Console.WriteLine("Adicionar Novo Termo");
                            AdicionarTermo(termosSalvos);
                        break;

                        case 2:
                            Console.WriteLine("Procurar Termo");
                            Console.WriteLine("Informe o termo desejado");
                            string termo = Console.ReadLine();
                            ProcurarTermo(termo, termosSalvos);
                        break;

                        case 3:
                            continuar  = false;
                        break;

                        default:
                            Console.WriteLine("Opcao Invalida");
                        break;
                    }

                }

            } while(continuar);

        }

        private static void ProcurarTermo(string termoDesajado, Dictionary<string, string> termosSalvos)
        {
            bool termoEncontrado = false;
            foreach(KeyValuePair<string, string> termo in termosSalvos)
            {
                if(termo.Key.Contains(termoDesajado))
                {
                    //termosResultado.Add(termo.Key, termo.Value);
                    Console.WriteLine($"{termo.Key}: {termo.Value}");
                    termoEncontrado = true;
                }
            }

            if(!termoEncontrado)
            {
                Console.WriteLine("Nenhum termo encontrado");
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar");
            Console.ReadKey();

        }
        
        private static void AdicionarTermo(Dictionary<string, string> dicionario)
        {
           

            Console.WriteLine("Informe o termo:");
            string termo = Console.ReadLine().ToLower();

            Console.WriteLine("Informe o significado:");
            string significado = Console.ReadLine().ToLower();

           
            Console.WriteLine("\nTermo Adicionado, pressione qualquer tecla para continuar");
            Console.ReadKey();

            dicionario.Add(termo, significado);

            string uri = "C:/ADA/POO_2/ExercicioGenerics/TermosSalvos.txt";

            StreamWriter streamWriter = new(uri, true);
            streamWriter.WriteLine($"{termo}:{significado}");

            //streamWriter.
            streamWriter.Close();
        }


    }
}