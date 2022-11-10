using System.Security.Cryptography.X509Certificates;
using System;
namespace app
{
    class program 
    {
public static void Main(string[] agrs)
{
    int a , b ,c  ;
    
    Console.Write("How many do you want to booking table : ");
    a = Convert.ToInt32(Console.ReadLine());
Console.Write("Shabu (1)/ butter roast (2) / All (3): ");
 b = Convert.ToInt32(Console.ReadLine());
 
 if (b==1) // if else
 {
Console.WriteLine("You select Shabu");

 }
 else if(b==2)
 {
Console.WriteLine("You select butter roast");
 }
 else if(b==3)
 {
Console.WriteLine("You select All");
 }
 else 
 {
Console.WriteLine("You must select 1/2/3 :) ");
 }
int choice = 7  ; // swich case 
Console.Write("Enter day number to select the day \nsunday-saturnday (1-7): "); 
choice = Convert.ToInt32(Console.ReadLine()); 
switch (choice){               case 1: 
     Console.WriteLine("Sunday");                   break;               case 2: 
    Console.WriteLine("Monday");                   break;               case 3: 
    Console.WriteLine("Tuesday");                   break;               case 4: 
    Console.WriteLine("Wednesday");                   break;               case 5: 
    Console.WriteLine("Thursday");                   break;                case 6: 
    Console.WriteLine("Friday");                   break;               case 7: 
    Console.WriteLine("Saturday");                   break;               default: 
    Console.WriteLine("Invalid day");                   break; 
                 
            } 
    Console.Write("How many people : ");
     c=Convert.ToInt32(Console.ReadLine());
 Console.Write("You have "+ c + "People");
int d = c;
   Console.WriteLine("This is you payment : " +d*299);
int e = 1 ;
do // loop do while
{
Console.WriteLine("The time period you will choose " + e );
e++ ;
}while (e<=3);
e= Convert.ToInt32(Console.ReadLine());

Console.Write("You choose : ");
if (e==1)
{
    Console.WriteLine("18.00 - 19.00 " );
}
else if (e==2 )
{
    Console.WriteLine("19.00 - 20.00 " );
}
else if (e==3)
{
    Console.WriteLine("20.00 - 21.00 " );
}
else
{
Console.WriteLine("No have this time" );
}
Console.Write("Enter you birthday here for discount : ");
int birth=Convert.ToInt32(Console.ReadLine());
Console.Write("This is sum your biryth for using promotion\n You can use  "+ SumBirth(birth)+"%  for a discount");

 static int SumBirth (int birth) // funtion or method 
 {
int sum = 0;
while (birth > 0)
{
int f = birth % 10;
sum += f;
birth /= 10;
}
return sum;
 }
 int g ;
 g = (d*(SumBirth(birth)%100));
 Console.WriteLine("Your dicount is : "+g );

    }
    
}
}