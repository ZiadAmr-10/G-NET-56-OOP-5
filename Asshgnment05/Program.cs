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
             The problem is that both interfaces contain a method with the same signature.
             In the  design one method implicitly implements both interfaces
             and both interfaces use the same implementation and the class cannot provide different behavior for each interface
             To handle this problem  the class should implement each method separately using the interface name
             Then call the required method through an interface reference or by casting the object to the required interface.
             */
            #endregion
            #endregion
        }
    }
}
