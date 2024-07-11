/*By changing the values of the predefined variables*/



/*int a = 20;
int b = 30;

b = a * b;
a = b / a;
b = b / a;

Console.WriteLine(a);
Console.WriteLine(b);

Console.WriteLine(a * b);
Console.WriteLine(a / b);
Console.WriteLine(a + b);
Console.WriteLine(a - b);
Console.WriteLine(a % b)*/








/*Checking whether the number is positive or neagtive using if else condition*/


/*string d = Console.ReadLine();
int a = Convert.ToInt32(d);

if (a > 0 && a != 0)
{
    Console.WriteLine("The number is positive");
}
else
{
    Console.WriteLine("The number is negative");

}*/






/*checking whether the input value is capital or small alphabet by adding and subtracting their askii value*/

/*string d = Console.ReadLine();
char enterchar = Convert.ToChar(d);
int acs = 0;

if ( enterchar >= 'A' && enterchar<= 'Z')
    {

    acs = enterchar + 32;

    Console.WriteLine((char)acs);
}

else
{
    acs = enterchar - 32;

    Console.WriteLine((char)acs);
}*/








/*Tasks Given  1 */


/*string ab = Console.ReadLine();
string bc = Console.ReadLine();
string de = Console.ReadLine();


int a = Convert.ToInt32(ab);
int b = Convert.ToInt32(bc);
int c = Convert.ToInt32(de);

int total = a + b + c;


if (total > 10000)
{
    Console.WriteLine("Discount is 5%");
}
else
{
    Console.WriteLine("Discount is 1%");
}*/









/*Task Given 2 */   /*total find the loss in percentage /
                     
                                          
/*string cp = Console.ReadLine();
string sp = Console.ReadLine();

int costprice = Convert.ToInt32(cp);
int sellprice = Convert.ToInt32(sp);

*//*int total = 0;
*//*
if (costprice > sellprice)
{

    

    Console.WriteLine("We have loss");
}
*/





/*Calculating the tax from the basic salary*/



/*Console.WriteLine("Basic Salary");

int basicsalary = Convert.ToInt32(Console.ReadLine());

int hra = 0;

int da = basicsalary * 50 / 100;

if (basicsalary > 0 && basicsalary < 5000)
{
    hra = basicsalary * 20 / 100;
}

else if (basicsalary > 5000 && basicsalary < 10000)
{
    hra = basicsalary * 30 / 100;
}


else if (basicsalary < 10000 && basicsalary > 20000)
{
    hra = basicsalary * 40 / 100;
}

else
{
    hra = basicsalary * 50 / 100;
}


int totalearning = basicsalary + hra + da;

int tax = totalearning * 10 / 100;

int inhand = totalearning - tax;

Console.WriteLine($"This is your inhand salary{inhand}");


*/



/*Checking wheter the sutdent is PasswordPropertyTextAttribute or fail based on the marks of the student*/


/*string maths = Console.ReadLine();   
string english = Console.ReadLine();
string hindi = Console.ReadLine();


int a = Convert.ToInt32(maths);
int b = Convert.ToInt32(english);
int c = Convert.ToInt32(hindi);

int total = (a + b + c )/ 3;


if (total > 70 ) 
{
    Console.WriteLine("Distinction");
}
 else if ( total < 70 && total >= 60)
{
    Console.WriteLine("Firstclass");
}
else if (total < 60 && total >= 50)
{
    Console.WriteLine("Secondclass");
}
else if ( total < 50 && total >= 40)
{
    Console.WriteLine("Thirdclass");
}
else
{
    Console.WriteLine("Fail");
}*/






/*
Console.WriteLine("Pleas enter your salary");

int salary = Convert.ToInt32(Console.ReadLine());

if (salary > 100000 && salary < 500001)
{
    Console.WriteLine(salary * 5 / 100);
}

else if (salary > 500001 && salary <= 1000000)
{
    Console.WriteLine(salary * 10 / 100);
}

else if (salary > 1000001 && salary <= 2000000)
{
    Console.WriteLine(salary * 20 / 100);
}
else
{
    Console.WriteLine("You does not come in any of the above tax bracket");
}
*/







/*Console.WriteLine("Your Reataurant Bill");

int Bill = Convert.ToInt32(Console.ReadLine());

if (Bill > 2000 && Bill <= 5000)
{
    Console.WriteLine(Bill * 18 / 100);
}

else if (Bill > 5001 && Bill <= 10000)
{
    Console.WriteLine(Bill * 28 / 100);
}

else if (Bill > 10001 && Bill <= 20000)
{
    Console.WriteLine(Bill * 38 / 100);
}

else if (Bill > 20001 && Bill <= 30000)
{
    Console.WriteLine(Bill * 50 / 100);
}

else
{
    Console.WriteLine(Bill * 60 / 100);
}*/





/*Console.WriteLine("Please Enter Your Height In cm");

int height = Convert.ToInt32(Console.ReadLine());

if (height > 100 && height <= 130)
{
    Console.WriteLine("The person is a dwarf");
}

else if (height > 131 && height <= 160)
{
    Console.WriteLine("The person is of Normal height");
}

else if (height > 161 && height <= 180)
{
    Console.WriteLine("The person has normal height");
}

else if (height > 180 && height <= 2000)
{
    Console.WriteLine("The person is a giant");
}

else
{
    Console.WriteLine("The person is out of this world");
}*/







/*Console.WriteLine("Please enter the Number of the Month");

int month = Convert.ToInt32(Console.ReadLine());

if (month > 0 && month <= 1)
{
    Console.WriteLine("The Month is January and it has 31 Days");
}

else if (month > 1 && month <= 2)
{
    Console.WriteLine("The month is February and it has 28 Days");
}

else if (month > 2 && month <= 3)
{
    Console.WriteLine("The month is March and it has 31 Days");
}

else if (month > 3 && month <= 4)
{
    Console.WriteLine("The month is April and it has 30 Days");
}

else if (month > 4 && month <= 5)
{
    Console.WriteLine("The month is May and it has 31 Days");
}

else if (month > 5 && month <= 6)
{
    Console.WriteLine("The month is June and it has 30 Days");
}

else if (month > 6 && month <= 7)
{
    Console.WriteLine("The month is July and it has 31 Days");
}

else if (month > 7 && month <= 8)
{
    Console.WriteLine("The month is August and it has 31 Days");
}

else if (month > 8 && month <= 9)
{
    Console.WriteLine("The month is September and it has 30 Days");
}
else if (month > 9 && month <= 10)
{
    Console.WriteLine("The month is October and it has 31 Days");
}
else if (month > 10 && month <= 11)
{
    Console.WriteLine("The month is November and it has 30 Days");
}
else if (month > 11 && month <= 12)
{
    Console.WriteLine("The month is December and it has 28 Days");
}
else
{
    Console.WriteLine("You have entered wrong value");
}*/






/*char vowel = 'a';

switch (vowel)
{
    case 'a':
        Console.WriteLine("This is a vowel");
        break;

    case 'e':
        Console.WriteLine("This is a vowel");
        break;
    case 'i':
        Console.WriteLine("This is a vowel");
        break;
    case 'o':
        Console.WriteLine("This is a vowel");
        break;
    case 'u':
        Console.WriteLine("This is a vowel");
        break;

    default:
        Console.WriteLine("This is not a vowel");
        break;*/
/*}*/





/*for (int i = 0; i < 10; i++)

{
    if (i % 2 == 0)
        Console.WriteLine(i);
}*/



/*for (int row = 1; row <= 3; row = row + 1)
{
    for (int column = 1; column <= row; column = column + 1)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}*/





/*Console.WriteLine("Here are the prime numbers Between 1 to 100");


for (int primenumber = 1; primenumber <= 100; primenumber++)
{
    if (primenumber % 2 == 0 &&)
    {
        Console.WriteLine
    }
}*/



/*
for (int row = 1; row < 4; row++)
{
    for (int col = 1; col <= row; col++)
    {
        Console.Write(col + " ");
    }

    Console.WriteLine();
}*/






/*for (int row = 1; row < 4; row++)
{
    for (int col = 1; col <= row; col++)
    {
        Console.Write(row + " ");
    }

    Console.WriteLine();
}*/





/*for (int col = 1; col < 3; col++)
{
    for (int row = 1; row <= col; row++)
    {
        Console.Write(col + " ");
    }

    Console.WriteLine();
}*/







/*for (int row = 4; row >= 1; row--)
{
    for (int col = row; col >= 1; col--)
    {
        Console.Write(col);
    }

    Console.WriteLine();
}*/








/*for (int row = 1; row <= 4; row = row + 1)
{
    for (int col = row; col >= 1; col = col - 1)
    {
        Console.Write(col);
    }

    Console.WriteLine();
}*/







/*
for (int number = 2; number <= 100; number = number + 1)
{
    bool isprime = true;

    for (int divider = 2; divider < number; divider = divider + 1)
    {
        if (number % divider == 0)
        {
            isprime = false;
            break;
        }
    }

    if (isprime == true)
    {
        Console.WriteLine(number);
    }
}*/






using ConsoleApp1;
using System.Data;

/*for (int row = 1 ; row <= 4 ; row = row + 1)
{
    for (int col = 1; col <= row; col = col + 1)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}*/





/*for(int row = 1; row <=6; row = row + 1)
{
    for ()
}*/





/*int[][] abc = new int[2][];

abc[0] = new int[2];

abc[1] = new int[3];


for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < abc[i].Length; j++)
    {
        abc[i][j] = Convert.ToInt32(Console.ReadLine());
    }

}


foreach (int[] p in abc)
{
    foreach (int n in p)
    {
        Console.WriteLine(n);
    }
}*/




//Two dimensional array

/*
int[,] a = new int[2, 2];

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        a[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}


foreach (int ab in a)
{
    if (ab < 0)
    {
        Console.WriteLine(ab);
        break;
    }
}*/


//Instead of foreach we can also use this method



/*int negetive = 0;

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        if (a[i, j] < 0)
        {
            negetive = a[i, j];
            break;
        }
    }

    if (negetive < 0)
    {
        break;
    }

}

Console.WriteLine(negetive);*/








/*int[][] abcd = new int[2][];

abcd[0] = new int[2];

abcd[1] = new int[3];

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < abcd[i].Length; j++)
    {
        abcd[i][j] = Convert.ToInt32(Console.ReadLine());
    }
}

foreach (int[] number in abcd)
{
    foreach (int n in number)
    {
        Console.WriteLine(n);
    }
}*/







/*
int[][] abc = new int[2][];

abc[0] = new int[2];

abc[1] = new int[3];


for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < abc[i].Length; j++)
    {
        abc[i][j] = Convert.ToInt32(Console.ReadLine());
    }

}


int max = abc[0][0];

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < abc[i].Length; j++)
    {
        if (abc[i][j] > max)
        {
            max = abc[i][j];
        }
    }

}

Console.WriteLine(max);*/






/*int[] descending = {23, 56, 12,23};


for(int i = 0; i > descending.Length; i++)
{
    if ( )
    {

    }
}
*/






/*To count the number of characters in the first word before the first space*/


/*string a = "ABC PQE SDFGGF";
int b = 0;

for (int i = 0; i < a.Length ; i++)
{
    if (a[i] == ' ')
    {
        break;
    }

    b = b + 1;
}

Console.WriteLine(b);*/







/*numberofwordz of characters without space*/


/*string wordz = "ABC STU PQR absc shb";

int numberofwordz = 0;

for (int i = 0; i < wordz.Length; i++)
{
    if (wordz[i] == ' ')
    {
        continue;
    }

    numberofwordz = numberofwordz + 1;
}


Console.WriteLine(numberofwordz);*/






/*Number of characters with space included*/


/*string wr = "ABC STU DIV GTU abnc";
int b = 0;

foreach ( char c in wr)
{
    b++;
}

Console.WriteLine(b);*/




/*To check whether the numbers are same or not*/

/*Console.WriteLine("Please enter the first number");

int firstnumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the second number");

int secondnumber = Convert.ToInt32(Console.ReadLine());


if (firstnumber == secondnumber)
{
    Console.WriteLine("The numbers are same");
}

else
{
    Console.WriteLine("The numbers are not same");
}*/






/*To check whether the number is negative or positive*/


/*Console.WriteLine("Enter the number");

int thenumber = Convert.ToInt32(Console.ReadLine());

if( thenumber > 0)
{
    Console.WriteLine("The number is positive");
}

else
{
    Console.WriteLine("The number is negative");
}*/



Class1 class1 = new();
class1.Input();
class1.Dispaly();



