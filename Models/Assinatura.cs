﻿using System.Security.Principal;

namespace API_Projeto_Livros.Models
{
    public class Assinatura
    {
        public int AssinaturaId { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string status { get; set; }
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
    }
}
