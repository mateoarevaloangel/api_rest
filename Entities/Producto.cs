using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api_rest.Entities
{
    public class Producto
    {
        [Key]
        public string id { get; set; }

        public string nombre{get;set;}

        public decimal precio { get; set; }
    }
}
