using Resist.Domain.Interfaces;
using System;

namespace Resist.Domain.Entities

{
    public class Color
    {
                private string COLOR_1,COLOR_2,COLOR_3,COLOR_4,val1,val2, r;
        private int valor = 0;
        public double suma = 0.0;
         public double r2 = 0.0;
        public double r3 = 0.0;
        public double ResulOMAS=0.0;
         public double ResulTADOMENOST=0.0;
        
        public void Bandeja1 (string C1)
        {
            COLOR_1 = C1;
            switch(C1){
                case "Negro":
                val1="0";
                break;
                case "Cafe":
                val1 = "1";
                break;
                case "Rojo":
                val1 = "2";
                break;
                case "Naranja":
                val1 = "3";
                break;
                case "Amarillo":
                val1 = "4";
                break;
                case "Verde":
                val1 = "5";
                break;
                case "Azul":
                val1 = "6";
                break;
                case "Violeta":
                val1 = "7";
                break;
                case "Gris":
                val1 = "8";
                break;
                case "Blanco":
                val1 = "9";
                break;
        
                
            }
        }
        public void Bandeja2 (string C2)
        {
            COLOR_2 = C2;
            switch(C2){
                case "Negro":
                val2="0";
                r = val1 + val2;
                valor = int.Parse(r);
                break;
                case "Cafe":
                val2 = "1";
                r = val1 + val2;
                valor = int.Parse(r);
                break;
                case "Rojo":
                val2 = "2";
                r = val1 + val2;
                valor = int.Parse(r);
                break;
                case "Naranja":
                val2 = "3";
                r = val1 + val2;
                valor = int.Parse(r);
                break;
                case "Amarillo":
                val2 = "4";
                r = val1 + val2;
                valor = int.Parse(r);
                break;
                case "Verde":
                val2 = "5";
                r = val1 + val2;
                valor = int.Parse(r);
                break;
                case "Azul":
                val2 = "6";
                r = val1 + val2;
                valor = int.Parse(r);
                break;
                case "Violeta":
                val2 = "7";
                r = val1 + val2;
                valor = int.Parse(r);
                break;
                case "Gris":
                val2 = "8";
                r = val1 + val2;
                valor = int.Parse(r);
                break;
                case "Blanco":
                val2 = "9";
                r = val1 + val2;
                valor = int.Parse(r);
                break;
               
            }
        }
        public void Bandeja3 (string C3)
        {
            COLOR_3 = C3;
            switch(C3){
                case "Negro":
                r2 = 1;
                suma = valor * r2;
                break;
                case "Cafe":
                r2 = 10;
                suma = valor * r2;
                break;
                case "Rojo":
                r2 = 100;
                suma = valor * r2;
                break;
                case "Naranja":
                r2 = 1000;
                suma = valor * r2;
                break;
                case "Amarillo":
                r2 = 1000;
                suma = valor * r2;
                break;
                case "Verde":
                r2 = 10000;
                suma = valor * r2;
                break;
                case "Azul":
                r2 = 100000;
                suma = valor * r2;
                break;
                case "Violeta":
                r2 = 1000000;
                suma = valor * r2;
                break;
                case "Gris":
                r2 = 10000000;
                suma = valor * r2;
                break;
                case "Blanco":
                r2 = 100000000;
                suma = valor * r2;
                break;
               
            }
        }
        public void Bandeja4 (string C4)
        {
            COLOR_4 = C4;

                if(C4 == "Dorado"){
                r3 = (suma * 5)/100;
                }
                if(C4 == "Plata"){
                r3 = suma * 10/100;
                }
    
            
         ResultadOMAST= suma + r3;
         RESULTADOMENOST= suma - r3;  
        }

        public string RetornaCalculo()
        {
             return $"el valor es {suma} y la tolerancia + o - {r3} El rango de toleracia si tiene mas el {r3} es de: {ResulOMAS} El rango de tolerancia si tiene menos el {r3} es de : {ResulTADOMENOST}  ";
        }
    }
}