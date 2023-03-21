namespace Met.Loan;

sealed class HomeLoan :Loan,IDiscount
{

	public override double Rate()
    {

		
		if(principle<=2000000)
		
			return 10;
		else
			return 11;
		
	}
	
	public double Discount()
    {
		return 0.10;

	}



}

