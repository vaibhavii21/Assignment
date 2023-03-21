package Banner;
public class Banner{

	public Banner (double x,double y){
		width = x;
		height = y;
	}
	public void resize (double x,double y){
		if(x>y){
			width = x;
			height = y;
		}
	}
	void resize(float s){
		resize(s,s);
	}
	public double area(){
		return width * height;
	}
	protected double width;
	protected double height;
}
