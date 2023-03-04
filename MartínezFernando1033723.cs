// CODIGO DE MI MENU ( U W U )


//Crear menu de un restarurante para poder despachar pedidos
//Items: Hamburguesas, Aguas, Papas, Helado, Pizza, Pastas y Postres
//Mostrar el menu
//Ordenar
//Pago

//Variables

bool _continuar = false;
int _opcionMenu = 0;
int _menu1 = 0, _menu2 = 0, _menu3 = 0, _menu4 = 0, _menu5 = 0, _menu6 = 0, _menu7 = 0;
int _precioMenu1 = 35, _precioMenu2 = 45, _precioMenu3 = 40, _precioMenu4 = 20, _precioMenu5 = 20, _precioMenu6 = 15, _precioMenu7 = 35;

Console.WriteLine("El menu es:");
Console.WriteLine("1. Hamburguesas de Lomito");
Console.WriteLine("2. Pastas al Pesto");
Console.WriteLine("3. Pizza de Pepperoni");
Console.WriteLine("4. Postres - Pastel de Triple Chocolate");
Console.WriteLine("5. Papas Fritas con Queso");
Console.WriteLine("6. Helado - Galleta");
Console.WriteLine("7. Bebidas");

Console.WriteLine("Seleccione los items del menu que desea ordenar");
try
{
    do
    {
        _opcionMenu = int.Parse(Console.ReadLine());

        switch (_opcionMenu)
        {
            case 1:
                _menu1++;
                break;
            case 2:
                _menu2++;
                break;
            case 3:
                _menu3++;
                break;
            case 4:
                _menu4++;
                break;
            case 5:
                _menu5++;
                break;
            case 6:
                _menu6++;
                break;
            case 7:
                _menu7++;
                break;
            default:
                Console.WriteLine("Número inválido, ingrese un número que sea válido");
                break;
        }

        Console.WriteLine("Desea continuar? si/no");
        string _respuesta = Console.ReadLine().ToLower();

        if (_respuesta == "si")
        {
            _continuar = true;
            Console.WriteLine("Ingrese el siguiente item del menu que desea ordenar");


        }
        else
        {
            int total = 0;

            Console.WriteLine("El costo es:");

            if (_menu1 > 0)
            {
                total += _menu1 * _precioMenu1;
                Console.WriteLine("Hamburguesa de Lomito: " + _menu1 * _precioMenu1);
            }
            if (_menu2 > 0)
            {
                total += _menu2 * _precioMenu2;
                Console.WriteLine("Pasta al Pesto: " + _menu2 * _precioMenu2);
            }
            if (_menu3 > 0)
            {
                total += _menu3 * _precioMenu3;
                Console.WriteLine("Postre - Pastel de Triple Chocolate: " + _menu3 * _precioMenu3);
            }
            if (_menu4 > 0)
            {
                total += _menu4 * _precioMenu4;
                Console.WriteLine("Pizza de Pepperoni: " + _menu4 * _precioMenu4);
            }
            if (_menu5 > 0)
            {
                total += _menu5 * _precioMenu5;
                Console.WriteLine("Helado - Galleta: " + _menu5 * _precioMenu5);
            }
            if (_menu6 > 0)
            {
                total += _menu6 * _precioMenu6;
                Console.WriteLine("Papas Fritas con Queso: " + _menu6 * _precioMenu6);
            }
            if (_menu7 > 0)
            {
                total += _menu7 * _precioMenu7;
                Console.WriteLine("Bebidas: " + _menu7 * _precioMenu7);
            }
            Console.WriteLine("Total a pagar: " + total);

            _continuar = false;
            //int Total = _precioMenu1 + _precioMenu2 + _precioMenu3 + _precioMenu4 + _precioMenu5 + _precioMenu6 + _precioMenu7;

            _continuar = false;

        }

    } while (_continuar == true);
}
catch (Exception)
{
    Console.WriteLine("Ha existido un error. Vuelva a ejecutar el programa");

};

Console.ReadKey();