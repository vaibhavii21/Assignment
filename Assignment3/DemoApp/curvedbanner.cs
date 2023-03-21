namespace Met.Banner;
public class CurvedBanner :Banner
{
	public CurvedBanner(double x,double y,float r) : base(x,y)
    {
	
		radius = r;
	}
	public override double Area()
    {
		return base.Area() - 0.86 * Math.Pow(radius,2);
	}
	private float radius;
}

