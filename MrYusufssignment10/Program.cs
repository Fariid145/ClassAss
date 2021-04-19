using System;


public class MrYusufssignment10 {
  static void Main(string[] args)
        {
            Console.WriteLine(firstToLast("Melewi"));
           
        }
       public static string firstToLast(string well)
        {
            return well.Length > 1
                ? well.Substring(well.Length - 1) + well.Substring(1, well.Length - 2) + well.Substring(0, 1) : well;
        }
}