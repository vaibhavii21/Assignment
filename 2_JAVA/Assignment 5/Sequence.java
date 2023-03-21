package Sequence;

public abstract class Sequence{

	public double sum(int count){
		double Total = 0;
		for(int i=1; i<=count;++i){
			Total+=next();
		}
		return Total;
	}
	public abstract double next();
}

