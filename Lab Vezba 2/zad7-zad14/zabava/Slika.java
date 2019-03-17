package zabava;
import vreme.Datum;

public class Slika {
	private Datum datum;
	private String mestoSlikanja;
	
	public Slika(byte dan, byte mesec, short godina, String mestoSlikanja) {
		datum = new Datum(dan,mesec,godina);
		this.mestoSlikanja = mestoSlikanja;
	}
	
	@Override
	public String toString() {
		return mestoSlikanja + ", " + datum;
	}
}
