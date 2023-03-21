using Met.Sequence;

public class Sequencejava5{
	public static double compute(Sequence seq,int count)
	{
		if(seq is IResetable r){
			r.Reset();
		}
		return seq.Sum(count) / count;
	}

	public static void Main(String[] args){
		int n = int.Parse(args[0]);
		Sequence seql = key.Linear();
		Sequence seqp = key.Power();

		Console.WriteLine($"Linear Sequence Average : {compute(seql,n)}");
		Console.WriteLine($"Power Sequence Average : {compute(seqp,n)}");
		Console.WriteLine($"Linear Sequence Average : {compute(seql,n)}");
		Console.WriteLine($"Power Sequence Average : {compute(seqp,n)}");
	}
}
