import Hospital.*;

class Hospitaltest {
	public static void main(String[] args) {
		
	double a= Double.parseDouble(args[0]);
        String b= (args[1]);
        int c= Integer.parseInt(args[2]);
        double e= Double.parseDouble(args[3]);
        double d= Double.parseDouble(args[4]);
       
        Patient1 p = new Patient1(a,b,c,e);
        InhousePatient1 ip = new InhousePatient1(a,b,c,e,d);
        System.out.printf("hospital bill is= %f%n",p.getbillingamount());
        System.out.printf("hospital inhouse bill is=%f%n",ip.getbillingamount());
	}
}

