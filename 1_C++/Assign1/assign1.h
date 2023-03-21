#include<cmath>
class investment
{
	public:
		double amount;
		int period;

	investment()
	{
		amount=10000;
		period=3;
	}

	investment(double amount,int period)
	{
		this->amount=amount;
		this->period=period;
	}

	double get_amount()
	{
		return amount;
	}
	void set_amount(double AMT)
	{
		amount=AMT;
	}

	double get_period()
	{
		return period;
	}

	void set_period(double pp)
	{
		period=pp;
	}

	double Interest_rate()
	{
		double rate=0;
		
		if(amount<10000)
		{
			rate=8.0;
		}
		if((amount>=10000 && amount<50000))
		{
			rate=9.0;
		}
		if(amount>=50000)
		{ 
		    rate=10.0;
		}
		if(period>5)
		{
			rate+=1;
		}
		return rate;
	}

	double get_interest(bool type)
	{
		double interest=0;
		double amt=0;
		double rate=Interest_rate();
		
		if(type)
		{
		interest=(amount*period*rate)/100;
		}
		else
		{
			amt=amount*pow((1+rate/100),period);
			interest= amt-amount;
		
		}
                return interest;
	}


	~investment()
	{

	}
};
