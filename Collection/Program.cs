using System;
using System.Collections.Generic;

namespace Collection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack();
        }
        public static void List()
        {
            List<Casa> Casas = new List<Casa>();

            Casa instancia = new Casa { Calle = "9 de julio", Numero = "2524" };


            Casas.Add(instancia);
            Casas.Add(new Casa { Calle = "San martin", Numero = "2524" });
            Casas.Add(new Casa { Calle = "Jujuy", Numero = "2524" });
            Casas.Add(new Casa { Calle = "Caceros", Numero = "2524" });
            Casas.Add(new Casa { Calle = "Malvinas", Numero = "2524" });

            Console.WriteLine("ADD");

            foreach (Casa casa in Casas)
                Console.WriteLine(casa.ToString());

            Console.WriteLine("INSERT");
            Casas.Insert(2, new Casa { Calle = "Entre Rios", Numero = "2524" });

            foreach (Casa casa in Casas)
                Console.WriteLine(casa.ToString());

            Console.WriteLine("REMOVE");

            Casas.Remove(instancia);

            Casas.RemoveAt(Casas.Count - 1);

            foreach (Casa casa in Casas)
                Console.WriteLine(casa.ToString());

        }

        public static void Dictionaries()
        {
            Dictionary<string, Casa> dictionary = new Dictionary<string, Casa>();
            Casa instancia = new Casa { Calle = "9 de julio", Numero = "2524" };
            
            dictionary.Add("Julio", instancia);
            dictionary.Add("Abril", new Casa { Calle = "San martin", Numero = "2524" });
            dictionary.Add("Mayo", new Casa { Calle = "Jujuy", Numero = "2524" });
            dictionary.Add("Junio", new Casa { Calle = "Caceros", Numero = "2524" });
            dictionary.Add("Agosto", new Casa { Calle = "Malvinas", Numero = "2524" });

            Console.WriteLine("INSERT");

            foreach (var iter in dictionary)
            {
                Console.WriteLine(
                    $"key: {iter.Key} value: {iter.Value.ToString()}"
                    );
            }
            Console.WriteLine("UPDATE");

            Console.WriteLine(dictionary["Julio"].ToString());

            dictionary["Julio"].Numero = "5864";

            Console.WriteLine(dictionary["Julio"].ToString());

            dictionary["Julio"] = new Casa { Calle = "Rivadavia", Numero = "1234"};

            Console.WriteLine(dictionary["Julio"].ToString());

            Console.WriteLine("REMOVE");

            dictionary.Remove("Agosto");

            foreach (var iter in dictionary)
            {
                Console.WriteLine(
                    $"key: {iter.Key} value: {iter.Value.ToString()}"
                    );
            }
        }

        public static void Queque()
        {
            Queue<Casa> cola = new Queue<Casa>();

            Casa instancia = new Casa { Calle = "9 de julio", Numero = "2524" };
            
            cola.Enqueue(instancia);
            cola.Enqueue(new Casa { Calle = "San martin", Numero = "2524" });
            cola.Enqueue(new Casa { Calle = "Jujuy", Numero = "2524" });
            cola.Enqueue(new Casa { Calle = "Caceros", Numero = "2524" });
            cola.Enqueue(new Casa { Calle = "Malvinas", Numero = "2524" });

            var casa = cola.Dequeue();

            Console.WriteLine("INSERT");

            Console.WriteLine(cola.Dequeue().ToString());

            cola.Enqueue(casa);

            Console.WriteLine("UPDATE");

            foreach (var iter in cola) 
            {
                iter.Numero = "854";
            }

            Console.WriteLine("DELETE");
            while(cola.Count > 0)
            {
                var casa1 = cola.Dequeue();
                Console.WriteLine(casa1.ToString());
            }

        }

        public static void Stack()
        {
            Stack<Casa> pila = new Stack<Casa>();

            Casa instancia = new Casa { Calle = "9 de julio", Numero = "2524" };

            pila.Push(instancia);
            pila.Push(new Casa { Calle = "San martin", Numero = "2524" });
            pila.Push(new Casa { Calle = "Jujuy", Numero = "2524" });
            pila.Push(new Casa { Calle = "Caceros", Numero = "2524" });
            pila.Push(new Casa { Calle = "Malvinas", Numero = "2524" });


            Console.WriteLine(pila.Pop().ToString());

            foreach (var iter in pila)
            {
                iter.Numero = "854";
            }

            Console.WriteLine("DELETE");
            while (pila.Count > 0)
            {
                var casa1 = pila.Pop();
                Console.WriteLine(casa1.ToString());
            }
        }

    }

    public class Casa
    {
        public string Calle { get; set; }
        public string Numero { get; set; }

        public override string ToString()
        {
            return $"calle: {Calle}, número: {Numero}";
        }
    }
    
}
