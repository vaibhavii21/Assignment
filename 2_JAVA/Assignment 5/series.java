package Sequence;
public abstract class series{

	public static Sequence linear(){

		var seql = new LinearSequence();
		return seql;
	}

	public static Sequence power(){
		var seqp = new PowerSequence();
		return seqp;
	}

	private series() {}
}
	
