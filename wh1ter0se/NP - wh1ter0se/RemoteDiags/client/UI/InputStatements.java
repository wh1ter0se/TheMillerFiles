package UI;

import java.io.IOException;
import java.net.URL;
import java.util.Random;
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
			printStats();}
		while (in.next().contains("n")) {
			spamRandyHeader(Contact.SERVER_URL); } }
	
	public static void printStats() {
		while (true) {
								System.out.print("\033[H\033[2J");
								System.out.flush(); // this should clear the console
			System.out.println(BAR);
			for (String module : CONTACT.getStats()) { //TODO properly space long module names
				String newStr = "=";	
				for (int n = 0; n < ((30 - module.length())/2); n++) { newStr += " "; }
				newStr += module;
				for (int n = 0; n < ((30 - module.length())/2); n++) { newStr += " "; }
				System.out.println(newStr + "="); } 
				System.out.println(BAR); } }
			
		
	
	public static void spamRandyHeader(URL url) {
		//thread scheduling stuff
			while(true) {
				RandyHeaderThread rndt = new RandyHeaderThread(Contact.SERVER_URL);
				rndt.setPriority(5);
				rndt.start(); } }
}
