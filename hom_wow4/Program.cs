using System;
    public class Exercise
    {
        public static void Main()
        {
    int n;
	Console.Write("\n\n Recursion : Print even or odd numbers in a given range :\n");
	Console.Write("-------------------------------------------------------------\n");	
     
    Console.Write(" Input the range to print starting from 1 : ");
    n = Convert.ToInt32(Console.ReadLine());
     
    Console.WriteLine("\n All even numbers from 1 to {0} are : ", n);
    EvenAndOdd(2, n);//call the function EvenAndOdd for even numbers 
     
    Console.WriteLine("\n\n All odd numbers from 1 to {0} are : ", n);
    EvenAndOdd(1, n);// call the function EvenAndOdd for odd numbers
    Console.WriteLine("\n\n");
     
    return ;
}
static void EvenAndOdd(int stVal, int n)
{
    if(stVal > n)
        return ;
    Console.Write(" {0}  ", stVal);
    EvenAndOdd(stVal+2, n);//calling the function EvenAndOdd itself recursively
}
}
