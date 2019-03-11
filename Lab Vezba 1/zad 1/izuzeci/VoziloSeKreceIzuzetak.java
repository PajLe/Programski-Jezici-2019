package izuzeci;

public class VoziloSeKreceIzuzetak extends Exception{
	
	/**
	 * 
	 */
	private static final long serialVersionUID = -8021370170072473459L;

	public VoziloSeKreceIzuzetak() {
		super("Vozilo je u pokretu!");
	}
	
	public VoziloSeKreceIzuzetak(String porukaGreske) {
		super(porukaGreske);
	}
	
}
