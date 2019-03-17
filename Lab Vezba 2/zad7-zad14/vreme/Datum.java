//format: Dan.Mesec.Godina.

package vreme;

public class Datum {
	private byte dan;
	private byte mesec;
	private short godina;
	
	//potrebno dodati: neka provera da li su podaci validni
	public Datum(byte dan, byte mesec, short godina) {
		this.dan = dan;
		this.mesec = mesec;
		this.godina = godina;
	}
	
	@Override
	public String toString() {
		return dan + "." + mesec + "." + godina + ".";
	}
}
