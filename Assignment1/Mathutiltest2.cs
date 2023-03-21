class Mathutiltest2{
       public static bool IsEven(int number)
       {
	       if(number%2==0)
	       {
		       return true;
	       }
	       else 
		       return false;
       }


     public static bool IsOdd(int number)
     {
	     if(number%2 !=0)
	     {
		     return true;
	     }
	     else
		     return false;
     }


      public static bool IsPrime(int number)
      {

	    if(number==1)
		    return false;
	    if(number==2 || number==3)
		    return true;
	    if((number%2)==0)
		    return false;
	    for(int i=3; i<=Math.Sqrt(number);i+=2)
	    {
		   if((number % i)==0)
			  return false;
	    }
	   return true;
    }


    public static int CountPrimes(int first, int last)
    {
	    int term,count=0;

	    for(term=first;term <= last; ++term)
	    {
		    if(IsPrime(term) == true)

			    count+=1;
	    }
	    return count;
    }

    public static int Reverse(int digit)
    {
	    int rev=0;
	    while (digit!=0){

		    rev =rev*10 + digit % 10;
		    digit/=10;
	    }
	    return rev;
    }

    public static int DigitCount(int num)
    {
	   int a=1;
	   int b=num;
	   int c=0;
	   do{
		   a=a*10;
		   c+=1;

	   }while(a<=b);
	   return c;
}
}