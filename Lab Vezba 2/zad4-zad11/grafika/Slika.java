package grafika;

public class Slika {
	private int dimenzijaX; //u pikselima
	private int dimenzijaY;
	private Object[][] matricaPiksela;
	
	public Slika(int dimenzijaX, int dimenzijaY) {
		this.dimenzijaX = dimenzijaX;
		this.dimenzijaY = dimenzijaY;
		matricaPiksela = new Object[dimenzijaX][dimenzijaY];
	}
	
	public void postaviPiksel(int koordinataX, int koordinataY, Object sadrzajPiksela) {
		matricaPiksela[koordinataX][koordinataY] = sadrzajPiksela;
	}
	
	//potrebno dodati: exception ako neka od dimenzija nije paran broj ili handle-ovati na neki drugi nacin
	public void kompresuj() {	  
		Object[][] pom = new Object[dimenzijaX/2][dimenzijaY/2];
		
		for(int i = 0; i < dimenzijaX; i+=2) {
			for(int j = 0; j < dimenzijaY; j+=2) {
				pom[i/2][j/2] = matricaPiksela[i][j];
			}
		}
		
		//promena dimenzija za matricaPiksela
		dimenzijaX = pom.length; //pom je niz cija je duzina broj redova u matrici pom 
		dimenzijaY = pom[0].length; //pom[0] je niz cija je duzina broj kolona u matrici pom 
		matricaPiksela = pom;
	}
	
	public void prikazi() {
		for(int i = 0; i < dimenzijaX; i++) {
			for(int j = 0; j < dimenzijaY; j++) {
				System.out.print(matricaPiksela[i][j]);
			}
			System.out.println();
		}
		System.out.println();
	}
	
}
