public class program
{
    static void Main()
    {
        /*
        Console.WriteLine("kolejka");
        Queue<string> kolejka = new Queue<string>();
        kolejka.Enqueue(Console.ReadLine());
        kolejka.Enqueue(Console.ReadLine());
        kolejka.Enqueue(Console.ReadLine());
        kolejka.Enqueue(Console.ReadLine());
        kolejka.Enqueue(Console.ReadLine());
        foreach (string s in kolejka)
            Console.WriteLine("{0}", s);
        Console.WriteLine();
        string x = kolejka.Dequeue();
        Console.WriteLine("Pierwszy element w kolejce: " + x);
        foreach (string s in kolejka)
            Console.WriteLine("{0}", s);
        Console.WriteLine();
        x = kolejka.Peek();
        Console.WriteLine("Pierwszy w kolejce jest: " + x);
        foreach (string s in kolejka)
            Console.WriteLine("{0}", s);

        Console.WriteLine("stos");
        Stack<char> stos=new Stack<char>();
        stos.Push('S');
        stos.Push('z');
        stos.Push('y');
        stos.Push('m');
        stos.Push('o');
        stos.Push('n');
        foreach(char c in stos)
            Console.WriteLine(c);*/
       
       
        List<double> lista=new List<double>();
        for(int i = 0 ; i < 10 ; i++)
        {
            Random rand=new ();   
            double d= Math.Round(rand.NextDouble(),2);
            lista.Add(d);
           
        }
        lista.Sort();
        foreach(double o in lista)
            Console.WriteLine("{0}",o);
        Console.WriteLine();
        double b=lista.First(); 
        double a= lista.Last();
        Console.WriteLine("Najwieksza liczba: " +b); 
        Console.WriteLine("Najmniejsza liczba: " +a);





    }


}

