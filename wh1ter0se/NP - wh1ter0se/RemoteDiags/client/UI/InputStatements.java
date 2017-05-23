package UI;

import java.io.IOException;
import java.util.Scanner;

import server.Contact;

public class InputStatements {
	private final static String  BAR     = "==============================";
	private final static Contact CONTACT = new Contact();
	
	public static void initConfig() {
		System.out.println("=     Enter 'y' to start     =");
		System.out.println("= Enter 'n' for header spam  =");
		System.out.println(BAR);
		Scanner in = new Scanner(System.in);
		while (in.next().contains("y")) { 
			try { printStats(); } 
				catch (IOException e) { System.err.println(e); } }
		while (in.next().contains("n")) {
			spamRandyHeader(); } } 
	
	public static void printStats() throws IOException {
		while (true) {
			Runtime.getRuntime().exec("cls");
			System.out.println(BAR);
			for (String module : CONTACT.getStats()) { //TODO properly space long module names
				String newStr = "=";	
				for (int n = 0; n < ((30 - module.length())/2); n++) { newStr += " "; }
				newStr += module;
				for (int n = 0; n < ((30 - module.length())/2); n++) { newStr += " "; }
				System.out.println(newStr + "="); } } } 
		
	
	public static void spamRandyHeader() {
		//thread management stuff
		}
}
