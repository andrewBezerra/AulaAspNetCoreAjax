using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetAjax.Models
{
    public class ModelBase
    {
        public ModelBase()
        {
            ID = Guid.NewGuid();
        }

        [Key]
        public Guid ID { get; set; }
    }
}
