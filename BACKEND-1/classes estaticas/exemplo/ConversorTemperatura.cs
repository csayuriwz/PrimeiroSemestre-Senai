namespace exemplo
{
    public class ConversorTemperatura
    {
        //propriedade estática
        public static float Temperatura { get; set; }


        //métodos estáticos
        public static float CelsiusParaFahreheint(float celsius)
        {
            Temperatura = celsius;

            float fahreinheit = (Temperatura * 9 / 5) + 32;

            return fahreinheit;
        }

        public static float FahreinheitParaCelsius(float fahreinheit)
        {
            Temperatura = fahreinheit;

            float celsius = (Temperatura - 32) * 5 / 9;

            return celsius;
        }

    }
}