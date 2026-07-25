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
            #endregion
        }
    }
}
