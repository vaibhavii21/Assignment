namespace Met.Loan;

public class  Loan1
{

	public static Loan personal(){
		var pl = new PersonalLoan();
		return pl;
	}

	public static Loan home(){
		var hl = new HomeLoan();
		return hl;
	}
	private Loan1() {}
}
