bool continuar = true;
while (continuar)
{
    Console.Clear();
    Console.WriteLine("Calculadora - Seleccione una opción:");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Salir");
    Console.Write("Opción: ");

    string? input = Console.ReadLine();
    int opcion;

    // Verificación de que la opción sea un número y esté en el rango correcto
    if (!int.TryParse(input, out opcion) || opcion < 1 || opcion > 5)
    {
        Console.WriteLine("Opción no válida. Por favor, seleccione una opción del 1 al 5.");
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
        continue;
    }

    if (opcion == 5)
    {
        Console.WriteLine("Gracias por usar la calculadora. ¡Adiós!");
        continuar = false;
        break;
    }

    double num1, num2;

    // Validación del primer número
    Console.Write("Ingrese el primer número: ");
    input = Console.ReadLine();
    if (!double.TryParse(input, out num1))
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
        continue;
    }

    // Validación del segundo número
    Console.Write("Ingrese el segundo número: ");
    input = Console.ReadLine();
    if (!double.TryParse(input, out num2))
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
        continue;
    }

    double resultado = 0;

    switch (opcion)
    {
        case 1:
            resultado = num1 + num2;
            Console.WriteLine($"Resultado: {num1} + {num2} = {resultado}");
            break;
        case 2:
            resultado = num1 - num2;
            Console.WriteLine($"Resultado: {num1} - {num2} = {resultado}");
            break;
        case 3:
            resultado = num1 * num2;
            Console.WriteLine($"Resultado: {num1} * {num2} = {resultado}");
            break;
        case 4:
            if (num1 == 0 || num2 == 0)
            {
                Console.WriteLine("Error: No se puede dividir entre cero.");
            }
            else
            {
                resultado = num1 / num2;
                Console.WriteLine($"Resultado: {num1} / {num2} = {resultado}");
            }
            break;
    }

    Console.WriteLine("Presione cualquier tecla para continuar...");
    Console.ReadKey();
}
