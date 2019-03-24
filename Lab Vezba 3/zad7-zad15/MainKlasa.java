import geometrija.*;

public class MainKlasa {

	public static void main(String args[]) {
		GeometrijskaSlika a = new KonveksanNtougao();
		GeometrijskaSlika b = new KonveksanNtougao();
		GeometrijskaSlika c = new KonveksanNtougao();
		try{
			a.citajIzTxt("petougao.txt");
			System.out.println(a.obim());
			System.out.println(a.povrsina());
			a.upisiBin("bina.bin");
			
			b.citajIzBin("bina.bin");
			b.prikazNaStandardni();
			
			c.citajSaStandardnog();
			c.upisiTekst("c.txt");
			System.out.println(c.obim());
			System.out.println(c.povrsina());
		} catch(Exception e) {
			System.out.println(e);
		}
		
		
	}
	
}
