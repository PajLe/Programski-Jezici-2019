package izuzeci;

public class NegativnaDimenzijaIzuzetak extends Exception{
	
	/**
	 * 
	 */
	private static final long serialVersionUID = 6024070375754171360L;

	public NegativnaDimenzijaIzuzetak() {
		super("Nemoguce je imati negativnu dimenziju!");
	}
	
	public NegativnaDimenzijaIzuzetak(String poruka) {
		super(poruka);
	}
}
