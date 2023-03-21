class patient
{
	public:
              
	      patient()
	      {
		      bedtype=100;
		      days=5;
	      }
   
             patient(int bedtype ,int days)
	     {	     
              this->bedtype = bedtype;
              this->days = days;
	     
	    }

	     int getbedtype()
	     {
		     return bedtype;
	     }

	     void setbedtype(int btype)
	     {
		     bedtype=btype;
	     
	    }
	     int getdays()
	     {
		     return days;
	     }

	     void setdays(int d)
	     {
		     days=d;
	     
	    }


	     virtual double get_bill_amount()
	     {
		     double amount=0;
		     if(bedtype==1)
			     amount=days*500;
		     if(bedtype==2)
			     amount=days*300;
		     if(bedtype==3)
			     amount=days*200;
		     return amount;
	     }

	     ~patient()
	     {

	     }

       private:
	     int patientid;
	    char name[20];
	     int bedtype;
	     int days;
};

class InHousePatient : public patient

{
	public:
		InHousePatient(double discount) 
	{
		this->discount = discount;

	}	
		InHousePatient(int bedtype, int days, double discount) : patient(days,bedtype)
		{
		this->discount = discount;
		}

		double get_bill_amount()
		{
			double amount =patient:: get_bill_amount();
		
			if(amount>5000)
			{
			  	return amount - (amount*0.05);
						
		
			}
			else
				return amount - amount *(discount/100);
	
		}
	private:
		double discount;
};
