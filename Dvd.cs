using System;

namespace teste;

public class Dvd : ItemBiblioteca
{
    public string Diretor { get; set; } 

    public Dvd(string titulo, string diretor, int valorEmprestimo) : base(titulo, valorEmprestimo)
    {
        Diretor = diretor;
    }
    public void ExibirDetalhesDvd()
    {

        Console.WriteLine($"Título: {Titulo}, Diretor: {Diretor}, Valor Empréstimo: {ValorEmprestimo} ");
        if (Disponivel)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Disponível");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Indisponível");
        }

        Console.ResetColor();
    }
    

    public void VerificarDisponibilidadeDvd()
    {
        if (Disponivel)
        {
            Console.WriteLine($"O DVD '{Titulo}' está disponível para empréstimo.");
        }
        else
        {
            Console.WriteLine($"O DVD '{Titulo}' não está disponível para empréstimo no momento.");
        }
    }
}