import Banner.*;
class Bannerjava4{
	public static double bannerPrice(Banner info,float copies){
		double rate = copies>5 ? 0.8 : 0.7;
		return copies * rate *info.area();
	}
	public static void main(String[] args){
		double width = Double.parseDouble(args[0]);
		double height = Double.parseDouble(args[1]);
		float radius = Float.parseFloat(args[2]);
		float copies = Float.parseFloat(args[3]);

		Banner b = new Banner(width,height);
		CurvedBanner cb = new CurvedBanner(width,height,radius);
		
		System.out.printf("Total price for regular banner %.2f%n",Bannerjava4.bannerPrice(b,copies));
		System.out.printf("Total price for special banner %.2f%n",Bannerjava4.bannerPrice(cb,copies));
	}
}


