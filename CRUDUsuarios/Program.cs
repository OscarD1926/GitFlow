using System;
using System.Collections.Generic;

class Program
{
    static List<Usuario> usuarios = new List<Usuario>();
    static int contadorId = 1;

    static void Main()
    {
        CrearUsuario();
    }

    static void CrearUsuario()
    {
        Usuario u = new Usuario();
        u.Id = contadorId++;

        Console.Write("Nombre: ");
        u.Nombre = Console.ReadLine();

        Console.Write("Email: ");
        u.Email = Console.ReadLine();

        usuarios.Add(u);

        Console.WriteLine("Usuario creado correctamente.");
    }
}
