import java.util.Scanner;

public class MainClass {
	
	public static void main(String args[]) {
		Scanner reader = new Scanner(System.in);
		
		System.out.print("Uneti max brzinu: ");
		int maxBrzina = Integer.parseInt(reader.nextLine());
		
		System.out.print("Uneti trenutnu brzinu: ");
		int trenutnaBrzina = Integer.parseInt(reader.nextLine());
		
		System.out.print("Uneti potrosnju: ");
		int potrosnja= Integer.parseInt(reader.nextLine());
		
		reader.close();
		
		Automobil audi = new Automobil(maxBrzina,trenutnaBrzina,potrosnja);
		
		try {
			audi.otvoriVrata();
		} catch (Exception e) {
			System.out.println(e);
		}
		
		audi.zatvoriVrata();
		audi.ukljuci();
		audi.ubrzaj();
		audi.ubrzaj();
		audi.ubrzaj();
		audi.ubrzaj();
		audi.ubrzaj();
		
		try {
			audi.iskljuci();
		} catch (Exception e) {
			System.out.println(e);
		}
		
		try {
			audi.otvoriVrata();
		} catch (Exception e) {
			System.out.println(e);
		}
		
		audi.uspori();
		audi.uspori();
		
		try {
			audi.iskljuci();
		} catch (Exception e) {
			System.out.println(e);
		}
	}
	
}
