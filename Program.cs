double b, h, a, c, area, peri;
char opc;
Console.WriteLine("1 El area del triangulo");
Console.WriteLine("2 El perimetro del Triangulo");
Console.WriteLine("Introduce tu opcion");
opc = Convert.ToChar(Console.ReadLine());

if (opc == '1')
{
    Console.WriteLine("Ingresa la base:");
    b = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Ingresa la altura:");
    h = Convert.ToDouble(Console.ReadLine());
    area = b * h / 2;

    Console.WriteLine("El area es {0}", area);
}
else if (opc == '2')
{
    Console.WriteLine("Ingresa lado A:");
    a = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Ingresa lado B:");
    b = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Ingresa lado C:");
    c = Convert.ToDouble(Console.ReadLine());
    peri = a + b + c;
    Console.WriteLine("El perimetro es {0}", peri);
}
Console.ReadKey();







