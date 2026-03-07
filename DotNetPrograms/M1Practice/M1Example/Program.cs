// using System;
// using System.Collections.Generic;

// public class Order
// {
//     public int OrderId { get; set; }
//     public string CustomerName { get; set; }
//     public string Item { get; set; }
//     public Stack<Order> Add(int orderId, string customerName, string item)
//     {
//         Order o = new Order
//         {
//             OrderId = orderId,
//             CustomerName = customerName,
//             Item = item
//         };

//         Program.OrderStack.Push(o);
//         return Program.OrderStack;
//     }
//     public string Get()
//     {
//         if (Program.OrderStack.Count == 0)
//             return "Stack Empty";

//         Order top = Program.OrderStack.Peek();
//         return top.OrderId + " " + top.CustomerName + " " + top.Item;
//     }
//     public Stack<Order> Remove()
//     {
//         if (Program.OrderStack.Count > 0)
//             Program.OrderStack.Pop();

//         return Program.OrderStack;
//     }
// }

// public class Program
// {
//     public static Stack<Order> OrderStack = new Stack<Order>();

//     public static void Main()
//     {
//         Order obj = new Order();

//         Console.WriteLine("Enter number of orders:");
//         int n = int.Parse(Console.ReadLine());

//         for (int i = 0; i < n; i++)
//         {
//             int id = int.Parse(Console.ReadLine());
//             string name = Console.ReadLine();
//             string item = Console.ReadLine();

//             obj.Add(id, name, item);
//         }

//         Console.WriteLine("Most recent order:");
//         Console.WriteLine(obj.Get());

//         obj.Remove();

//         Console.WriteLine("After processing latest order:");
//         if (OrderStack.Count > 0)
//             Console.WriteLine(obj.Get());
//         else
//             Console.WriteLine("Stack Empty");
//     }
// }
