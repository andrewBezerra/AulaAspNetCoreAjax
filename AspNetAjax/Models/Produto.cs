using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetAjax.Models
{
    public class Produto:ModelBase
    {
        
        [Display(Name ="Descrição")]
        public string Descricao{ get; set; }
        [Display(Name = "Preço")]
        public double Preco { get; set; }
    }
}
