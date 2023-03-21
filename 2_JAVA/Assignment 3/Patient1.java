package Hospital;

 public class Patient1{

	 private double patientId;
	 private String patientname;
	 private int bedtype;
	 private double days;

	 public Patient1(double pid, String name, int btype, double noofdays)
	 {
		 patientId=pid;
		 patientname=name;
		 bedtype=btype;
		 days=noofdays;
	 }

	 public double getpatientId(){
		 return patientId;
	 }
	 public String getpatientname(){
		 return patientname;
	 }
	 public int getbedtype(){
		 return bedtype;
	 }
	 public double getdays(){
		return days ;
	 }
         public void setpatientId(double pid){
		 patientId=pid;
	 }
	 public void setpatientname(String name){
		 patientname=name;
	 }
	 public void setbedtype(int btype){
		 bedtype=btype;
	 }
	 public void setdays(double noofdays){
		 days=noofdays;
	 
	 }

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

	 public double getbillingamount(){
		 double billingamount = days * getpriceperday();
		 return billingamount;
	 }
 }


