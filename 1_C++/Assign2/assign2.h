
#include<cstdio>
#define ifdef TESTING 
class money
{ 
   public:
	   money(int rs,int ps)
	   {
		   rupees=rs+ps/100;
		   paise=ps%100;
                 #ifdef TESTING
		puts("money instance initialize");
                 #endif
	   }
           
	   money(const money& source)
	   {
		   rupees=source.rupees;
		   paise=source.paise;
                   #ifdef TESTING
		   puts("money instance initialize");
                   #endif
	   }

	   void print()
	   {
		printf("%d %d",rupees,paise);
	   }

	   money operator+(const money& rhs)
	   {
		   return money(rupees + rhs.rupees,paise + rhs.paise);

	   }

  private:
	   int rupees;
	   int paise;
};
