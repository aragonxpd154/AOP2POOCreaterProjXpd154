using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Windows;
using System.ComponentModel;

namespace SISTEMA_DE_PEDIDOS
{
    class Inicio
    {
        static void Main(string[] args)
        {
            //ClassLoja.Menu();
            ClassFuncionario.ValidarFuncionario();
        }
    }
}


/*
namespace SISTEMA_DE_PEDIDOS
{
    internal class Inicio
    {
        static void Main(string[] args)
        {
            ClassPedido.pedido();
        }
    }
}






// C# Program to remove a range of
// elements from the List
using System;
using System.Collections;
using System.Collections.Generic;
  
class Geeks {
  
    // Main Method
    public static void Main(String[] args)
    {
  
        // Creating an List<T> of strings
        List<String> firstlist = new List<String>();
  
        // Adding elements to List
        firstlist.Add("Geeks");
        firstlist.Add("For");
        firstlist.Add("Geeks");
        firstlist.Add("GFG");
        firstlist.Add("C#");
        firstlist.Add("Tutorials");
        firstlist.Add("GeeksforGeeks");
  
        // Displaying the elements of firstlist
        Console.WriteLine("Elements in List:\n");
  
        foreach(string ele in firstlist)
        {
            Console.WriteLine(ele);
        }
  
        // removing 1 elements starting
        // from index 3
        firstlist.RemoveRange(3, 1);
  
        Console.WriteLine("");
  
        // Displaying the updated List
        Console.WriteLine("After Removing of elements:\n");
  
        // Displaying the elements in List
        foreach(string ele in firstlist)
        {
            Console.WriteLine(ele);
        }
    }
}
*/