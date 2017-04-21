//TODO ask miller why the name won't show up in the post variable
package main;

import java.util.Scanner;
import output.Output;

public class Main {
	
	static Scanner IN;
	static String NAME;

	public static void main(String[] args) { while (true) {
		System.out.println("Enter your name:");
		IN = new Scanner(System.in);
		NAME = IN.nextLine();
		Output.sendToServer(NAME);
		System.out.println();
	}}
}
