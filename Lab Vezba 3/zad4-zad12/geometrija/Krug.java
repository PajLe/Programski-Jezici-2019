package geometrija;

public class Krug {
	protected double poluprecnik;
	
	/*public Krug(double poluprecnik) {
		this.poluprecnik = poluprecnik;
	}*/
	
	public double povrsina() {
		return poluprecnik*poluprecnik*Math.PI;
	}
	
	public double obim() {
		return 2*poluprecnik*Math.PI;
	}
	
}
