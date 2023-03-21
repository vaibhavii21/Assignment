using Met.Loan;

public class MainLoan1
{

	public static double finalemi(Loan lm,double p,int n)
	{
		double amt=lm.Emi(p,n);
		if(lm is ITaxable t){
//	        taxable t =(taxable)lm;
		    return amt + t.Tax()* amt;
		}
		else if(lm is IDiscount d){
//	        Discount d =(Discount)lm;
		    return  amt - d.Discount()*lm.Emi(p,n);
		}
		return 0;
	}


	public static void Main(string[] args)
    {
		double p = double.Parse(args[0]);
	       int n = int.Parse(args[1]);
	      Loan hl = Loan1.Home();
	      Loan pl = Loan1.Personal();

Console.WriteLine($"EMI for Home Loan without discount is: {hl.Emi(p,n)}"); 
Console.WriteLine($"EMI for Home Loan with discount is:{finalemi(hl,p,n)}"); 
Console.WriteLine($"EMI for Personal Loan without tax is:{pl.Emi(p,n)}");
Console.WriteLine($"EMI for Personal Loan with tax is:{finalemi(pl,p,n)}"); 

	}
}
