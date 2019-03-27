package matematika;
import java.io.IOException;

import izuzeci.*;

public interface KvadratnaMatrica {
	public double determinanta();
	public void prikaziNaStandardni()throws NegativnaDimenzijaIzuzetak;
	public void ucitajSaStandardnog()throws NegativnaDimenzijaIzuzetak, NumberFormatException, IOException;
	public void ucitajIzBin(String imeFajla)throws NegativnaDimenzijaIzuzetak, IOException;
	public void writeInBin(String imeFajla)throws NegativnaDimenzijaIzuzetak, IOException;
}
