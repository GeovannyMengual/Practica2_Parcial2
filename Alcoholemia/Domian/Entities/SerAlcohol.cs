namespace Alcoholi.Domian.Entities
{
    public class SerAlcohol
    {
     private int c;
        private int liquido;
        private int Peso;
        private double Consumido;
        private double CantAlcoholSangre;
        private double etanol = 0.789;
        private double etaensangre;
        private double volumenDeSangre;
        private double ASangre;
        private double gradoAlcohol;
        private string Bebida;
        public void AlcoholConsumidoPers(string bebida, int cantidad)
        {
            c = cantidad;
            Bebida = bebida.ToLower();
            switch (Bebida)
            {
                    case "cerveza":
                     liquido = 330;
                    c = c *  liquido;
                    gradoAlcohol = 5;
                    Consumido= gradoAlcohol / 100 * c;
                    break;
                    case "vino": 
                    liquido = 100;
                    c = c * liquido;
                    gradoAlcohol = 12;
                   Consumido = gradoAlcohol / 100 * c;
                    break;
                    case "cava": 
                     liquido = 100;
                    c = c *  liquido;
                    gradoAlcohol = 12;
                    Consumido= gradoAlcohol / 100 * c;
                    break;
                    case "vermu":
                     liquido = 70;
                    c = c *  liquido;
                    gradoAlcohol = 17;
                    Consumido = gradoAlcohol / 100 * c;
                    break;
                    case "licor":
                     liquido = 45;
                    c = c *  liquido;
                    gradoAlcohol = 23;
                    Consumido = gradoAlcohol / 100 * c;
                    break;
                    case "brandy":
                     liquido = 45;
                    c = c *  liquido;
                    gradoAlcohol = 38;
                    Consumido = gradoAlcohol / 100 * c;
                    break;
                    case "combinado":
                     liquido = 50;
                    c = c * liquido;
                    gradoAlcohol = 38;
                    Consumido = gradoAlcohol / 100 * c;
                    break;
        }
        }
        public void PasaSangre(int peso)
        {
           Peso = peso;
            CantAlcoholSangre = 0.15 * Consumido;
            etaensangre = etanol * CantAlcoholSangre;
            volumenDeSangre = 0.8 * Peso;
            ASangre = etaensangre / volumenDeSangre;
        
        }
        
        public string Resultado()
        {
                if (ASangre >  0.8)
                {
                    return $" Su nivel de alcohol en la sangre es: {ASangre}  es superior al limite que nos propone en el reglamento, no es apto que conduzca";
                }
                    return $" Su nivel de alcohol en la sangre es: {ASangre}  no es superior al limite que nos propone en el reglamento,  es apto para conducir";
               
        }

    }
}