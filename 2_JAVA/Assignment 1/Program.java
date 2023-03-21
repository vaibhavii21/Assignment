class Program{
   
     public static void main(String[] args) {
     int eid = Integer.parseInt(args[0]);
     int age = Integer.parseInt(args[1]);
     double rate = Double.parseDouble(args[2]);
     int hours = Integer.parseInt(args[3]);

    Employee emp = new Employee(eid,age,rate,hours);
    emp.PrintEmployee();
    System.out.printf("total GetNetIncome: %.2f%n",emp.GetNetIncome());
   
     }
}
