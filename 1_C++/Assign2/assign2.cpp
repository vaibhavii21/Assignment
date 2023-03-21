#include"assign2.h"
#include<cstdio>

int main()
{
       	int r,p;
 printf("enter the first money:\n");
scanf("%d %d",&r,&p);
money a(r,p);
printf("enter the second money:\n");
scanf("%d %d",&r,&p);
money b(r,p);
money c=a+b;
printf("the total interval is:\n");
c.print();
}
