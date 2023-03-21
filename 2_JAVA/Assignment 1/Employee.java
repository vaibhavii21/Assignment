class Employee{
	private int eid;
	private int age;
	private double rate;
	private int hours;

	public Employee(int id,int Age,double r,int hrs){
		eid   = id;
		age   = Age;
		rate  = r;
		hours = hrs;
	}

	public void PrintEmployee(){
		System.out.println("Employee is good manner");
	}
	public double GetNetIncome(){
		if(hours<=180){
			return hours*rate;
		}
		else
			return 180*rate + (hours-180)*100;
		
	}

}


