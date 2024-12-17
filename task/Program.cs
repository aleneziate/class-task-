// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Enter your name ");
string name = Console.ReadLine();
Console.WriteLine("Enter your language");
string language = Console.ReadLine();
if (language == "en") {
    Console.WriteLine("welcome  name");
}
else if (language == "es")
{

    Console.WriteLine("hola"+ name );
}
else if (language == "fr")
{

    Console.WriteLine("bonjour" + name);

}
else if (language == "tr")
{

    Console.WriteLine("merhaba"+ name );
}




Console.WriteLine("____________________");

Console.WriteLine("enter number 1");
double N1 = Convert.ToDouble (Console.ReadLine());
Console.WriteLine("enter number 2 ");
double N2 = Convert.ToDouble (Console.ReadLine());

if (N1 > N2)
{
    Console.WriteLine("number 1");
}
else if (N1 < N2)
{
    Console.WriteLine("number 2");
}








Console.WriteLine("---------------------");

Console.WriteLine("Enter mark");
double mark = Convert.ToDouble (Console.ReadLine());
if (mark >= 80) {
    Console.WriteLine("A");
        }
else if (mark >= 70){ 
    Console.WriteLine ("B");
}
else if (mark >= 60){


    Console.WriteLine("C");
}
else if(mark >= 50){
    Console.WriteLine("D");
        }


else if (mark <= 50)
{


    Console.WriteLine("f");
}




