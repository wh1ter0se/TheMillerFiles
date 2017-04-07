package main;

import java.util.Scanner;
import output.Output;

public class Main {
	
	private static Scanner IN;
	private static String NAME;

	public static void main(String[] args) {
		System.out.println("Enter your name:");
		IN = new Scanner(System.in);
		NAME = IN.nextLine();
		Output.sendToServer(NAME);
	}
}
