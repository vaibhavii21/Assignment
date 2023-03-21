namespace Hospital;

 public class  Patient{

	 private double patientId;
	 private string patientname;
	 private int bedtype;
	 private double days;

	 public Patient(double pid, String name, int btype, double noofdays)
	 {
		 patientId=pid;
		 patientname=name;
		 bedtype=btype;
		 days=noofdays;
	 }

	public double patientid {get;set;}
		
	 
	 public String name{get;set;}
		
	 public int btype {get;set;}
		 
	 public double noofdays {get;set;}
		
	 

	 public int getpriceperday(){
		 int type = bedtype;
		 switch(type)
		 {
			 case 1:
				 return 500;
				 
			 case 2:
			        return 350;

		        case 3:
		               return 200;
		 }
                  
		 return 0;
	 }

	 public virtual double BillingAmount(){
		 double billingamount = days * getpriceperday();
		 return billingamount;
	 }
 }


