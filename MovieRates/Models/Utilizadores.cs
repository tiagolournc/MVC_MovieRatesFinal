﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRates.Models
{
    /// <summary>
    /// Descrição de cada utilizador
    /// </summary>
    public class Utilizadores
    {
        /// <summary>
        /// Construtor dos utilizadores
        /// </summary>
        public Utilizadores()
        {
            ListaDeReviews = new HashSet<Reviews>();
            ListaDeFavoritos = new HashSet<Favoritos>();
        }

        /// <summary>
        /// Identificador do utilizador
        /// </summary>
        [Key]
        public int IdUtilizador { get; set; }

        /// <summary>
        /// ligação entre os Utilizadores e a tabela de Autenticação
        /// </summary>
        public string UserNameId { get; set; }

        /// <summary>
        /// Email do utilizador
        /// </summary>
        [StringLength(50, ErrorMessage = "O {0} não pode ter mais de {1} caracteres.")]
        [Required]
        [EmailAddress(ErrorMessage = "O {0} introduzido não é válido")]
        public string Email { get; set; }

        /// <summary>
        /// verifica se o utilizador já deu a sua "Review" ao filme
        /// </summary>
        public Boolean ControlarReview { get; set; }

        /// <summary>
        /// Lista das reviews dos utilizadores
        /// </summary>
        public ICollection<Reviews> ListaDeReviews { get; set; }

        /// <summary>
        /// Lista dos filmes favoritos dos utilizadores
        /// </summary>
        public ICollection<Favoritos> ListaDeFavoritos { get; set; }
    }
}
