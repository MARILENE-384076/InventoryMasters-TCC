using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InventoryMasters.Kinect.Models
{
    /// <summary>
    /// Representa uma coleta de dados realizada pelo sensor Kinect.
    /// Armazena as dimensões calculadas e o vínculo com o usuário/operador.
    /// </summary>
    public class Medicao
    {
        /// <summary> Identificador único da medição (Chave Primária). </summary>
        [Key]
        public int Id { get; set; }

        /// <summary> Data e hora exata em que a medição foi realizada. </summary>
        public DateTime DataCriacao { get; set; } = DateTime.Now;

        /// <summary> Altura detectada pelo sensor em metros. </summary>
        [Required]
        public double Altura { get; set; }

        /// <summary> Largura detectada pelo sensor em metros. </summary>
        public double Largura { get; set; }

        /// <summary> Profundidade detectada pelo sensor em metros. </summary>
        public double Profundidade { get; set; }

        /// <summary> Volume total calculado (m³). </summary>
        public double Volume { get; set; }

        /// <summary> Status da medição (ex: Pendente, Processado, Erro). </summary>
        public string Status { get; set; }

        /// <summary> ID do usuário que realizou a medição (Chave Estrangeira). </summary>
        public int UsuarioId { get; set; }

        /// <summary> Propriedade de navegação para o objeto Usuário. </summary>
        [ForeignKey("UsuarioId")]
        public virtual Usuario Usuario { get; set; }
    }
}
