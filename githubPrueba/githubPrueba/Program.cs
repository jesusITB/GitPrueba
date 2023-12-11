namespace yisus
{
    public class Yisus
    {
        public static void Main(string[] args)
        {
            const string msg = "Que area quieres calcular" +
                "triangulo" +
                "cuadrado" +
                "circulo";

            Console.WriteLine(msg);
            string respu = Console.ReadLine();
            Console.WriteLine(fun(respu.ToLower()));



        }
        public static int fun(string respu)
        {
            const string Base = "introduce la base";
            const string altura = "introduce la altura";
            const string lado = "introduce uno de los lado";
            const string radio = "introduce el radio";

            int BaseNum, alturaNum;
            double radioNum;
            int LadoOne, LadoTwo;
            double pi = 3.14159265359;

            int resultado = 0;
            switch (respu)
            {
                case "triangulo":

                    Console.WriteLine(Base);
                    BaseNum = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(altura);
                    alturaNum = Convert.ToInt32(Console.ReadLine());

                    resultado = (BaseNum * alturaNum) / 2;
                    break;
                case "cuadrado":
                    Console.WriteLine(lado);
                    LadoOne = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(lado);
                    LadoTwo = Convert.ToInt32(Console.ReadLine());

                    resultado = (LadoOne * LadoTwo);

                    break;
                case "circulo":

                    Console.WriteLine(radio);
                    radioNum = Convert.ToDouble(Console.ReadLine());

                    resultado = (int)(pi * Math.Sqrt(radioNum));

                    break;

            }
            return resultado;
        }
    }
}