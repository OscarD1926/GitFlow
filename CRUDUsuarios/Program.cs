using System;
using System.Collections.Generic;

class Program
{
    static List<Usuario> usuarios = new List<Usuario>();
    static int contadorId = 1;

    static void Main()
    {
        CrearUsuario();
        MostrarUsuarios();
        ActualizarUsuario(); 
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

    static void MostrarUsuarios()
    {
        Console.WriteLine("\nLista de usuarios:");

        foreach (var u in usuarios)
        {
            Console.WriteLine($"{u.Id} - {u.Nombre} - {u.Email}");
        }
    }

    static void ActualizarUsuario()
    {
        Console.Write("\nIngrese ID del usuario a actualizar: ");
        int id = int.Parse(Console.ReadLine());

        var usuario = usuarios.Find(u => u.Id == id);

        if (usuario != null)
        {
            Console.Write("Nuevo nombre: ");
            usuario.Nombre = Console.ReadLine();

            Console.Write("Nuevo email: ");
            usuario.Email = Console.ReadLine();

            Console.WriteLine("Usuario actualizado correctamente.");
        }
        else
        {
            Console.WriteLine("Usuario no encontrado.");
        }
    }
}