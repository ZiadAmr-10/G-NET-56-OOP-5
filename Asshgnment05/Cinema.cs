namespace Asshgnment05
{
    internal class Cinema
    {
        public string CinemaName { get; set; }
        IPrintable[] tickets= new IPrintable[20];

        public Cinema(string cinemaName)
        {
            CinemaName = cinemaName;
        }
        public void Add(IPrintable ticket)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if(tickets[i] == null)
                {
                    tickets[i] = ticket;
                    return;
                }
            }
            Console.WriteLine("Cinema is Full");
        }
        public void PrintAllTickets()
        {
            foreach (var ticket in tickets)
            {
                if(ticket != null)
                {
                    ticket.Print();
                }
            }
        }
        public void OpenCinema()
        {
            Console.WriteLine("==========Cinema Opened=========");
        }
        public void CloseCinema()
        {
            Console.WriteLine("========Cinema Closed==========");
        }
    }
}
