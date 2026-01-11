    using System;

namespace teste;

public class Livros : ItemBiblioteca
{
    public string Autor { get; set; }

    public Livros(string titulo, string autor, int valorEmprestimo) : base(titulo, valorEmprestimo)
    {
        Autor = autor;
    }

    public void ExibirDetalhesLivro()
    {

        Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, Valor Empréstimo: {ValorEmprestimo}");
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
    
    public void VerificarDisponibilidadeLivro()
    {
        if (Disponivel)
        {
            Console.WriteLine($"O livro '{Titulo}' está disponível para empréstimo.");
        }
        else
        {
            Console.WriteLine($"O livro '{Titulo}' não está disponível para empréstimo no momento.");
        }
    }
}