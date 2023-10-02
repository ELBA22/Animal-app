using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class ClienteDireccion : BaseEntity
{
    [Required]
    public int IdCliente { get; set; }

    [Required]
    public string Calle { get; set; }

    [Required]
    public int Numero { get; set; }

    [Required]
    public string Piso { get; set; }


    [Required]
    public string CodigoPostal { get; set; }


    [Required]
    public string Provincia { get; set; }

}
