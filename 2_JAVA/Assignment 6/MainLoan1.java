
import Loan.*;

public class MainLoan1{

	public static double finalemi(Loan lm,double p,int n)
	{
		double amt=lm.emi(p,n);
		if(lm instanceof taxable t){
//	        taxable t =(taxable)lm;
		    return amt + t.tax()* amt;
		}
		else if(lm instanceof Discount d){
//	        Discount d =(Discount)lm;
		    return  amt - d.discount()*lm.emi(p,n);
		}
		return 0;
	}


	public static void main(String[] args){
		double p = Double.parseDouble(args[0]);
	       int n = Integer.parseInt(args[1]);
	      Loan hl = Loan1.home();
	      Loan pl = Loan1.personal();

System.out.printf("EMI for Home Loan without discount is: %f%n",hl.emi(p,n)); 
System.out.printf("EMI for Home Loan with discount is: %f%n",finalemi(hl,p,n)); 
System.out.printf("EMI for Personal Loan without tax is: %f%n",pl.emi(p,n));
System.out.printf("EMI for Personal Loan with tax is: %f%n",finalemi(pl,p,n)); 

	}
}
