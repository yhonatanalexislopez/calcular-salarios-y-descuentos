using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calcular_salarios_y_descuentos
{
    public class Salarios :Nomina
    {

        public double calcularsalarioBase()
        {
            return (this.getcantidadhoras() * this.getvalorhora()); 
        
        
        }


    }
}
