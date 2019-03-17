package zabava;

public class Marka {
	private String imeMarke;
	private String zemljaStampanja;
	private short godinaStampanja;
	
	public Marka(String imeMarke, String zemljaStampanja, short godinaStampanja) {
		this.imeMarke = imeMarke;
		this.zemljaStampanja = zemljaStampanja;
		this.godinaStampanja = godinaStampanja;
	}
	
	@Override
	public String toString() {
		return imeMarke + ", " + zemljaStampanja + " " + godinaStampanja;
	}
}
