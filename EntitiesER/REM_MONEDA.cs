using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntitiesER
{
    [Table("REM_MONEDA")]
    public class REM_MONEDA : IEntityBase
    {
        public int Id { get; set; }
        public int IdMoneda { get; set; }
    }
}
