using System;
using Banco_DAS.app_code;

namespace Banco_DAS
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Instancias
            Account debito = new Debit()
            {
                Id = 117250628,
                Name = "Diego",
                LastNameFather = "Rubi",
                LastNameMother = "Salas",
                AccountType = 1,
                Cash = 0
            };

            Account credito = new Credit()
            {
                Id = 117250628,
                Name = "Diego",
                LastNameFather = "Rubi",
                LastNameMother = "Salas",
                AccountType = 2,
                Cash = 0
            };
            #endregion

            Console.WriteLine("¡Bienvenidos a Banco DARS!\n");

            Console.WriteLine(debito.ToString());

            Console.ReadKey();
        }

        private void OptionList()
        {
            int opcion;
            do
            {
                opcion = ShowMenu();
                switch (opcion)
                {
                    case 1:
                        
                        break;
                    case 2:
                        
                        break;
                    case 3:
                        
                        break;
                    case 4:
                        
                        break;
                    default:
                        break;

                }
            } while (opcion != 5);
        }

        private static int ShowMenu()
        {
            Console.Write(@"
                                  Este es el menu de opciones.
                              __________________________________
                              1. Retirar dinero de la cuenta.
                              2. Filtrar los vehículos por año
                              3. Obtener los detalles de un vehículo por ID
                              4. Agregar un vehículo
                              5. Salir
                              __________________________________
                                  ");

            int.TryParse(Console.ReadLine(), out int result);
            return result;
        }
    }

    class Instances
    {
        
    }
}
