using System.ComponentModel;
using System.IO.Pipes;

namespace classes
{
    internal class Carro
    {
        public string Marca { get; set; }
        private string Modelo { get; set; }
        private int ano;
        public int Ano
        {
            get { return ano; } //retorna para o usuario o dado que foi pedido, nesse caso o ano
            set
            {
                if (value > 1900 && value <= DateTime.Now.Year) // após a inserção de um dado pelo usuário valida se estiver dentro das condições a seguir
                {
                    ano = value;
                }
                else
                {
                    Console.WriteLine("Ano invalido");
                }
            }
        }
        //Método público para exibir funções do carro, se inicia vazio 
        public void ExibirInfromacoes()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
        }
        //calcular automaticamente uma idade, nesse caso o carro, pega o ano atual e guarda faz uma conta de subtração do carro que foi registrada anteriormente 
        public int CalcularIdade()
        {
            int anoAtual = DateTime.Now.Year;
            return anoAtual - Ano;
        }
        //para conseguir acessar um metodo privado, é necessario criar um metodo publico na mesma classe, senão não se pode mostrar o metodo privado para o usuario 
        public void DefinirModelo(string modelo)
        {
            Modelo = modelo;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Carro meuCarro = new Carro();
                meuCarro.Marca = "Toyota";
                meuCarro.DefinirModelo("Corolla");
                meuCarro.Ano = 2020;

                meuCarro.ExibirInfromacoes();
                int idadeCarro = meuCarro.CalcularIdade();
                Console.WriteLine($"idade do carro: {idadeCarro} anos.");

                Console.ReadLine();
            }
        }
    }
}