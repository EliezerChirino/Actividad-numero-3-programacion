using System;

namespace ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            bool llave2 = true; 
            bool llave1 = true;
            double montottal = 0;
            string cadena = "";
            double acumulador= 0;
            double monto;
            string clave;
            bool autenticado = false;
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Para Iniciar el programa, indique la contraseña");
                clave = Console.ReadLine();
                if (clave == "1234")
                {
                    autenticado = true;
                    break;
                    ;
                }
                else
                {
                    Console.WriteLine("Clave incorrecta");
                }
            }
            if (autenticado == true)
            {
                

                Console.WriteLine("Bienvenido al programa");
                while (llave2)
                {
                    Console.WriteLine("A continuacion los datos del cliente");
                    registro objcliente = new registro();
                    objcliente.bautizar("Eliezer", "Edad: 18", 3009478);
                    Console.WriteLine("cliente " + objcliente.Nombre + " edad " + objcliente.Edad + " numero de cedula: " + objcliente.Cedula);
                while (llave1)
                {
                    Console.WriteLine("Ingrese el monto");
                cadena = Console.ReadLine();
                        
                        monto = Convert.ToInt32(cadena);
                        
                        if ((monto >0 && monto <= 2)){
                        Console.WriteLine("Ingrese de nuevo el producto");
                            
                        }
                        if (monto > 2) 
                        {
                            Console.WriteLine("siguiente producto");
                            acumulador = acumulador + monto;
                        }

                        if (monto == 0)
                    {
                        llave1 = false;
                        
                        montottal = acumulador + (acumulador * 20 / 100);
                        Console.WriteLine("El monto total con 20% de IVA, que pagará el cliente " + objcliente.Nombre+ " edad: "+ objcliente.Edad + " numero de cedula: "+ objcliente.Cedula +  " es "+ montottal);
                            
                    }
                    }
                    Console.WriteLine("si desea no continuar con el programa ingrese 0");
                    cadena = Console.ReadLine();
                    int l = Convert.ToInt32(cadena);
                    if (l == 0)
                    {
                        llave2 = false;
                    }
                }



            }

            else { Console.WriteLine("demasiados intentos fallidos, no se puede iniciar el programa"); }
        }
        }
        }
        class registro
        {
        private string nombre;
         private int cedula;
         private string edad;

    public string Nombre { get => nombre; set => nombre = value; }
    public int Cedula { get => cedula; set => cedula = value; }
    public string Edad { get => edad; set => edad = value; }

    public void   bautizar (string _nombre, string _edad, int _cedula)
            {
        nombre = _nombre;
        Edad= _edad;
        cedula = _cedula;

            }
        }
