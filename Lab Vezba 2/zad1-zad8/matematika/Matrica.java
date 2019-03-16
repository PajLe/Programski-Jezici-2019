package matematika;

public class Matrica {
	private int n;	//broj redova
	private int m;	//broj kolona
	private Object[][] elementi;
	
	public Matrica() {
		this(0,0);
		elementi = null;
	}
	
	public Matrica(int brojRedova, int brojKolona) {
		this.n = brojRedova;
		this.m = brojKolona;
		elementi = new Object[n][m];
	}
	
	public void postaviElement(int koordinataReda, int koordinataKolone, Object element) {
		elementi[koordinataReda][koordinataKolone] = element;	
	}
	
	public void transponuj() {
		Object[][] pom = new Object[m][n];
		for(int i = 0; i < n; i++) {
			for(int j = 0; j < m; j++) {
				pom[j][i] = elementi[i][j];
			}
		}
		
		//zamena mesta clanovima 'm' i 'n'
		m += n;
		n = m - n;
		m -= n;
		
		elementi = pom;
	}
	
	public void prikazi() {
		for(int i = 0; i < n; i++) {
			for(int j = 0; j < m; j++) {
				System.out.print(elementi[i][j] + " ");
			}
			System.out.println();
		}
		System.out.println();
	}
}	
