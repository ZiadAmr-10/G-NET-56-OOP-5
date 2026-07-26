using System.Runtime.InteropServices;

namespace Asshgnment05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            #region Quesion01
            /*
             An interface is a contract that defines a set of members without implementation(Signature members).
             use interfaces instead of depending on concrete classes to achieve abstraction and loose coupling and
             allows to change implementations without modifying the code that uses them.
             Benefits of interface : 
             Enable polymorphism.
             Reduce tight coupling.
             Make testing easier.
             Allow multiple inheritance of behavior  
             */
            #endregion
            #region Question02
            /*
            A) The problem is that both interfaces contain a method with the same signature.
             .In the  design one method implicitly implements both interfaces
             .and both interfaces use the same implementation and the class cannot provide different behavior for each interface
             .To handle this problem  the class should implement each method separately using the interface name
             .Then call the required method through an interface reference or by casting the object to the required interface.
            B)The problem can fixed by using Explicit Interface 
               Each interface method is implemented separately using the interface name and each interface has its own behavior
               This technique is called Explicit Interface Implementation and the methods are called through an interface reference or by casting to the required interface.
            C) No , Because explicit interface members are hidden from the class reference
               They can only be accesse by interface reference or by casting the object to the required interface.
             */
            #endregion
            #region Question03
            /*
             The Shallow copy and deep copy using to copy the object in heap
             The shallow copy copies the object when the object has value type copy it, but when the object has reference type copy the reference 
             and still point to the same object
             in case : the reference type is refere to string ,the object one doesn't affect becasue the string is immutable
             but if it's string builder or other reference type it's risky because its copy the reference and still can access to the same value and modify it 
             Deep copy copies both value-type and reference type and creates new object
             so it uses more memory and is slower than a shallow copy and the risk  less than a shallow copy.
             Use shallow copy when sharing reference objects is acceptable
             Use deep copy when you need a completely independent copy 
             */
            #endregion
            #region Question04
            /*
             The output : 
             Dev-Testing
             QA-Testing
             Why : 
             Because the e2 copies the Reference not vlaue because it's reference type 
             when it refers to (string Title) copies the reference
             when changed it didn't affect to e1 because string is immutable 
             but when copies the reference of (Department Dept) it refers to the reference 
             and when change it ,Changes the name of the same Department object because both e1 and e2 refer to the same object 
             */
            #endregion
            #endregion
            #region Part02
            Cinema cinema=new Cinema("Cinema");
            cinema.OpenCinema();
            StandardTicket Ticket1 = new StandardTicket("Avengers", 200, "A5");
            Ticket1.Book();
            cinema.Add(Ticket1);
            VipTicket Ticket2 = new VipTicket("Spiderman", 300, true, 50);
            Ticket2.Book();
            cinema.Add(Ticket2);
            IMaxTicket Ticket3 = new IMaxTicket("inception",400,true);
            Ticket3.Book();
            cinema.Add(Ticket3);
            Console.WriteLine("==========All Tickets===========");
            cinema.PrintAllTickets();
            VipTicket Ticket4 = (VipTicket)Ticket2.Clone();
            Ticket4.MovieName = "Batman";
            Console.WriteLine("=========Clone Test==========");
            Console.WriteLine("Original:");
            Ticket2.Print();ٍ
            Console.WriteLine("Clone:");
            Ticket4.Print();
            Console.WriteLine("=========After Canciling==========");
            Ticket1.Cancel();
            Ticket1.Print();
            Console.WriteLine("==========Booking Helper All Tickets==========");
            IPrintable[] Tickets = {Ticket1, Ticket2,Ticket3,Ticket4};
            BookingHelper.PrintAll(Tickets);
            cinema.CloseCinema();

            #endregion
        }
    }
}
