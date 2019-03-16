package matematika;

public class KompleksniBroj {
	private double imag;
	private double real;
	
	public KompleksniBroj(double imag, double real) {
		this.real = real;
		this.imag = imag;
	}
	
	@Override
	public String toString() {
		if(imag > 0) {
			return "(" + String.format("%.2f", real) + " + j*" + String.format("%.2f", imag) + ")"; 
		}
		return "(" + String.format("%.2f", real) + " - j*" + String.format("%.2f",Math.abs(imag)) + ")"; 
	}
}
