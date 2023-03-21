#include"assign5.h"
#include<cstdio>

double total_emi(loan& c)
{
	return c.get_EMI() + c.get_EMI()*0.18;
}     

double totaltax(loan* l)
{
	auto tx = dynamic_cast<taxable*>(l);
	if(tx)
		tx->tax();
	return l->get_EMI()+l->get_EMI()*tx->tax();
}


double totaldis(loan* l)
{
	auto dx = dynamic_cast<discount*>(l);
	if(dx)
		dx->dis();
	return l->get_EMI()-l->get_EMI()*dx->dis();
}

int main(void)
{
 double principle;
 float period;
 double limit =2500000;

 printf("enter the principle amount\n");
 scanf("%lf %f",&principle,&period);

 personal_loan a(principle,period);
 home_loan b(principle,period,limit);


 printf("the total EMI of personal loan = %lf\n\n",a.get_EMI());

 printf("the total EMI of personal loan with GST = %lf\n\n",total_emi(a));

 printf("the total EMI of personal loan with tax = %lf\n\n\n\n\n",totaltax(&a));

 printf("the total EMI of home loan = %f\n\n",b.get_EMI());

 printf("the total EMI of home loan with GST= %f\n\n",total_emi(b));

 printf("the total EMI of home loan with discount = %lf\n\n\n\n\n",totaldis(&b));

}

