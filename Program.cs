using System;

namespace SimpleClassConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime1 = new DateTime(2018, 6, 1, 12, 0, 0);
            DateTime dateTime2 = DateTime.Now;
            TimeSpan timeSpan = dateTime2 - dateTime1;
            Console.WriteLine($"{timeSpan.Days} {timeSpan.Hours}{timeSpan.Minutes}{timeSpan.Seconds}");

        }
    }
    class Airplane
    {
        static void Main(string[] args)
        {
            string pointName;
            int number;
            DateTime time;
        }

        public Airplane(string Pointname, int Number, DateTime Time)
        {
            pointName = Pointname;
            number = Number;
            time = Time;
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public string PointName
        {
            get { return pointName; }
            set { pointName = value; }
        }
        public DateTime TimeToFly
        {
            get { return time; }
            set { time = value; }
        }
        class Test
        {
            static void Main(string[] args)
            {
                Airplane airplane = new Airplane();
                Airplane plane = new Airplane("Москва", 999999, new DateTime(2011, 5, 26, 20, 0, 0, 0));
                Airplane plane1 = new Airplane("Киев", 999998, new DateTime(2011, 5, 26, 20, 10, 0, 0));
                Airplane plane2 = new Airplane("Минск", 999997, new DateTime(2011, 5, 26, 20, 20, 0, 0));
                Airplane plane3 = new Airplane("Париж", 999996, new DateTime(2011, 5, 26, 22, 0, 0, 0));

            }
        }
    }
    class Date
    {
        static void Main(string[] args)
        {
            int Year;
            int Day;
            int Hours;
            int Minutes;
        }
        public Date(int Year, int Day, int Hours, int Minutes);
        {
        year=Year;
        day=DayOfWeek;
        hours=Hours;
        minutes=Minutes;
        }
    public int Year
    {
        get { new Year; }
        set { Year = value; }
    }
    public string Day
    {
        get {new DayofWeek; }
        set { DayOfWeek = value; }
    }
    public DateTime Hours
    {
        get { new  time; }
        set { time = value; }
    }
    public DateTime Minutes
    {
        get { return Minutes; }
        set { Minutes = value; }
    }
}
class Product
{
    static void Main(string[] args)
    {
        int Name;
        int Price;
        int Cost;
        int Quantity;
        int Producer;
        int Weight;
    }
    public int Name
    {
        get { Name; }
        set { namespace; }
    }
    public string Price
    {
        get { Price; }
        set { Price = value; }
    }
    public DateTime Cost
    {
        get { Cost; }
        set { time = value; }
    }
    public DateTime Quantity
    {
        get { Quantity; }
        set { Minutes = value; }
    }

    public DateTime Producer
    {
    get { Producer; }
    set { Minutes = value; }
    }
    public DateTime Weight
    {
    get { Weight; }
    set { Minutes = value; }
    }
}
class Currency {
    static void Main(string[] args)
    {
        int Name;
        int ExRate;
    }
    public DateTime Name
    {
        get { Name; }
        set {namespace; }
    }
    public DateTime ExRate
    {
    get { ExRate; }
    set { new ; }
    }
}


