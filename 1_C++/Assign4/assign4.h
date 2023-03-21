#include<cstdio>
class loan
{
public:
		loan()
		{

		}
		loan(double principle, float period)
		{
			this->principle = principle;
			this->period = period;
		}

		double get_principle()
		{
			return principle;
		}
		void set_principle(double principle)
		{
			this->principle = principle;
		}
		float get_period()
		{
			return period;
		}
		void set_period(float period)
		{
			this->period = period;
		}

		virtual float get_rate()=0;
		
		float get_EMI()
		{
		   return principle * (1+get_rate()*period/100)/(12*period);
		}
     
protected:
               double principle;
               float period;
};

class personal_loan : public loan
{
public:
      personal_loan():loan()
{

}	

    personal_loan( double principle, float period): loan(principle,period)
{

}
            float get_rate()
          {
		  float rate;
		  if(principle<=500000)
		  { 
			  rate = 15;
		  }
		  else
		  {
			  rate = 16;
		  }
              return rate;
	  }
};
class home_loan : public loan
{
 public:

       home_loan()
		  
{ 
 
}
       home_loan(double principle, float period,double limit): loan(principle,period)
     {
	     this->limit = limit;

     }
         
                 float get_rate()
              {
		      float rate;
		      if(principle<=200000)
		      {
			     rate = 10;
		      }
		      else
		      {
			      rate = 11;
		      }
		      return rate;
	        }


private:
	double limit;

 };


