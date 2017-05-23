package UI;

import java.util.Scanner;

import server.Contact;

public class InputStatements {
	private final static String BAR = "==============================";
	
	public static void initConfig() {
		System.out.println("=     Enter 'y' to start     =");
		System.out.println("= Enter 'n' for header spam  =");
		System.out.println(BAR);
		Scanner in = new Scanner(System.in);
		while (in.next().contains("y")) {
			int i = 1;
			Contact contact = new Contact();
			for (String module : contact.getStats()) { //TODO properly space long module names
				String newStr = "=";	
				for (int n = 0; n < ((30 - module.length())/2); n++) { System.out.print(" "); } }
		while (in.next().contains("n")) {
			//THREAD MANAGEMENT STUFF HERE
		}
		
			
	}
}
}
