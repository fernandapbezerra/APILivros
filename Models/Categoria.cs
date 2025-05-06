﻿namespace API_Projeto_Livros.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string NomeCategoria { get; set; }
        public List<Livro> Livros { get; set; } = new();
    }
}
