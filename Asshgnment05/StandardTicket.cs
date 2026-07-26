namespace Asshgnment05
{
    internal class StandardTicket : Ticket
    {
        public string SeatNumber { get; set; }
        public StandardTicket(string movieName,decimal price,string seatNumber) : base( movieName, price)
        {
            SeatNumber = seatNumber;
            
        }
        public override void Print()
        {
           base.Print();
            Console.WriteLine($"|SeatNumber:{SeatNumber}");
        }

        public override object Clone()
        {
            return new StandardTicket(MovieName, Price, SeatNumber);
        }

    }
}
