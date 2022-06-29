// Задача 2
// Console.WriteLine("Введите два числа");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// if (a>b)
// {
//     Console.WriteLine("{0} наибольшее число", a);
// }
// else
// {
//     Console.WriteLine("{0} наибольшее число", b);
// }


// Задача 4
// Console.WriteLine("Введите 3 числа");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// int c = Convert.ToInt32(Console.ReadLine());
// if ( (a>b) && (a>c) )
// {
//     Console.WriteLine("{0} наибольшее число", a);
// }
// if ( (c>a) && (c>b) )
// {
//     Console.WriteLine("{0} наибольшее число", c);
// }
// if ((b>c)&&(b>a))
// {
//     Console.WriteLine("{0} наибольшее число", b);
// }


// Задача 6
// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a%2==0)
// {
//     Console.WriteLine("число четное");
// }
// else
// {
//      Console.WriteLine("число нечетное");
// }


// Задача 8
int N = int.Parse(Console.ReadLine());
int i = 1;            
while (i<N)
{
	if (i % 2 == 0)
	{
		Console.Write((i + " "));
	}
	i++;
}