package cibertec;

import java.util.Scanner;

public class frecuenciacardiaca {

	public static void main(String[] args) {
		//
		Scanner scanner = new Scanner (System.in); 
		
		int edad;
		double peso, frecuencia;
	    String nombre;
		System.out.println("Es un gusto calcular tu peso");
		
		System.out.println("Como te llamas?");
		nombre=scanner.toString();
		
		System.out.println("Ingrese su edad: ");
		edad=scanner.nextInt();
		 
		System.out.println("Ingrese su peso en kg");
		peso=scanner.nextDouble();
		
		frecuencia=210-(0.5*edad)-(0.1*peso+4);
		
		System.out.println("Tu frecuencia es: " + frecuencia); 
