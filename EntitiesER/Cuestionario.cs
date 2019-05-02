using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesER
{
    [Table("REM_CUESTIONARIO")]
    public class REM_CUESTIONARIO : IEntityBase
    {
        public int Id { get; set; }
        public int IdCuestionario { get; set; }
    }
}
