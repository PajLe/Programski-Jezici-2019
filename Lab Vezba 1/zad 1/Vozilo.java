import izuzeci.VoziloSeKreceIzuzetak;

public abstract class Vozilo {
	boolean stanje;
	int maxBrzina;
	int trenutnaBrzina;
	int potrosnja; //litara po 100 km
	
	public void ukljuci() {
		stanje = true;
	}
	
	public void iskljuci() throws VoziloSeKreceIzuzetak{
		if(trenutnaBrzina == 0) {
			stanje = false;
		} else {
			throw new VoziloSeKreceIzuzetak("Nemoguce je iskljuciti vozilo koje je u pokretu!");
		}
		
	}
	
	public abstract void ubrzaj();
	public abstract void uspori();
	
}
