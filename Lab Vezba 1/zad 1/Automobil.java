import izuzeci.VoziloSeKreceIzuzetak;

public class Automobil extends Vozilo{
	boolean stanjeVrata;
	
	public Automobil(int maxBrzina, int trenutnaBrzina, int potrosnja) {
		stanjeVrata = false;
		stanje = false;
		this.maxBrzina = maxBrzina;
		this.trenutnaBrzina = trenutnaBrzina;
		this.potrosnja = potrosnja;
	}
	
	public void otvoriVrata() throws VoziloSeKreceIzuzetak{
		if(trenutnaBrzina == 0) {
			stanjeVrata = true;
		} else {
			throw new VoziloSeKreceIzuzetak("Nemoguce je otvoriti vrata dok je vozilo u pokretu!");
		}
		
	}
	
	public void zatvoriVrata() {
		stanjeVrata = false;
	}
	
	@Override
	public void ubrzaj() {
		trenutnaBrzina += 10;
		if(trenutnaBrzina > maxBrzina) {
			trenutnaBrzina = maxBrzina;
		}
	}

	@Override
	public void uspori() {
		trenutnaBrzina -= 30;
		if(trenutnaBrzina < 0) {
			trenutnaBrzina = 0;
		}
	}

}
