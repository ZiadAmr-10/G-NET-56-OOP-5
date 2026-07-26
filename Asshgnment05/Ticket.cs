namespace Asshgnment05
{
    internal abstract class Ticket : IPrintable,IBookable,ICloneable
    {
        public string MovieName { get; set; }
        private decimal price;
        private static int Counter = 0;
        public int TicketId { get; }
        public decimal Price
        {
            get => price;
            set
            {
                if (value > 0)
                    price = value;
                else
                    throw new InvalidDataException("Invalid Number ");
            }
        }
        public decimal PriceAfterTax => Price * 1.14m;

        protected bool isBooked=false;
        public Ticket(string movieName, decimal price)
        {
            MovieName = movieName;
            Price = price;
            Counter++;
            TicketId = Counter;
        }
        public  bool Book()
        {
            if (isBooked == false)
            {
                isBooked = true;
                return true;
            }
            else
                return false;
        }
        public  bool Cancel()
        {
            if (isBooked == true)
            {
                isBooked= false;
                return true;
            }
            else 
                return false;
        }
       public virtual void Print()
        {
            Console.Write($"Ticket # {TicketId} |{MovieName} | Price: {Price}|After Tax : {PriceAfterTax}|Booked:{(isBooked?"Yes":"No")}");
        }
        public abstract object Clone();
    }
}
