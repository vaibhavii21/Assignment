import Sequence.*;
import java.util.Scanner;

public class Sequencejava5{
	public static double compute(Sequence seq,int count)
	{
		if(seq instanceof Resetable r){
			r.reset();
		}
		return seq.sum(count) / count;
	}

	public static void main(String[] args){
		int n = Integer.parseInt(args[0]);
		Sequence seql = series.linear();
		Sequence seqp = series.power();

		System.out.printf("Linear Sequence Average : %f%n",compute(seql,n));
		System.out.printf("Power Sequence Average : %f%n",compute(seqp,n));
		System.out.printf("Linear Sequence Average : %f%n",compute(seql,n));
		System.out.printf("Power Sequence Average : %f%n",compute(seqp,n));
	}
}
