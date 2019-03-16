package grafika;

public class Boja {
	private byte R;
	private byte G;
	private byte B;
	
	public Boja(byte R, byte G, byte B) {
		this.R = R;
		this.G = G;
		this.B = B;
	}
	
	@Override
	public String toString() {
		return "(" + (R & 0xFF) + ", " + (G & 0xFF) + ", " + (B & 0xFF) + ")";
		//objasnjenje za 0xFF na: https://stackoverflow.com/questions/4266756/can-we-make-unsigned-byte-in-java
		//bez toga R,G,B vrednosti mogu biti odstampane kao negativne
	}
}
