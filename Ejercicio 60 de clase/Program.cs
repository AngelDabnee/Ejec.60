// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//1.	Permite que el usuario capture alguno de los signos “*" o “+",
//después que capture 15 números (en un ciclo),
//si el usuario ingresó "+" tu busca el menor, si no, imprime el promedio.
//Datos de entrada. 
string caracter = "";
double promedio = 0;
//Procedimiento
Console.WriteLine("Captura tu caracter " + caracter);
caracter = Console.ReadLine();
if (caracter == "+" || caracter == "+")
{
    for (double i = 0; i < 15; i++)
    {
        Console.WriteLine("Captura tu número " + (i + 1));
        double num1 = double.Parse(Console.ReadLine());
    }
        //ordenar los numeros mediante burbuja.
        //Creamos arreglo para ordenamiento
        double[] paraOrdenamiento = new double[15];
        for (int j = 0; j < 15; j++)
        {
            for (int k = 0; k < 15-1; k++)
            {
            if (paraOrdenamiento[k] > paraOrdenamiento[k + 1])
            {
                double temp = paraOrdenamiento[k];
                paraOrdenamiento[k] = paraOrdenamiento[k + 1];
                paraOrdenamiento[k + 1] = temp;
                }
            }
        Console.WriteLine(paraOrdenamiento[0]);
        }
}
else
{
    for (double i = 0; i < 15; i++)
    {
        Console.WriteLine("Captura tu número " + (i + 1));
        double num2 = double.Parse(Console.ReadLine());
    }
}