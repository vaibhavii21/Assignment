package Loan;

public abstract class Loan{
	

	public double emi(double principle,int period){

     

		double total =0;
		
		total = principle * (1+rate()*period/100)/(12*period);


		return total;
	}


	public abstract double rate();
	
	protected double principle;
	protected int period;


}
