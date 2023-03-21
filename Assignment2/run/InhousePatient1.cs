namespace Hospital;
public class  InhousePatient1 : Patient
{
	public double discount {get;set;}
	
	public InhousePatient1 (double pid, String name, int btype, double noofdays,double discount): base (pid,  name,  btype,  noofdays){
	this.discount = discount;
	 }
	public  override  double BillingAmount()
	{
		double amount = base.BillingAmount();
		return amount<5000 ? (amount*0.95) : (amount - amount*(discount/100));
	}
	
}
