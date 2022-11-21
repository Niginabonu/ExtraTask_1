/* min,sek,soat
int n = int.Parse(Console.ReadLine());
int sum = n / 60;
Console.WriteLine(sum);*/

/* 
int n = int.Parse(Console.ReadLine());
int b, sum = 0;
while (n > 0)
{
    b = n % 10;
    sum = sum * 10 + b;
    n = n / 10;
}
Console.WriteLine(" Teskari chop etish :" + sum);
*/


int n = int.Parse(Console.ReadLine());
int s = (n % 100) * 10 + (n / 100);
if (s > 1 && s < 999)
    Console.WriteLine(" Mavjud raqam:" + s);
else
    Console.WriteLine(" NaN ");