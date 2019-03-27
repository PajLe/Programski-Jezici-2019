package matematika;

import java.io.BufferedInputStream;
import java.io.BufferedOutputStream;
import java.io.BufferedReader;
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStreamReader;

import izuzeci.NegativnaDimenzijaIzuzetak;

public class PunaMatrica implements KvadratnaMatrica{

	private int dimenzije;
	private double[][] elementi;
	
	@Override
	public double determinanta() {
		return matrixDeterminant(elementi);
	}

	@Override
	public void prikaziNaStandardni() throws NegativnaDimenzijaIzuzetak{
		if(dimenzije < 1) {
			throw new NegativnaDimenzijaIzuzetak("Matrica nije definisana!");
		}
		for(int i = 0; i < dimenzije; i++) {
			for(int j = 0; j < dimenzije; j++) {
				System.out.print(elementi[i][j] + " ");
			}
			System.out.println();
		}
		
	}

	@Override
	public void ucitajSaStandardnog() throws NegativnaDimenzijaIzuzetak, NumberFormatException, IOException {
		InputStreamReader kbd = new InputStreamReader(System.in);
		BufferedReader b = new BufferedReader(kbd);
		
		System.out.println("Unesi dimenzije:");
		dimenzije = Integer.parseInt(b.readLine());
		
		if(dimenzije < 1) {
			throw new NegativnaDimenzijaIzuzetak("Dimenzija matrice mora biti veca od 0");			
		}
		
		elementi = new double[dimenzije][dimenzije]; 
		System.out.println("Unesi elemente matrice:");
		for(int i = 0; i < dimenzije; i++) {
			for(int j = 0; j < dimenzije; j++) {
				elementi[i][j] = Double.parseDouble(b.readLine());
			}
		}
		
	}

	@Override
	public void ucitajIzBin(String imeFajla) throws NegativnaDimenzijaIzuzetak, IOException{
		FileInputStream f = new FileInputStream(imeFajla);
		BufferedInputStream b = new BufferedInputStream(f);
		DataInputStream d = new DataInputStream(b);
		
		dimenzije = d.readInt();
		
		if(dimenzije < 1){
			d.close();
			throw new NegativnaDimenzijaIzuzetak("Dimenzija mora biti veca od 0");
		}
		
		elementi = new double[dimenzije][dimenzije];
		for(int i = 0; i < dimenzije; i ++) {
			for(int j = 0; j < dimenzije; j++) {
				elementi[i][j] = d.readDouble();
			}
		}
		d.close();
	}

	@Override
	public void writeInBin(String imeFajla) throws NegativnaDimenzijaIzuzetak, IOException{
		FileOutputStream f = new FileOutputStream(imeFajla);
		BufferedOutputStream b = new BufferedOutputStream(f);
		DataOutputStream d = new DataOutputStream(b);
		
		if(dimenzije < 1){
			d.close();
			throw new NegativnaDimenzijaIzuzetak("Matrica nije definisana!");
		}
		
		d.writeInt(dimenzije);
		for(int i = 0; i < dimenzije; i++) {
			for(int j = 0; j < dimenzije; j++) {
				d.writeDouble(elementi[i][j]);
			}
		}
		d.close();
	}
	
	// https://gist.github.com/Cellane/398372/23a3e321daa52d4c6b68795aae093bf773ce2940#file-matrixoperations-java
	private static double matrixDeterminant (double[][] matrix) {
		double temporary[][];
		double result = 0;

		if (matrix.length == 1) {
			result = matrix[0][0];
			return (result);
		}

		if (matrix.length == 2) {
			result = ((matrix[0][0] * matrix[1][1]) - (matrix[0][1] * matrix[1][0]));
			return (result);
		}

		for (int i = 0; i < matrix[0].length; i++) {
			temporary = new double[matrix.length - 1][matrix[0].length - 1];

			for (int j = 1; j < matrix.length; j++) {
				for (int k = 0; k < matrix[0].length; k++) {
					if (k < i) {
						temporary[j - 1][k] = matrix[j][k];
					} else if (k > i) {
						temporary[j - 1][k - 1] = matrix[j][k];
					}
				}
			}

			result += matrix[0][i] * Math.pow (-1, (double) i) * matrixDeterminant (temporary);
		}
		return (result);
}

}
