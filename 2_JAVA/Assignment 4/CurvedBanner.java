package Banner;
public class CurvedBanner extends Banner{
	public CurvedBanner(double x,double y,float r){
		super(x,y);
		radius = r;
	}
	public double area(){
		return super.area() - 0.86 * Math.pow(radius,2);
	}
	private float radius;
}

