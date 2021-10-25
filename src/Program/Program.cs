using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);
            Node n7 = new Node(7);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            Person Rosa = new Person("Rosa", 87);
            Person Luis = new Person("Luis", 90);
            Person Daniel  = new Person("Daniel", 65);
            Person Cecilia = new Person("Cecilia", 65);
            Person Lucas = new Person("Lucas", 26);
            Person Agustina = new Person("Agustina", 27);
            Person Maria_Paz = new Person("Maria Paz",5);
            Person Antonio = new Person("Antonio",10);         


            // visitar el árbol aquí
        }
    }
}
