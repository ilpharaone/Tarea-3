using System;
using System.Linq;
int n=0;
string[] nombre = new string[n];
int[] edad = new int[n];
string[] cita = new string[n];
Main();

void inicializar()
    {
            int n;
            Console.WriteLine("Digite de cuanto quiere el arreglo de pacientes: ");
            n = int.Parse(Console.ReadLine());
            
            nombre = Enumerable.Repeat("", n).ToArray<string>();
            cita = Enumerable.Repeat("", n).ToArray<string>();
            edad = Enumerable.Repeat(0, n).ToArray<int>();


    }
void Ingresar() {

  
        
        for (int i = 0; i < nombre.Length; i++)
        {
          



            Console.Write("Ingrese el nombre: "); nombre[i] = Console.ReadLine();
            Console.Write("Ingrese la edad: "); edad[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Desea ingresar otro paciente: 1- Si, 2-No");
            
        }
        

    }


   
 
void Consultar()
{
    bool encontrado = false;
    Console.WriteLine("Digite el nombre a buscar");
    string nom = Console.ReadLine();

    for(int i = 0; i<nombre.Length; i++)
    {
        if(nom.Equals(nombre[i]))
        {
            Console.WriteLine($"La edad de {nombre[i]} es {edad[i]}");
            encontrado = true;
        }
    }
    if(encontrado == false)
    {
        Console.WriteLine($"El paciente {nom} no se encuentra");
    }

}
void Reporte()
{

    for(int i = 0; i < nombre.Length; i++)
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Nombre          Edad");
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("-----          -----");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"{nombre[i]}           {edad[i]}");
    }
}
void Asignar()
{
    for (int i = 0; i < cita.Length; i++)
    {
        bool encontrado = true;
        Console.WriteLine($"{nombre[i]} Digite la fecha y hora que desea su cita, en el formato 24 horas y 01/01/24\nEjemplo 13:00 02/02/24\nEL horario es de 7:00 a 15:00, solo hay dos citas por hora a las 00 y 30 ");
        string fecha = Console.ReadLine();

        for (int j = 0; j < cita.Length; j++)
        {

            if (fecha.Equals(cita[j]))
            {
                Console.WriteLine($"No hay citas disponibles a esa hora");
                encontrado = false;
            }

            if (encontrado == true)
            {
                cita[i] = fecha;
                Console.WriteLine($"{nombre[i]} fecha de su cita: {fecha}");
            }
        }
    }
}
void Main()
{
            int opcion;
    do {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("---------- Sistema de Clinica----------");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("1. Inicializar arreglos: ");
        Console.WriteLine("2. Ingresar paciente: ");
        Console.WriteLine("3. Consultar paciente: ");
        Console.WriteLine("4. Reporte");
        Console.WriteLine("5. Asignar Citas");
        Console.WriteLine("6. Salir");
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1: inicializar(); break;
            case 2: Ingresar(); break;
            case 3: Consultar(); break;
            case 4: Reporte(); break;
            case 5: Asignar(); break;
            default:
                break;

        }

    } while (opcion != 6);
}


