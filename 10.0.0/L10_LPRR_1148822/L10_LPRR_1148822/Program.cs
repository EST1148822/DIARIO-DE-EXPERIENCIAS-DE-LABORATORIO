class program
{
    static void Main(string[] args)
    {
        int fallas = 0;
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Ingrese su usuario");
            string Miusuario = Console.ReadLine();
            Console.WriteLine("Ingrese su contraseña:");
            string Micontraseña = Console.ReadLine();
            string res = Login(Miusuario, Micontraseña);
            
            if (res == "Verdadero")
            {
                Console.WriteLine(res);
                break;
            }

            Console.WriteLine(res);
            fallas++;

        }
        if (fallas == 3)

        {
            Console.WriteLine("Limite de intentos alcanzado");
        }
           
        
    }

    public static string Login(string Miusuario, string Micontraseña)

    { if (Miusuario == "usuario1" && Micontraseña == "asdasd")
            {
                return "Verdadero";
            }
            else

            {
                return "Usuario o Contraseña incorrecta.";
            }

            
        }
}
