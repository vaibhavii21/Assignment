namespace Met.Loan;

sealed class PersonalLoan : Loan,ITaxable
{

        public override double Rate()
    {

		if(principle<=500000)
			return 5;
		else
			return 6;
	}

	public double Tax()
    {
		return 0.08;
	}
}
	



