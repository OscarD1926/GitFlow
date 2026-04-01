using System;
using System.Collections.Generic;

class Program
{
    static List<Usuario> usuarios = new List<Usuario>();
    static int contadorId = 1;

    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n--- CRUD DE USUARIOS ---");
            Console.WriteLine("1. Crear usuario");
            Console.WriteLine("2. Mostrar usuarios");
            Console.WriteLine("3. Actualizar usuario");
            Console.WriteLine("4. Eliminar usuario");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    CrearUsuario();
                    break;
                case 2:
                    MostrarUsuarios();
                    break;
                case 3:
                    ActualizarUsuario();
                    break;
                case 4:
                    EliminarUsuario();
                    break;
            }

        } while (opcion != 5);
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
        Console.WriteLine("Usuario creado.");
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
        Console.Write("\nIngrese ID del usuario: ");
        int id = int.Parse(Console.ReadLine());

        var usuario = usuarios.Find(u => u.Id == id);

        if (usuario != null)
        {
            Console.Write("Nuevo nombre: ");
            usuario.Nombre = Console.ReadLine();

            Console.Write("Nuevo email: ");
            usuario.Email = Console.ReadLine();

            Console.WriteLine("Usuario actualizado.");
        }
        else
        {
            Console.WriteLine("Usuario no encontrado.");
        }
    }

    static void EliminarUsuario()
    {
        Console.Write("\nIngrese ID del usuario: ");
        int id = int.Parse(Console.ReadLine());

        var usuario = usuarios.Find(u => u.Id == id);

        if (usuario != null)
        {
            usuarios.Remove(usuario);
            Console.WriteLine("Usuario eliminado.");
        }
        else
        {
            Console.WriteLine("Usuario no encontrado.");
        }
    }
}