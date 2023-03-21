namespace Met.Loan;

public class Loan1
{

	public static Loan Personal()
    {
		var pl = new PersonalLoan();
		return pl;
	}

	public static Loan Home()
    {
		var hl = new HomeLoan();
		return hl;
	}
	private Loan1() {}
}
