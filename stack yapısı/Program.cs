using System;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
namespace Proje2
{
    class Program
    {
        static void Main(string[]args)
        {
            StackYapısı stc =new StackYapısı();
            int sayi;
           int secim= menu();
           while (secim !=0) 
           {
                switch (secim)
                {
                    case 1: Console.WriteLine("Sayı : "); sayi=int.Parse(Console.ReadLine());stc.push(sayi);break;
                    case 2:sayi= stc.pop();
                    if (sayi !=-1)
                    {
                        Console.WriteLine("Çıkan sayı : " + sayi);
                    }
                    else
                    Console.WriteLine("Stack boştur");break;
                    case 3: stc.print();break;
                    case 4: stc.topPrint();break;
                    case 0 :break;


                    default:
                    Console.WriteLine("Hatalı seçim."); 
                    break;
                }
                secim=menu();
           }
           Console.WriteLine("Program kapatılıyor...");
        }
        private static int menu()
        {
            int secim;
            Console.WriteLine("1-Push");
            Console.WriteLine("2-Pop");
            Console.WriteLine("3-Print");
            Console.WriteLine("4-Top");
            Console.WriteLine("0-Exit");
            secim=int.Parse(Console.ReadLine());
            return secim;   
        }
    }
    class Node
    {
       public int data;
       public Node next;
        public Node(int data)
        {
            this.data=data;
            next=null;
        }
    }
    class StackYapısı
    {
        Node top;
        public StackYapısı()
        {
            top=null;
        }

        public void push(int data)
        {
            Node eleman= new Node(data);
            if (top==null)
            {
               top=eleman;
               Console.WriteLine("Stack yapısı oluşturuldu , ilk eleman stack e yerleştirildi.");

            }
            else
            {
                eleman.next=top;
                top=eleman;
                Console.WriteLine("Eleman eklendi.");
            }
        }
        public int pop()
        {
            if (top==null)
            {
                Console.WriteLine("Stack boş.");    
                return -1;
            }
            else
            {
                int sayi= top.data;
                top=top.next; 
                Console.WriteLine(sayi + " Stackten çıkarıldı.");
                return sayi;
            }
        }
        public void print()
        {
            if (top==null)
            {
                Console.WriteLine("Stack boş.");
            }
            else
            {
                Node temp=top;
                while (temp!=null)
                {
                    Console.WriteLine(temp.data);
                    temp=temp.next;
                }
            }
        }
        public void topPrint()
        {
            if (top==null)
            {
                Console.WriteLine("Stack boş.");
            }
            else
            {
                Console.WriteLine(top.data);    
            }
        }
    }
}