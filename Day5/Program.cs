using static System.Console;
using Day05;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;

Person yuli = new Customer("Gus","Samsudin", "gus@gmail.com", new DateTime (1852,4,2),"131-001");
Customer widi = new Customer("MySweety", "Widi", "widi@gmail.com", new DateTime(1999, 2, 5), "131-002");
Customer rini = new Customer("Irham", "Yuli", "irham@gmail.com", new DateTime(1999, 2, 5), "131-002");
Owner owner1 = new Owner("Ujang", "Mardijang", "Ujang@gmail.com", new DateTime(1959, 2, 5),4);
Owner owner2 = new Owner("Asep", "Markecep", "Asep@gmail.com", new DateTime(1949, 2, 5), 3);
Owner owner3 = new Owner("Senpai", "Faiz", "Senpai@gmail.com", new DateTime(1989, 2, 5), 2);

var listOfCustomer = new List<Person> { yuli, widi, rini,owner1,owner2,owner3 } ;
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

var incomeOwner1 = new Dictionary<string, decimal>
{
    {"PT.CINTA ABADI",500_000_000 },
    {"PT.CINTA PALSU",350_000_000 },
     {"PT.CINTA BUTA",100_000_000 },
    {"PT. CINTA DUIT",400_000_000 }

};
owner1.TotalIncome(incomeOwner1);
owner1.TotalReveneu = owner1.TotalIncome(incomeOwner1);


var incomeOwner2 = new Dictionary<string, decimal>
{
      {"PT.PUTUS TALI",500_000_000 },
    {"PT.TALI APAANTUH",350_000_000 },
     {"PT.CINTA GILA",100_000_000 }
};
owner2.TotalIncome(incomeOwner2);
owner2.TotalReveneu=owner2.TotalIncome(incomeOwner2);

var IncomeOwner3 = new Dictionary<string, decimal>
{
      {"PT.SAMBO JENDRAL",500_000_000 },
    {"PT.BJ MAHMUD",350_000_000 }
};

owner3.TotalIncome(IncomeOwner3);
owner3.TotalReveneu = owner3.TotalIncome(IncomeOwner3);

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