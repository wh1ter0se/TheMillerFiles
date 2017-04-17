//TODO write line that extracts translation from returned text (might be in google drive?)
//TODO finish daytime server:
	// contact server for date and time through ServerContact
	// print returned date and time under each translation request
	// make logger for DaytimeServer requests and errors

package main;

import java.util.Scanner;

import IO.ServerContact;

public class Main {
	
	private static String ENGLISH_WORD;

	public static void main(String[] args) {
		System.out.println("Enter the word in English.");
		Scanner in = new Scanner(System.in);
		ENGLISH_WORD = in.nextLine();
		System.out.println(ServerContact.getLatin(ENGLISH_WORD));
	}

}
