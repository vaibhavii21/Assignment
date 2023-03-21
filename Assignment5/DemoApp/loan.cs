namespace Met.Loan;

public  abstract class Loan
{
	

	public double Emi(double principle,int period)
	{

		double total =0;
		
		total = principle * (1+Rate()*period/100)/(12*period);


		return total;
	}


	public abstract double Rate();
	
	protected double principle;
	protected int period;


}
