
class MathUtiltest2{
	public static void main(String[] args){
	       int num = Integer.parseInt(args[0]);
	       int num1 = Integer.parseInt(args[1]);
	       int num2 = Integer.parseInt(args[2]);
	       int first = Integer.parseInt(args[3]);
	       int second = Integer.parseInt(args[4]);
	       int digit = Integer.parseInt(args[5]);
	       int count = Integer.parseInt(args[6]);
	       if(Mathutiltest1.isEven(num)==true){
		       System.out.printf("the number is even%n");
	       }
	       else
		       System.out.printf("the number is not even%n");
	

       
             if(Mathutiltest1.isOdd(num1)==true){
		    System.out.printf("the number is odd%n");
	     }
            else
	    System.out.printf("the number is not odd%n");


	    if(Mathutiltest1.isPrime(num2)==true){
		    System.out.printf("the number is prime%n");
	    }
	    else
		    System.out.printf("the number is not prime%n");


	    System.out.printf("the total prime numbers are %d%n",Mathutiltest1.countPrimes(first,second));
	    System.out.printf("the digit after reverse is  %d%n",Mathutiltest1.reverse(digit));
	    System.out.printf("the total numbers of digit is %d%n",Mathutiltest1.digitCount(count));
	}
}

