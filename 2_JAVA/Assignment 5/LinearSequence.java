package Sequence;
final class LinearSequence extends Sequence{
	private double current;
	private double steps;

	public LinearSequence(){
		current = 2;
		steps =5;
	}

	public double next(){
		double term = current;
                current += steps;
		return term;
	}
}

