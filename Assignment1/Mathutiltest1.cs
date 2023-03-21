    class Mathutiltest1
    {
    public static void Main(string[] args)
    {
        int n =int.Parse(args[0]);
        int num =int.Parse(args[1]);
        int num2 =int.Parse(args[2]);
        int first =int.Parse(args[3]);
        int second=int.Parse(args[4]);
        int digit = int.Parse(args[5]);
        int count = int.Parse(args[6]);
        //Mathutiltest2.IsEven(n);
       //Mathutiltest2.CountPrimes(first,second);

       if(Mathutiltest2.IsEven(n)==true){
		       Console.WriteLine($"the number {n} is even");
	       }
	      else
		       Console.WriteLine($"the number {n} is not even"); 


        if(Mathutiltest2.IsOdd(num)==true){
		       Console.WriteLine($"the number {num} is odd");
	       }
	       else
		     Console.WriteLine($"the number {num} is not odd");   


        if(Mathutiltest2.IsPrime(num2)==true){
		    Console.WriteLine($"the number {num2} is prime");
	    }
	    else
		  Console.WriteLine($"the number {num2} is not prime");


        Console.WriteLine($"the total prime numbers between {first} to {second} are { Mathutiltest2.CountPrimes(first,second)}");

        Console.WriteLine("the digit after reverse is {0}",Mathutiltest2.Reverse(digit));

        Console.WriteLine("the total numbers of digit is {0}",Mathutiltest2.DigitCount(count));
    }


 }
