package Loan;

final class HomeLoan extends Loan implements Discount{

	@Override
	public double rate(){

		
		if(principle<=2000000)
		
			return 10;
		else
			return 11;
		
	}
	
       @Override
	public double discount(){
		return 0.10;

	}



}

