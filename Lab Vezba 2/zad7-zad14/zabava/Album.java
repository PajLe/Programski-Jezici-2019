package zabava;

public class Album {
	private int kapacitet;
	private int brojEksponenata;
	private Object[] nizEksponenata;
	
	public Album(int kapacitet) {
		this.kapacitet = kapacitet;
		nizEksponenata = new Object[kapacitet];
		//brojEksponenata = 0;
	}
	
	public void dodajEksponent(Object eksponent) {
		if(brojEksponenata == kapacitet) {	//album je pun
			return;
		}
		
		nizEksponenata [brojEksponenata] = eksponent;
		brojEksponenata++;
	}
	
	public void prikazi() {
		for(int i = 0; i < brojEksponenata; i++) {
			System.out.println(nizEksponenata[i]);
		}
		System.out.println();
	}
	
}
