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

public class KonveksanNtougao implements GeometrijskaSlika{

	private int brojTemena;
	private double[][] vektorKoordinata;
	
	private double distance(double x0, double y0, double x1, double y1) {
		return Math.sqrt((x1-x0)*(x1-x0)+(y1-y0)*(y1-y0));
	}
	
	@Override
	public double obim() throws NegativnaDimenzijaIzuzetak {
		if (brojTemena == 0) {
			throw new NegativnaDimenzijaIzuzetak("N-tougao nije definisan!");
		}
		
		double obim = 0;
		for(int i = 1; i < brojTemena+1; i++) {
			obim += distance(vektorKoordinata[i-1][0], vektorKoordinata[i-1][1],
				vektorKoordinata[i%brojTemena][0],vektorKoordinata[i%brojTemena][1]);
		}
		return obim;
	}

	@Override
	public double povrsina() throws NegativnaDimenzijaIzuzetak{
		if (brojTemena == 0) {
			throw new NegativnaDimenzijaIzuzetak("N-tougao nije definisan!");
		}
		
		double povrsina = 0;
		for (int i = 0; i < brojTemena; i++) {//[][0] <=> x ; [][1] <=> y koordinata
			povrsina += (vektorKoordinata[i][0]*vektorKoordinata[(i+1)%brojTemena][1] - 
					vektorKoordinata[(i+1)%brojTemena][0]*vektorKoordinata[i][1]);
			// https://en.wikipedia.org/wiki/Polygon#Area
			
		}
		return Math.abs(povrsina)/2;
	}

	@Override
	public void upisiBin(String imeFajla) throws IOException, NegativnaDimenzijaIzuzetak{
		if (brojTemena == 0) {
			throw new NegativnaDimenzijaIzuzetak("N-tougao nije definisan!");
		}
		
		FileOutputStream f = new FileOutputStream(imeFajla);
		BufferedOutputStream b = new BufferedOutputStream(f);
		DataOutputStream d = new DataOutputStream(b);
		
		d.writeInt(brojTemena);
		
		for(int i = 0; i < brojTemena; i++) {
			for(int j = 0; j < 2; j++) {
				d.writeDouble(vektorKoordinata[i][j]);
			}
		}
		
		d.close();
	}

	@Override
	public void upisiTekst(String imeFajla) throws IOException, NegativnaDimenzijaIzuzetak{
		FileWriter f = new FileWriter(imeFajla);
		BufferedWriter b = new BufferedWriter(f);
		
		if (brojTemena == 0) {
			b.close();
			throw new NegativnaDimenzijaIzuzetak("N-tougao nije definisan!");
		}
		
		b.write(brojTemena + "");
		b.newLine();
		for(int i = 0; i < brojTemena; i++) {
			for(int j = 0; j < 2; j++) {
				b.write(vektorKoordinata[i][j] + "");
				b.newLine();
			}
		}
		
		b.close();
	}

	@Override
	public void citajIzBin(String imeFajla) throws IOException, NegativnaDimenzijaIzuzetak{
		FileInputStream f = new FileInputStream(imeFajla);
		BufferedInputStream b = new BufferedInputStream(f);
		DataInputStream d = new DataInputStream(b);
		
		brojTemena = d.readInt();
		
		if(brojTemena <3) { //<3_^
			d.close();
			throw new NegativnaDimenzijaIzuzetak("N-tougao mora imati bar 3 temena.");
		}
		
		vektorKoordinata = new double[brojTemena][2]; //2 za koordinate x, y
		
		for(int i = 0; i < brojTemena; i++) {
			for(int j = 0; j < 2; j++) {
				vektorKoordinata[i][j] = d.readDouble();
			}
		}
		
		d.close();
	}

	@Override
	public void citajIzTxt(String imeFajla) throws IOException, NegativnaDimenzijaIzuzetak{
		FileReader f = new FileReader(imeFajla);
		BufferedReader b = new BufferedReader(f);
		
		brojTemena = Integer.parseInt(b.readLine());
		
		if(brojTemena <3) { //<3_^
			b.close();
			throw new NegativnaDimenzijaIzuzetak("N-tougao mora imati bar 3 temena.");
		}
		
		vektorKoordinata = new double[brojTemena][2]; //2 za koordinate x, y
		
		for(int i = 0; i < brojTemena; i ++) {
			for(int j = 0; j < 2; j++) {
				vektorKoordinata[i][j] = Double.parseDouble(b.readLine());;
			}	
		}
		
		b.close();
	}

	@Override
	public void citajSaStandardnog() throws IOException, NegativnaDimenzijaIzuzetak {
		InputStreamReader in = new InputStreamReader(System.in);
		BufferedReader b = new BufferedReader(in);
		
		brojTemena = Integer.parseInt(b.readLine());
		
		if(brojTemena <3) {
			b.close();
			throw new NegativnaDimenzijaIzuzetak("N-tougao mora imati bar 3 temena.");
		}
		
		vektorKoordinata = new double[brojTemena][2]; //2 za koordinate x, y
		
		for(int i = 0; i < brojTemena; i++) {
			for(int j = 0; j < 2; j++) {
				vektorKoordinata[i][j] = Double.parseDouble(b.readLine()); //pretpostavimo da korisnik nije zao i da unosi validne koordinate tako da n-tougao bude konveksan
				//primer: 3 0 0 0 1 1 0 
			}
		}
		
		b.close();
	}

	@Override
	public void prikazNaStandardni() throws NegativnaDimenzijaIzuzetak {
		if (brojTemena == 0) {
			throw new NegativnaDimenzijaIzuzetak("N-tougao nije definisan!");
		}
		
		System.out.print("Broj temena: ");
		System.out.println(brojTemena);
		for(int i = 0; i < brojTemena; i++) {
			for(int j = 0; j < 2; j++) {
				System.out.print(vektorKoordinata[i][j] + " ");
			}
			System.out.println();
		}
	}

}
