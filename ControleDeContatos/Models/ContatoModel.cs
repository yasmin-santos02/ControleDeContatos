﻿using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do contato")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o email do contato")]
       [EmailAddress(ErrorMessage ="E-mail informado é inválido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite o celular  do contato")]
        [Phone(ErrorMessage = "O celular informado é inválido!")]
        public string Celular { get; set; }
    }
}
