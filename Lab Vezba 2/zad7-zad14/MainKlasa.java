import zabava.*;

public class MainKlasa {
	
	public static void main(String args[]) {
		Album albumMaraka = new Album(3);
		Marka a = new Marka("Queen Victoria", "Malta",(short) 1860);
		Marka b = new Marka("Governatorato del Montenegro Valore in Lire", "Montenegro",(short) 1942);
		Marka c = new Marka("Coat of Arms", "Serbia",(short) 1866);
		
		albumMaraka.dodajEksponent(a);
		albumMaraka.dodajEksponent(b);
		albumMaraka.dodajEksponent(c);
		
		Album albumSlika = new Album(3);
		Slika d = new Slika((byte)20,(byte)7,(short)1969,"Moon");
		Slika e = new Slika((byte)14,(byte)8,(short)1945,"Times Square, NYC");
		Slika f = new Slika((byte)2,(byte)3,(short)2014,"Los Angeles, Dolby Theatre");
		
		albumSlika.dodajEksponent(d);
		albumSlika.dodajEksponent(e);
		albumSlika.dodajEksponent(f);
		
		System.out.println("Album slika:");
		albumSlika.prikazi();
		System.out.println("Album maraka:");
		albumMaraka.prikazi();
	}
	
}
