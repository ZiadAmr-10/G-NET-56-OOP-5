namespace Asshgnment05
{
    internal class IMaxTicket:Ticket
    {
        public bool Is3D { get; set; }
        public IMaxTicket(string movieName, decimal price, bool is3d) : base(movieName, price)
        {
            Is3D = is3d;
        }
        public decimal PriceAfter3D => Is3D ? PriceAfterTax + 30 : Price;
        public override void Print()
        {
            base.Print();
            Console.WriteLine($",3D:{(Is3D ? $"Yes + (30) Price :{PriceAfter3D}" : "No")}");
        }
        public override object Clone()
        {
           return new IMaxTicket(MovieName, Price, Is3D);
        }
    }
}
