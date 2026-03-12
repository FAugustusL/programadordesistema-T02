using classeheranca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeheranca
{
    //classe base (superclasse)
    internal class Animal
    {
        //Propriedade da classe animal
        public string Nome { get; set; }

        //Método que será sobrecarregado nas classes derivadas
        public virtual void EmitirSom()
        {
            Console.WriteLine("o animal emite um som.");
        }
    }

    //classe derivada (subclasse)
    internal class Cachorro : Animal
    {
        //sobrescrevendo o método EmitirSom
        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} late : Au Au");
        }
    }
    //outra classe derivada
    internal class Gato : Animal
    {
        //sobrescrevendo o método EmitirSom
        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} mia : Miau");

        }
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        //Criando instâncias das classes derivadas
        Animal meuCachorro = new Cachorro { Nome = "Rex" };
        Animal meuGato = new Gato { Nome = "Félix" };

        //Chamando o método EmitirSom para cada animal
        meuCachorro.EmitirSom(); //Saida : Rex late :Au Au
        meuGato.EmitirSom(); // saida : Félix mia : Miau

        //Utilizando Polimorfismo: Array de Animais
        Animal[] animais = {meuCachorro, meuGato };

        foreach (var animal in animais)
        {
            animal.EmitirSom(); //Cada objeto chama o métod adequado da sua classe
        }
    }
}

