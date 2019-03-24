package geometrija;

import java.io.IOException;

import izuzeci.NegativnaDimenzijaIzuzetak;

public interface GeometrijskaSlika {
	public double obim() throws NegativnaDimenzijaIzuzetak;
	public double povrsina() throws NegativnaDimenzijaIzuzetak;
	// provera za obim i povrsinu : https://rechneronline.de/pi/simple-polygon.php
	
	public void upisiBin(String imeFajla) 
			throws IOException, NegativnaDimenzijaIzuzetak;
	public void upisiTekst(String imeFajla) 
			throws IOException, NegativnaDimenzijaIzuzetak;
	public void citajIzBin(String imeFajla) 
			throws IOException, NegativnaDimenzijaIzuzetak;
	public void citajIzTxt(String imeFajla)	//u fajlu su koordinate temena konveksnog n-tougla
			throws IOException, NegativnaDimenzijaIzuzetak;
	public void citajSaStandardnog() throws IOException, NegativnaDimenzijaIzuzetak;
	public void prikazNaStandardni() throws NegativnaDimenzijaIzuzetak;
	
}
