import matematika.*;

public class MainKlasa {
	
	public static void main(String args[]) {
		KvadratnaMatrica a = new PunaMatrica();
		KvadratnaMatrica b =  new PunaMatrica();
		
		try {
			a.ucitajSaStandardnog();
			a.writeInBin("abin.bin");
			System.out.println("Matrica a:");
			a.prikaziNaStandardni();
			
			b.ucitajIzBin("abin.bin");
			System.out.println("Matrica b:");
			b.prikaziNaStandardni();
		}catch(Exception e) {
			System.out.println(e);
		}
	}
	
}
