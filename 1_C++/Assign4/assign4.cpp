#include"assign4.h"
#include<cstdio>

double total_emi(loan& c)
{
	return c.get_EMI() + c.get_EMI()*0.18;
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

 printf("the total EMI of personal loan = %lf\n",a.get_EMI());
 printf("the total EMI of home loan = %f\n",b.get_EMI());

 printf("the total EMI of personal loan with GST = %lf\n",total_emi(a));
 printf("the total EMI of home loan with GST= %f\n",total_emi(b));

}

