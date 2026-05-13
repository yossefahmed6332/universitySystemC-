using System.Collections;
using System.Runtime.CompilerServices;

int [] numbers = new int [] {1 ,3 ,4 ,5 ,2};


Array.Sort(numbers);
foreach (var number in numbers)
{
    Console.WriteLine(number);
}



ArrayList arrayList = new ArrayList();
arrayList.Add(1);
arrayList.Add("Hello");
arrayList.Add(3.14);


foreach (var item in arrayList)
{
    Console.WriteLine(item);
}


void printFrom1ToN(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine(i);
    }
}