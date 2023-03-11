// задача 1
//using System;
//class RecExercise1
//{
  //  static int printNatural(int ctr,int stval)
   // {
//	if (ctr < 1)
//	{
//	    return stval;
//	}
//	Console.Write(" {0} ",ctr);
//		ctr--;
//	return printNatural(ctr,stval);
  //  }
    
   // static void Main()
   // {
//	Console.Write("\n\n Recursion : Выведите натуральные числа от n до 1 :\n");
//	Console.Write("--------------------------------------------------------\n");
//	Console.Write(" Сколько цифр нужно напечатать : ");
//	int ctr= Convert.ToInt32(Console.ReadLine());
		
	//printNatural(ctr,1);
	//Console.Write("\n\n");
   // }
//}



// задача 2
//using System;
//namespace Task2
//{
  //  class Test
   // {
     //   static int SumNumbers(int M, int N)
       // {
         //   if (M == 0) return (N * (N + 1)) / 2;            
           // else if (N == 0) return (M * (M + 1)) / 2;       
           // else if (M == N) return M;                       
            //else if (M < N) return N + SumNumbers(M, N - 1); 
            //else return N + SumNumbers(M, N + 1);            
       // }
       // static void Main(string[] args)
       // {
         //   Console.Write("M = ");
          //  int M = int.Parse(Console.ReadLine());
          //  Console.Write("N = ");
          //  int N = int.Parse(Console.ReadLine());
          //  Console.WriteLine($"Result, S = {SumNumbers(M, N)}");
          //  Console.ReadLine();
        //}
   // }
//}



//    задача 3

//Console.Write("Введите число M: ");
//int m = Convert.ToInt32(Console.ReadLine());

//Console.Write("Введите число N: ");
//int n = Convert.ToInt32(Console.ReadLine());

//AkkermanFunction(m,n);



//void AkkermanFunction(int m, int n)
//{
  //  Console.Write(Akkerman(m, n)); 
//}


//int Akkerman(int m, int n)
//{
  //  if (m == 0)
   // {
     //   return n + 1;
   // }
   // else if (n == 0 && m > 0)
    //{
      //  return Akkerman(m - 1, 1);
   // }
   // else
   // {
     //   return (Akkerman(m - 1, Akkerman(m, n - 1)));
   // }
//}