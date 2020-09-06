using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calcular_salarios_y_descuentos
{
    public class Nomina
    {
        private double cantidadhoras;


        private double valorhora;


        public Nomina()
        {
            double minimo;
            minimo = 900000;
            this.valorhora = minimo / 240;
         }


        public void setcantidadhoras(double valor)
        {
            this.cantidadhoras = valor;
        }

        public double getcantidadhoras()
        {
            return this.cantidadhoras; 
        
        
        }

        public double getvalorhora()
        {
            return this.valorhora; 
        
        
        }
    }
}
