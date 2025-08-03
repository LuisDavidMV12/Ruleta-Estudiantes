/*Ruleta de selección aleatoria de estudiantes, donde el programa debe seleccionar aleatoriamente 2 estudiantes
  del listado de estudiantes de la clase, asignarles roles específicos y ejecutarse continuamente hasta que se
  cumpla una condición de salida especificada.*/

string?[] estudiantes = {
    "Yerely Yohanna Feliz Alcantara",
    "Wilson Gabriel Marte Borrero",
    "Raul Santiago Castro Santana",
    "Oskarling Moises Mendez Mercedes",
    "Oscar Alberto Meregildo Quezada",
    "Noel Alberto Rodríguez Núñez",
    "Naciel Altagracia Tavarez Araujo",
    "Luis David Moreta Valenzuela",
    "Keylin Steven Rosario Mordan",
    "Jose Cruz",
    "José Alexis De Jesús Cipión",
    "Jordania Melina Pérez Estevez",
    "Hector Aremil Guzmn Hernndez",
    "Gerson Javier Prez Reyes",
    "Geraldino Geraldo Jaquez",
    "Gabriel Terman",
    "Enmanuel Marte",
    "Deri Junior Montero Peguero",
    "Denis Williams Peña Santana",
    "Charlie Langumas",
    "Cesar Yariel Gmez Arias",
    "Angel David Duarte Ramrez",
    "Amin Abel Gil Romero",
    "Alejandro Rainier Mieses Cotes",
    "Alber Rodriguez",
    "Yonill Reyes Veloz"
};

string[] conteoEstudiantesRol1 = new string[estudiantes.Length];
string[] conteoEstudiantesRol2 = new string[estudiantes.Length];

int contadorRol1 = 0;
int contadorRol2 = 0;

string rol1 = "Desarrollador en vivo";
string rol2 = "Facilitador de Ejercicio a Desarrollar";

string menu;
do
{
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("                                 ████████████████████████████████████████████████████████████");
Console.WriteLine("                                 ░░░░░░░ Ruleta de Selección Aleatoria de Estudiantes ░░░░░░░");
Console.WriteLine("                                 ████████████████████████████████████████████████████████████");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Cyan;

Console.WriteLine();
Console.WriteLine("                                           ╔══════════════════════════════════════╗");
Console.WriteLine("                                           ║           Menú de Opciones           ║");
Console.WriteLine("                                           ╠══════════════════════════════════════╣");
Console.WriteLine("                                           ║      [1] Ruleta de Estudiantes       ║");
Console.WriteLine("                                           ║     [2] Administrar Estudiantes      ║");
Console.WriteLine("                                           ║     [3] Historial de Selecciones     ║");
Console.WriteLine("                                           ║        [4] Administrar Roles         ║");
Console.WriteLine("                                           ╚══════════════════════════════════════╝");

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("\n                                                          [Q] SALIR");
Console.ResetColor();

Console.Write("Seleccione una opcion: ");
menu = (Console.ReadLine())!;
Console.Clear();

switch (menu)
{
  case "1":
  Console.ForegroundColor = ConsoleColor.Blue;
  Console.WriteLine("                                    ==================================================================");
  Console.WriteLine("                                    |                       Ruleta de Estudiantes                    |");
  Console.WriteLine("                                    ==================================================================");
  Console.ResetColor();

  Console.ForegroundColor = ConsoleColor.Magenta;
  System.Console.WriteLine();
  Console.WriteLine("                                                          -------------------");
  Console.WriteLine("                                                         | [1] Girar Ruleta  |");
  Console.WriteLine("                                                          -------------------");
  Console.ResetColor();
  Console.WriteLine("\n[2] para volver atras");
  

  System.Console.Write("Seleccione una opcion: ");
  string girar = Console.ReadLine()!;
  Console.Clear();

  switch(girar)
  {
    case "1":
      Random random = new Random();
      int numeroAleatorio = random.Next(estudiantes.Length);
      
      for (int i = 1; i <= 16; i++)
      {
        System.Console.Write("* ");
        Thread.Sleep(100);

        if(i % 4 == 0)
        {
        Console.Clear();
        }
      }
      
      while (estudiantes[numeroAleatorio] == null) 
      {
        numeroAleatorio = random.Next(estudiantes.Length);
      }
      
      for ( int o = 0; o < conteoEstudiantesRol1.Length; o++)
      {
        if (conteoEstudiantesRol1[o] == estudiantes[numeroAleatorio])
        {
          numeroAleatorio = random.Next(estudiantes.Length);
          o = 0;
        }
      }
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.WriteLine($"                    █ ROL: {rol1}:                      -> {estudiantes[numeroAleatorio]} <-");
      Console.ResetColor();

      conteoEstudiantesRol1[contadorRol1] = estudiantes[numeroAleatorio];
      contadorRol1 += 1;

      numeroAleatorio = random.Next(estudiantes.Length);

      for ( int p = 0; p < conteoEstudiantesRol2.Length; p++)
      {
        if (conteoEstudiantesRol2[p] == estudiantes[numeroAleatorio])
        {
          numeroAleatorio = random.Next(estudiantes.Length);
          p = 0;
        }
        if (conteoEstudiantesRol1[contadorRol1 - 1] == estudiantes[numeroAleatorio])
        {
          numeroAleatorio = random.Next(estudiantes.Length);
          p = 0;
        }
      }

      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine($"                    █ ROL: {rol2}:     -> {estudiantes[numeroAleatorio]} <-");
      Console.ResetColor();

      conteoEstudiantesRol2[contadorRol2] = estudiantes[numeroAleatorio];
      contadorRol2 += 1;

      System.Console.WriteLine("\n<<ENTER>> para volver atras");
      Console.ReadKey();
      Console.Clear();
      break;

    case "2":
    Console.Clear();
    break;

    default:
    Console.ForegroundColor = ConsoleColor.Red;
    System.Console.WriteLine("***Opcion Invalida***");
    Console.ResetColor();
    System.Console.WriteLine("\n<<ENTER>> para volver atras");
    Console.ReadKey();
    Console.Clear();
    break;
  }
  Console.Clear();
  break;

  case "2":
  Console.Clear();

  Console.WriteLine();
  Console.ForegroundColor = ConsoleColor.Blue;
  Console.WriteLine("                            ###################################################");
  Console.WriteLine("                            #               Lista de Estudiantes              #");
  Console.WriteLine("                            ###################################################");
  Console.ResetColor();

  Console.ForegroundColor = ConsoleColor.Green;
  Console.Write("\n[1] Agregar Estudiante                    ");

  Console.ForegroundColor = ConsoleColor.Red;
  Console.Write("[2] Eliminar Estudiante                     ");

  Console.ForegroundColor = ConsoleColor.Yellow;
  Console.WriteLine("[3] Editar Estudiante");
  Console.ResetColor();

  System.Console.WriteLine();

  Console.ForegroundColor = ConsoleColor.DarkBlue;
  int nu = 0;
  for (int j = 0; j < estudiantes.Length; j++)
  {
    if (!string.IsNullOrWhiteSpace(estudiantes[j]))
    {
    
    Console.WriteLine($"{nu + 1}- {estudiantes[j]}.");
    nu += 1;
    }
  }
  Console.ResetColor();

  Console.WriteLine("\n                                             [W] para volver atras");
  Console.Write("\nSelecione una opcion: ");
  
  string opc2 = Console.ReadLine()!;
  

  int nuevoTamano = estudiantes.Length + 1;

        switch(opc2)
        {
            case "1":
            Console.Clear();

            

            Array.Resize(ref estudiantes, nuevoTamano);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("              =========== ADHIERA UN ESTUDIANTE ===========");
            Console.WriteLine("\nEscriba el nombre completo del estudiante: ");
            Console.ResetColor();
            estudiantes[nuevoTamano - 1] = Console.ReadLine()!;
          
          if (!string.IsNullOrWhiteSpace(estudiantes[nuevoTamano - 1]))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n              *** Se ha adherido un nuevo estudiante. Su nombre es: {estudiantes[nuevoTamano - 1]} ***");
                Console.ResetColor();
            }
            else
            {
              Console.ForegroundColor = ConsoleColor.Red;
              Console.WriteLine("\n*** No se ha ingresado ningún nombre. ***");
              Console.ResetColor();
            }

          Console.WriteLine("\n<<ENTER>> para volver al menu");
          Console.ReadKey();
          Console.Clear();
          break;

          case "2":
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("              =========== ELIMINE UN ESTUDIANTE ===========");
          Console.WriteLine("\nEscriba el nombre completo del estudiante que quiere eliminar: ");
          Console.ResetColor();
          string nomEstuEliminado = Console.ReadLine()!;

          if (!string.IsNullOrWhiteSpace(nomEstuEliminado))
            {
              for (int ij = 0; ij < estudiantes.Length; ij++)
              {
                if (nomEstuEliminado == estudiantes[ij]);
                {
                  int posicion = Array.IndexOf(estudiantes, nomEstuEliminado);
                  estudiantes[posicion] = null;

                  Console.ForegroundColor = ConsoleColor.Red;
                  Console.WriteLine($"\n              *** Se ha eliminado un estudiante. Su nombre era: {estudiantes[posicion]} ***");
                  Console.ResetColor();
                  
                }
              }
                  Console.ForegroundColor = ConsoleColor.Red;
                  Console.WriteLine("              *** Ese estudiante no existe ***");
                  Console.ResetColor();
              
            }
            else
            {
              Console.ForegroundColor = ConsoleColor.Red;
              Console.WriteLine("\n*** No se ha ingresado ningún nombre. ***");
              Console.ResetColor();
            }

          Console.WriteLine("\n<<ENTER>> para volver al menu");
          Console.ReadKey();
          Console.Clear();
          break;

          case "3":

          Console.ForegroundColor = ConsoleColor.Yellow;
          Console.WriteLine("               =========== EDITE ALGUN ESTUDIANTE ===========");
          Console.WriteLine("\nIngrese el numero del estudiante quiere editar:");
          Console.ResetColor();
          int numEstudiante = Convert.ToInt32(Console.ReadLine());

          Console.WriteLine("\nEditara el siguiente estudiante: " + estudiantes[numEstudiante - 1]);

          Console.WriteLine("Ingrese el nuevo nombre para el estudiante:");
          estudiantes[numEstudiante - 1] = Console.ReadLine()!;
          Console.WriteLine("\n<<ENTER>> para volver al menu");
          Console.ReadKey();
          Console.Clear();
          break;

          case "W":
          case "w":
          Console.Clear();
          break;

          default:
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("                                            ***Caracter invalido***");
          Console.ResetColor();
          System.Console.WriteLine("\n<<ENTER>> para volver al menu");
          Console.ReadKey();
          Console.Clear();
          break;
        }

  
  Console.Clear();
  break;

  case "3":

  Console.ForegroundColor = ConsoleColor.Magenta;
  Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
  Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ Historial de Selecciones ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
  Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
  Console.ResetColor();

  
  Console.ForegroundColor = ConsoleColor.Magenta;
  System.Console.WriteLine($"\nEstudiantes ya seleccionados para ROL: {rol1}");

  if (contadorRol1 >= 1 )
  {
  for(int m = 0; m < contadorRol1; m++)
  {
    System.Console.WriteLine($"{m + 1}. {conteoEstudiantesRol1[m]}");
  }
  }
  else
  {
    System.Console.WriteLine("              --- Aun No hay estudiantes seleccionados para el Rol 1 ---");
  }
  Console.ResetColor();

  Console.ForegroundColor = ConsoleColor.Blue;
  System.Console.WriteLine($"\nEstudiantes ya seleccionados para ROL: {rol2}");

  if (contadorRol2 >= 1)
  {
  for(int n = 0; n < contadorRol2; n++)
  {
    System.Console.WriteLine($"{n + 1}. {conteoEstudiantesRol2[n]}");
  }
  
  }
  else
  {
    System.Console.WriteLine("              --- Aun No hay estudiantes seleccionados para el Rol 2 ---");
  }
  Console.ResetColor();
 
  Console.ForegroundColor = ConsoleColor.Red;
  System.Console.WriteLine("\n[E] Eliminar TODOS los registros existentes");
  Console.ResetColor();
  System.Console.WriteLine("\n       Desea guardar los cambios?: ");
  System.Console.WriteLine("              [1]SI      [2]NO      ");
  System.Console.Write("\nSelecione una opcion : ");

  string cambios = Console.ReadLine()!;
  
  switch(cambios)
  {
    case "1":
    try
        {
            using (StreamWriter escritor = new StreamWriter("resultados.csv", true))
            {
              for (int y = 0; y < contadorRol1 && y < contadorRol2; y++)
              {
                escritor.WriteLine($"{DateTime.Now},{rol1},{conteoEstudiantesRol1[y]},{rol2},{conteoEstudiantesRol2[y]}");
              }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n                            *** Resultados guardados exitosamemente en resultados.csv ***");
            Console.ResetColor();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al guardar los resultados: {ex.Message}");
        }

      
      Console.WriteLine("\n<<ENTER>> para volver al menu");
      Console.ReadKey();
      Console.Clear();
      break;

    case "E":
    case "e":
    System.Console.WriteLine("\n Estas segur@ de que quieres eliminar todos los registros de forma permanente?: ");
    System.Console.WriteLine("                         [1] SI      [2] NO");
    System.Console.Write("Elija una opcion: ");
    string eliminarTodosReg = Console.ReadLine()!;

    switch (eliminarTodosReg)
    {
      case "1":
      try
        {
            File.WriteAllText("resultados.csv", string.Empty);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("            *** Datos del archivo resultados.csv eliminados exitosamente***");
            Console.ResetColor();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al eliminar los datos: {ex.Message}");
        }
      System.Console.WriteLine("\n<<ENTER>> para volver al menu");
      Console.ReadKey();
      Console.Clear();
      break;

      case "2":
      Console.Clear();
      break;

      default:
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("                                            ***Caracter invalido***");
      Console.ResetColor();
      System.Console.WriteLine("\n<<ENTER>> para volver al menu");
      Console.ReadKey();
      Console.Clear();
      break;
    }

    Console.WriteLine("\n<<ENTER>> para volver al menu");
      Console.ReadKey();
      Console.Clear();
      break;
    case "2":
      Console.Clear();
      break;

    default:
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("                                            ***Caracter invalido***");
      Console.ResetColor();
      System.Console.WriteLine("\n<<ENTER>> para volver al menu");
      Console.ReadKey();
      Console.Clear();
      break;

  }
  Console.Clear();
  break;

  case "4":

  Console.ForegroundColor = ConsoleColor.Blue;
  Console.WriteLine("                            ###################################################");
  Console.WriteLine("                            |                Administrar Roles                |"); 
  Console.WriteLine("                            ###################################################");
  Console.ResetColor();

  Console.WriteLine($"\nLos Roles designados actualmente son: ROL 1: {rol1}, ROL 2: {rol2}");

  Console.ForegroundColor = ConsoleColor.Magenta;
  Console.Write("                          [1] Editar ROL 1");

  Console.ForegroundColor = ConsoleColor.Blue;
  System.Console.WriteLine("               [2] Editar ROL 2");
  Console.ResetColor();

  System.Console.WriteLine("\n<<W>> para volver atras");
  string rol = Console.ReadLine()!;

  switch(rol)
  {
      case "1":
        Console.ForegroundColor = ConsoleColor.Magenta;
        System.Console.Write("\nNuevo texto del ROL 1: ");
        string editRol1 = Console.ReadLine()!;
        Console.ResetColor();

        rol1 = editRol1;
        Console.ForegroundColor = ConsoleColor.Magenta;
        System.Console.WriteLine($"El ROL 1 se ha cambiado por: {rol1}");
        Console.ResetColor();
        
        Console.WriteLine("\n<<ENTER>> para volver al menu");
        Console.ReadKey();
        Console.Clear();
        break;

      case "2":
        Console.ForegroundColor = ConsoleColor.Blue;
        System.Console.Write("\nNuevo texto del ROL 2: ");
        Console.ResetColor();
        string editRol2 = Console.ReadLine()!;

        rol2 = editRol2;

        Console.ForegroundColor = ConsoleColor.Blue;
        System.Console.WriteLine($"El ROL 2 se ha cambiado por: {rol2}");
        Console.ResetColor();
        
        Console.WriteLine("\n<<ENTER>> para volver al menu");
        Console.ReadKey();
        Console.Clear();
        break;

      case "W":
      case "w":
      Console.Clear();
      break;

      default:
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("                                            ***Caracter invalido***");
      Console.ResetColor();
      System.Console.WriteLine("\n<<ENTER>> para volver al menu");
      Console.ReadKey();
      Console.Clear();
      break;
  }
  break;

  case "Q":
  case "q":
  Console.ForegroundColor = ConsoleColor.Yellow;
  Console.WriteLine("                                             ╔═════════════════════════════════════╗");
  Console.WriteLine("                                             ║         ¿Esta seguro de que         ║");
  Console.WriteLine("                                             ║     quiere salir del programa?:     ║");
  Console.WriteLine("                                             ║        [1] SI       [2] NO          ║");
  Console.WriteLine("                                             ╚═════════════════════════════════════╝");
  Console.ResetColor();
  string salirPrograma = Console.ReadLine()!;
  Console.Clear();

  switch(salirPrograma)
  {
    case "1":
    
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("                       + ---------------------------------------------------------------------------- +");
    Console.WriteLine("                       |   !!!Gracias por usar la Ruleta de Selección de Estudiantes, HASTA LUEGO!!!  |");
    Console.WriteLine("                       + ---------------------------------------------------------------------------- +");
    Console.ResetColor();
    Console.ReadKey();
    Console.Clear();
    Environment.Exit(0);
    break;

    case "2":
    Console.Clear();
    break;

    default:
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("                                            ***Caracter invalido***");
    Console.ResetColor();
    System.Console.WriteLine("\n<<ENTER>> para volver al menu");
    Console.ReadKey();
    Console.Clear();
    break;
  }
  
  break;

  default:
  Console.ForegroundColor = ConsoleColor.Red;
  Console.WriteLine("                                            ***Caracter invalido***");
  Console.ResetColor();
  System.Console.WriteLine("\n<<ENTER>> para volver al menu");
  Console.ReadKey();
  Console.Clear();
  break;
}

} while (menu != "K" && menu != "k");
