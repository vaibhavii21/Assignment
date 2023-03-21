using Met.Banner;
class Program{
	public static double bannerPrice(Banner info,float copies){
		double rate = copies>5 ? 0.8 : 0.7;
		return copies * rate *info.Area();
	}
	public static void Main(string[] args){
		double width = double.Parse(args[0]);
		double height = double.Parse(args[1]);
		float radius = float.Parse(args[2]);
		float copies = float.Parse(args[3]);

		Banner b = new Banner(width,height);
		CurvedBanner cb = new CurvedBanner(width,height,radius);
		
		Console.WriteLine($"Total price for regular banner {bannerPrice(b,copies):0.00}");
		Console.WriteLine($"Total price for special banner {bannerPrice(cb,copies):0.00}");
	}
}



