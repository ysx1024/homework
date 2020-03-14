using System;

namespace number_one
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public GenericList()
        {
            tail = head = null;
        }
        public Node<T> Head
        {
            get => head;
        }
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void ForEach(Action<T> action)
        {
            for (Node<T> node = this.head; node != null; node = node.Next)
            {
                action(node.Data);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> intlist = new GenericList<int>();
            for (int x=0;x<10;x++)
            {
                intlist.Add(x);
            }
            intlist.ForEach(x=>Console.WriteLine(x));
            int max = 0;
            int min = 0;
            int sum = 0;

            intlist.ForEach(x=> 
            {
                if (max < x)
                    max = x;
            });
            Console.WriteLine("最大值为："+max);

            intlist.ForEach(x=>
            {
                if (min > x)
                    min = x;
            });
            Console.WriteLine("最小值为："+min);

            intlist.ForEach(x=> sum+=x);
            Console.WriteLine("和为："+sum);

            Console.ReadLine();
        }
    }
}
