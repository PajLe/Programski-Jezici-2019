package geometrija;

import java.io.IOException;

import izuzeci.NegativnaDimenzijaIzuzetak;

public interface GeometrijskoTelo {
	public double povrsina();
	public double zapremina();
	public void upisiTxt(String imeFajla)throws IOException, NegativnaDimenzijaIzuzetak;
	public void upisiBin(String imeFajla)throws IOException, NegativnaDimenzijaIzuzetak;
	public void ucitajTxt(String imeFajla)throws IOException, NegativnaDimenzijaIzuzetak;
	public void ucitajBin(String imeFajla)throws IOException, NegativnaDimenzijaIzuzetak;
	public void ucitajStd()throws NegativnaDimenzijaIzuzetak, IOException;
	public void prikaziStd()throws NegativnaDimenzijaIzuzetak;
}
