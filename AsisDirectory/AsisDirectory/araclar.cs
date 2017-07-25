using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsisDirectory
{
    [Table("araclar")]
    public class araclar
    {
        [Key]
        public string plaka { get; set; }
        public byte validatorVarMi { get; set; }
        public Int32? validatorNo { get; set; }
    }
}
