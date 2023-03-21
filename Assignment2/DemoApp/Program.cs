using Hospital;

class Hospitaltest {
	public static void Main(string[] args)
        {
		
	double a= double.Parse(args[0]);
        string b= (args[1]);
        int c= int.Parse(args[2]);
        double e= double.Parse(args[3]);
        double d= double.Parse(args[4]);
       
        Patient p = new Patient(a,b,c,e);
        InhousePatient1 ip = new InhousePatient1(a,b,c,e,d);

        Console.WriteLine("Patient id is {0}",a);
        Console.WriteLine("Patient name is {0}",b);
        Console.WriteLine("Patient bed type is {0}",c);
        Console.WriteLine("No of days is {0}",e);
        Console.WriteLine("discount for inhousepatient is {0}",d);

        Console.WriteLine("hospital bill is {0:0.00}",p.BillingAmount());
        Console.WriteLine("hospital inhouse bill is {0:0.00}",ip.BillingAmount());
	}
}
