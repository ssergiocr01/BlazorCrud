using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCrud.Shared
{
    public class EmpleadoDTO
    {
        public int IdEmpleado { get; set; }

        public string NombreCompleto { get; set; } = null!;

        public int IdDepartamento { get; set; }

        public int Sueldo { get; set; }

        public DateTime FechaContrato { get; set; }
        public DepartamentoDTO? Departamento { get; set; }
    }
}
