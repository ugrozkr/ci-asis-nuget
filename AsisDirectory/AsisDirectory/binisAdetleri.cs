using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsisDirectory
{
    public class binisAdetleri
    {
        [Key]
        public string BinisKarti { get; set; }
        public int TamAdet { get; set; }
        public decimal TamTutar { get; set; }
        public int UltraLightAdet { get; set; }
        public decimal UltraLightTutar { get; set; }
        public int AbonmanAdet { get; set; }
        public decimal AbonmanTutar { get; set; }
        public int AktarmaAdet { get; set; }
        public decimal AktarmaTutar { get; set; }
        public int UcretsizAdet { get; set; }
        public int ToplamAdet { get; set; }
        public decimal ToplamTutar { get; set; }
    }
}
