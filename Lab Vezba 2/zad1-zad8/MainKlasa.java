import java.util.Random;

import matematika.*;

public class MainKlasa {
	
	public static void main(String args[]) {
		Random r = new Random();
		
		Matrica a = new Matrica(3,2); //3, 2 hardcoded 
		for(int i = 0; i < 3; i++) {
			for(int j = 0; j < 2; j++) {
				//random int vrednost u granicama [0, 10]
				a.postaviElement(i, j, (int)(r.nextDouble()*10));
			}
		}
		
		Matrica c = new Matrica (3,3); //3, 3 hardcoded 
		for(int i = 0; i < 3; i++) {
			for(int j = 0; j < 3; j++) {
				//random double vrednost u granicama [-5, 5] za real i za imag
				c.postaviElement(i, j, new KompleksniBroj(r.nextDouble()*10 - 5,r.nextDouble()*10 - 5));
			}
		}
		
		System.out.println("Matrica a:");
		a.prikazi();
		a.transponuj();
		System.out.println("Transponovana matrica a:");
		a.prikazi();
		
		System.out.println("Matrica c:");
		c.prikazi();
		c.transponuj();
		System.out.println("Transponovana matrica c:");
		c.prikazi();
	}
	
}
