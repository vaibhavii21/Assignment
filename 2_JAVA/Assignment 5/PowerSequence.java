
package Sequence;
final class PowerSequence extends Sequence implements Resetable{
	private double ratio;
	private double current;

	public PowerSequence(){
		ratio = 3;
		current =1;
	}

	public double next(){
		double term = current;
                current += ratio;
		return term;
	}
	public void reset(){
		current = 1;
	}
}

