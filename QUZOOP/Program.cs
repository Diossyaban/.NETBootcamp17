using static System.Console;
// call  class employee
//using Day4_oop.PartOne;
using Day4_oop.QUIZOOP;

WriteLine("==========================================");
ICar GetCar = new CarImpls();
var listCar = GetCar.InitListCar();
GetCar.ShowList(ref listCar);

WriteLine("==========================================");




ReadLine();
