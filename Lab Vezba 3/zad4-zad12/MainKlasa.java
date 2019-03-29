import geometrija.*;


public class MainKlasa {

	public static void main(String args[]) {
		GeometrijskoTelo a = new Valjak();
		GeometrijskoTelo b = new Valjak();
		GeometrijskoTelo c = new Valjak();
		
		try {
			a.ucitajStd();
			a.upisiBin("abin.bin");
			
			b.ucitajBin("abin.bin");
			b.upisiTxt("btxt.txt");
			
			c.ucitajTxt("btxt.txt");
			c.prikaziStd();
			
			System.out.println("C povrsina: " + c.povrsina());
			System.out.println("C zapremina: " + c.zapremina());
		}catch(Exception e) {
			System.out.println(e);
		}
	}
	
}
