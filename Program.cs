
//Task - 1
//Verilmiş array-də tək ədədlərin sayını tapmaq və çap etmək.
// Məsələn: [1, 2, 3, 4, 5, 6, 7] => Tək ədədlərin sayı: 4

//int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
//int count = 0;



//foreach (int i in arr)
//{
//    if (i % 2 != 0)
//    {
//        count++;



//    }

//}
//Console.WriteLine(count);


//Task - 2
//Verilmiş array-də ən kiçik və ən böyük ədədlərin cəmini tapmaq. 
//Məsələn: [3, 8, 2, 10, 5] => Cəm: 12

//int[] arr = { 3, 8, 2, 10, 5 };
//int max = arr[0];
//int min = arr[0];

//foreach (int i in arr)
//{
//    if(i>max)
//    {
//       max= i;

//    }

//    if(i<min) 
//    { 
//        min= i; 

//    }


//}
//Console.WriteLine(max + min);

//Task - 3
//Verilmiş array-dəki ədədlərin ən böyük və ən kiçik fərqlərini tapmaq. 
//Məsələn: [5, 8, 15, 3, 7] => Fərq: 12

//int[] arr = { 5, 8, 15, 3, 7 };

//int max = arr[0];
//int min = arr[0];

//foreach (int i in arr)
//{
//    if (i > max)
//    {
//        max = i;

//    }

//    if (i < min)
//    {
//        min = i;

//    }


//}
//Console.WriteLine(max - min);

//Task - 4
//Verilmiş array-dəki ədədlərin sırasını artan sıraya salmaq. 
//Məsələn: [3, 1, 5, 4, 2] => [1, 2, 3, 4, 5]

//int[] array = { 3, 1, 5, 4, 2 };
//Array.Sort(array);

//Console.WriteLine("Artan sıralama:");
//foreach (int num in array)
//{
//    Console.Write(num + " ");
//}



//Task - 5
//Verilmiş array-dəki tək və cüt ədədlərin cəmini ayrı-ayrı tapmaq. 
//Məsələn: [1, 2, 3, 4, 5] => Tək ədədlərin cəmi: 9, Cüt ədədlərin

int[] array = { 1, 2, 3, 4, 5 };
int oddSum = 0;
int evenSum = 0;

foreach (int i in array)
{
    if (i % 2 == 0)
    {
        evenSum += i;
    }
    else
    {
        oddSum += i;
    }
}

Console.WriteLine("Tek ededlerin cemi: " + oddSum);
Console.WriteLine("Cut ededlerin cemi: " + evenSum);
