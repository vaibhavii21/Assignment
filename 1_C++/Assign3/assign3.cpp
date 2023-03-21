#include"assign3.h"
#include<cstdio>
#include<iostream>

double getfinalexpenses(patient &a)
{
	double amount = a.get_bill_amount();
	amount=amount*1.18;
	return amount;
}


int main()
{
	int patientid;
	//char patient_name;
	int bedtype;
	int days;
	double discount;

	printf("enter the patientid/name/bedtype/day\n");
	scanf("%d %d %d",&patientid,&bedtype,&days);
	printf(" enter the discount amount=\n");
	scanf("%lf",&discount);

	patient a(bedtype,days);
	printf("the total bill amount is %lf\nand amount with gst is %lf\n",a.get_bill_amount(),getfinalexpenses(a));

	InHousePatient b(days,bedtype,discount);

	printf("the total bill amount of staff members is %lf\nand amount with gst is %lf\n",b.get_bill_amount(),getfinalexpenses(b));
}


