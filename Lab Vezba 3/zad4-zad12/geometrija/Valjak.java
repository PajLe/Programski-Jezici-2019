package geometrija;

import java.io.BufferedInputStream;
import java.io.BufferedOutputStream;
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.InputStreamReader;

import izuzeci.NegativnaDimenzijaIzuzetak;

public class Valjak extends Krug implements GeometrijskoTelo{

	private double visina;
	
	/*public Valjak(double poluprecnik, double visina) {
		super(poluprecnik);
		this.visina = visina;
	}
*/
	@Override
	public double zapremina() {
		return super.povrsina()*visina;
	}
	
	@Override
	public double povrsina() {
		return 2*super.povrsina()+super.obim()*visina;
	}

	@Override
	public void upisiTxt(String imeFajla) throws IOException, NegativnaDimenzijaIzuzetak {
		FileWriter f = new FileWriter(imeFajla);
		BufferedWriter b = new BufferedWriter(f);
		
		if(visina <= 0) {
			b.close();
			throw new NegativnaDimenzijaIzuzetak("Valjak nije definisan!");
		}
		
		if(poluprecnik <= 0) {
			b.close();
			throw new NegativnaDimenzijaIzuzetak("Valjak nije definisan!");
		}
		
		b.write(poluprecnik + "");
		b.newLine();
		b.write(visina + "");
		
		b.close();
	}

	@Override
	public void upisiBin(String imeFajla) throws IOException, NegativnaDimenzijaIzuzetak {
		FileOutputStream f = new FileOutputStream(imeFajla);
		BufferedOutputStream b = new BufferedOutputStream(f);
		DataOutputStream d = new DataOutputStream(b);
		
		if(visina <= 0) {
			d.close();
			throw new NegativnaDimenzijaIzuzetak("Valjak nije definisan!");
		}
		
		if(poluprecnik <= 0) {
			d.close();
			throw new NegativnaDimenzijaIzuzetak("Valjak nije definisan!");
		}
		
		d.writeDouble(poluprecnik);
		d.writeDouble(visina);
		
		d.close();
	}

	@Override
	public void ucitajTxt(String imeFajla) throws IOException, NegativnaDimenzijaIzuzetak {
		FileReader f = new FileReader(imeFajla);
		BufferedReader b = new BufferedReader(f);
		
		poluprecnik = Double.parseDouble(b.readLine());
		
		if(poluprecnik <= 0) {
			b.close();
			throw new NegativnaDimenzijaIzuzetak("Poluprecnik mora biti veci od 0");
		}
		
		visina = Double.parseDouble(b.readLine());
		
		if(visina <= 0) {
			b.close();
			throw new NegativnaDimenzijaIzuzetak("Visina mora biti veca od 0");
		}
		
		b.close();
		
	}

	@Override
	public void ucitajBin(String imeFajla) throws IOException, NegativnaDimenzijaIzuzetak {
		FileInputStream f = new FileInputStream(imeFajla);
		BufferedInputStream b = new BufferedInputStream(f);
		DataInputStream d = new DataInputStream(b);
		
		poluprecnik = d.readDouble();
		
		if(poluprecnik <= 0) {
			d.close();
			throw new NegativnaDimenzijaIzuzetak("Poluprecnik mora biti veci od 0");
		}
		
		visina = d.readDouble();
		
		if(visina <= 0) {
			d.close();
			throw new NegativnaDimenzijaIzuzetak("Visina mora biti veca od 0");
		}
		
		d.close();
	}

	@Override
	public void ucitajStd() throws NegativnaDimenzijaIzuzetak, IOException {
		InputStreamReader in = new InputStreamReader(System.in);
		BufferedReader b = new BufferedReader(in);
		
		System.out.println("Unesi poluprecnik baze valjka:");
		poluprecnik = Double.parseDouble(b.readLine());
		
		if(poluprecnik <= 0) {
			b.close();
			throw new NegativnaDimenzijaIzuzetak("Poluprecnik mora biti veci od 0");
		}
		
		System.out.println("Unesi visinu valjka:");
		visina = Double.parseDouble(b.readLine());
		
		if(visina <= 0) {
			b.close();
			throw new NegativnaDimenzijaIzuzetak("Visina mora biti veca od 0");
		}
		
		b.close();
	}

	@Override
	public void prikaziStd() throws NegativnaDimenzijaIzuzetak {

		if(visina <= 0 || poluprecnik <= 0) {
			throw new NegativnaDimenzijaIzuzetak("Valjak nije definisan!");
		}
		
		System.out.println("Poluprecnik baze valjka: " + poluprecnik);
		System.out.println("Visina valjka: " + visina);
	}

}
