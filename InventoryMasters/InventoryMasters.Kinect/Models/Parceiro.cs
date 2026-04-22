using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryMasters.Kinect.Models
{
    /// <summary>
    /// Representa a entidade Parceiro no sistema.
    /// Contém informações de contato e vínculo empresarial.
    /// </summary>
    public class Parceiro
    {        
        public int Id { get; set; }                
        public string Nome { get; set; }       
        public string Empresa { get; set; }
        public string Email { get; set; }       
        public string Telefone { get; set; }  
        public string Endereco { get; set; }
    }
}