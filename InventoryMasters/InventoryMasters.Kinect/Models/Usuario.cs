using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InventoryMasters.Kinect.Models
{
    /// <summary>
    /// Representa o usuário que opera o sistema Inventory Masters.
    /// Contém credenciais simples para acesso e identificação nas medições.
    /// </summary>
    public class Usuario
    {
        /// <summary> Identificador único do usuário no banco de dados. </summary>
        [Key]
        public int Id { get; set; }

        /// <summary> Nome completo do colaborador. </summary>
        [Required]
        public string Nome { get; set; }

        /// <summary> Nome de usuário utilizado para entrar no sistema. </summary>
        [Required]
        public string Login { get; set; }

        /// <summary> Senha em texto simples para este protótipo de TCC. </summary>
        [Required]
        public string Senha { get; set; }

        /// <summary> Cargo ou perfil (Ex: Operador, Administrador). </summary>
        public string Perfil { get; set; }

        /// <summary> 
        /// Relacionamento: Lista de medições que este usuário realizou.
        /// Isso permite rastrear quem operou o Kinect em cada registro.
        /// </summary>
        public virtual ICollection<Medicao> Medicoes { get; set; }
    }
}
