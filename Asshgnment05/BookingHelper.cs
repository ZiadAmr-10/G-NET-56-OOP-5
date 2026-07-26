namespace Asshgnment05
{
    internal static class BookingHelper
    {
        public static void PrintAll (IPrintable[] tickets)
        {
            foreach (var ticket in tickets)
            {
                if (ticket != null)
                    ticket.Print();
            }
        }
    }
}
