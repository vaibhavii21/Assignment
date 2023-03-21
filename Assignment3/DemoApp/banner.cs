namespace Met.Banner;
public class Banner
{

	public Banner (double x,double y)
    {
		width = x;
		height = y;
	}

	public virtual double Area()
	{
		return width * height;
	}
	protected double width;
	protected double height;
}
