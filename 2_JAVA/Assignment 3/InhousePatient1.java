package Hospital;
public class InhousePatient1 extends Patient{
	public InhousePatient1(double pid,String name,int btype,double days,double disc){
		super(pid,name,btype,days);
		discount = disc;
	}
	public double getdiscount (){
		return discount;
	}
	public void setdiscount (double disc){
		discount = disc;
	}
	public double getbillingamount(){
		double amount = super.getbillingamount();
		return amount<5000 ? (amount*0.95) : (amount - amount*(discount/100));
	}
	private double discount;
}
