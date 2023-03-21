package Loan;

final class PersonalLoan extends Loan implements taxable{

	
	@Override
         public	double rate(){

		if(principle<=500000)
			return 5;
		else
			return 6;
	}
	@Override
	public double tax(){
		return 0.08;
	}
}
	



