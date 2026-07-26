namespace Asshgnment05
{
    internal class VipTicket:Ticket
    {
        public bool LoungeAccess { get; set; }
        public decimal ServiceFees { get; set; }
        public VipTicket(string movieName, decimal price, bool Loungeaccess, decimal Fees) : base(movieName, price)
        {
            LoungeAccess = Loungeaccess;
            ServiceFees = Fees;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"|Lounge:{(LoungeAccess ? "Yes" : "No")}, Service Fees: {ServiceFees}");
        }
        public override object Clone()
        {
            return new VipTicket(MovieName,Price, LoungeAccess, ServiceFees);
        }
    }
}
