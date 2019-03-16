import grafika.*;
import java.util.Random;

public class MainKlasa {

	public static void main(String args[]) {
		Random r = new Random();
		for(int i = 0; i < 333; i++) {
			System.out.println(r.nextInt(500));
		}
		Slika crnoBelaSlika = new Slika(4,6); //hardcoded 4, 6
		for(int i = 0; i < 4; i++) {
			for(int j = 0; j < 6; j++) {
				crnoBelaSlika.postaviPiksel(i, j, r.nextInt(2));
			}
		}

		Slika slikaUBoji = new Slika(4,2); //hardcoded 4, 2
		for(int i = 0; i < 4; i++) {
			for(int j = 0; j < 2; j++) {
				slikaUBoji.postaviPiksel(i, j, new Boja(
						(byte)(r.nextInt(256)),
						(byte)(r.nextInt(256)),
						(byte)(r.nextInt(256)))
						);
			}
		}
		
		System.out.println("Crno bela slika:");
		crnoBelaSlika.prikazi();
		System.out.println("Crno bela slika kompresovana:");
		crnoBelaSlika.kompresuj();
		crnoBelaSlika.prikazi();
		
		System.out.println("Slika u boji:");
		slikaUBoji.prikazi();
		System.out.println("Slika u boji kompresovana:");
		slikaUBoji.kompresuj();
		slikaUBoji.prikazi();
	}
}
