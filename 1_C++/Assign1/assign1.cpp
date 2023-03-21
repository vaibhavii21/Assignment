#include"assign1.h"
#include<cstdio>

int main()
{
	double amount;
	int period;
	int itype=0;
	double interest=0;

	printf("enter the principle amount and period\n");
       scanf("%lf %d",&amount,&period);

       printf("enter type of interest 0 for simple interest / 1 for compound interest\n");
      scanf("%d",&itype);


      investment r(amount,period);

       if (itype==1)
	       itype=false;
       else
	       itype=true;

       printf("calculated interest amount is:%lf\n",r.get_interest(itype));

}
