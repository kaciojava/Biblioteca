using System;

namespace teste;

public class ItemBiblioteca{
    public string Titulo { get; set;}

    public int ValorEmprestimo { get; set; }
    protected bool Disponivel { get; set; }

    public ItemBiblioteca(string titulo, int valorEmprestimo = 0) {
        Titulo = titulo;
        ValorEmprestimo = valorEmprestimo;
        Disponivel = true;
    }
}