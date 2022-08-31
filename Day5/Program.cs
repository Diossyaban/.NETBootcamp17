using static System.Console;
using Day05;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;

Person yuli = new Customer("Gus","Samsudin", "gus@gmail.com", new DateTime (1852,4,2),"131-001");
Customer widi = new Customer("MySweety", "Widi", "widi@gmail.com", new DateTime(1999, 2, 5), "131-002");
Customer rini = new Customer("Irham", "Yuli", "irham@gmail.com", new DateTime(1999, 2, 5), "131-002");

var listOfCustomer = new List<Person> { yuli, widi, rini } ;
var incomeYuli = new Dictionary<string, decimal>
{
    {"Kontrakan",10_000_000 },
    {"Toko",100_000_000 }
};

//income YULI 
yuli.TotalIncome(incomeYuli);
yuli.TotalReveneu = yuli.TotalIncome(incomeYuli);


var incomeWidi= new Dictionary<string, decimal>
{
    {"Istri Dios",20_000_000 },
    {"Jual Online",6_000_000 }
};
//income My Sweety Widi
widi.TotalIncome(incomeWidi);
widi.TotalReveneu = widi.TotalIncome(incomeWidi);


var incomeRini = new Dictionary<string, decimal>
{
    {"Judi Online",50_000_000 },
    {"Jambret",6_000_000 }
};

rini.TotalIncome(incomeRini);
rini.TotalReveneu = widi.TotalIncome(incomeRini);

foreach (var item in listOfCustomer)
{
    WriteLine($"{item.ToString()}");
}

WriteLine("==================================Revenue Highest==================================");


var listHighest = listOfCustomer.Where(c => c.TotalReveneu <= 50_000_000).ToList();

foreach (var item in listHighest)
{
    WriteLine($"{item.ToString()}");
}

WriteLine("==========Mininum===========");

var listmin = listOfCustomer.Min(x => x.TotalReveneu);
WriteLine($"Cust min Revenue : {listmin.ToString("C", new CultureInfo("id-ID"))}");

WriteLine("==========Max==========");
var listmax = listOfCustomer.Max(x => x.TotalReveneu);
WriteLine($"Cust min Revenue : {listmax.ToString("C", new CultureInfo("id-ID"))}");

var listLessThanMax = listOfCustomer.Where(x => x.TotalReveneu < listmax);
foreach (var item in listLessThanMax)
{
    WriteLine($"{item.ToString()}");
}


WriteLine("-------------------Select----------------");
var query = listOfCustomer.Select(cust =>
new
{
    FullName = cust.FirstName += " " + cust.LastName,
    Email = cust.Email,
    TotalRevenue = cust.TotalReveneu.ToString("C",new CultureInfo("id-ID"))
        }
           );
foreach (var item in query)
{
    WriteLine(item);
}

//WriteLine("================================= LinQ =================================");
//LinQ.IntroLinq();