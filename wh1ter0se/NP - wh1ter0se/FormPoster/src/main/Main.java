package main;

import java.util.Scanner;

public class Main {
	
	static Scanner IN;
	static String NAME;

	public static void main(String[] args) {
		System.out.println("Enter your name:");
		IN = new Scanner(System.in);
		NAME = IN.nextLine();
	}
}
