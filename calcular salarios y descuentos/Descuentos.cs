using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calcular_salarios_y_descuentos
{
    public class Descuentos:Salarios

    {
        public double calcularSalud() 
        {   
            if (this.calcularsalarioBase()>=2000000)
            {   return(this.calcularsalarioBase()*0.04);
            }
            
            else 
            {
               return(this.calcularsalarioBase()*0.02);
            }
        }

        public double calcularPension() 
        {
            if (this.calcularsalarioBase() >= 2000000)
            {
                return (this.calcularsalarioBase() * 0.04);
            }

            else
            {
                return (this.calcularsalarioBase() * 0.02);
            }
        }

        public double calcularccp() 
        {
            if (this.calcularsalarioBase() >= 2000000)
            {
                return (this.calcularsalarioBase() * 0.02);
            }

            else
            {
                return (this.calcularsalarioBase() * 0.01);
            }
        
       }

        public double calcularSalarioConDescuento()
        {
            return (this.calcularsalarioBase() - (this.calcularSalud() + this.calcularPension() + this.calcularccp())); 
        
        
        }
    }
}
