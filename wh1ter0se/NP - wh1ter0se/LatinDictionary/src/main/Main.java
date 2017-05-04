package main;

import java.util.Scanner;

import IO.ServerContact;

public class Main {
	
	private static String ENGLISH_WORD;

	public static void main(String[] args) { while (true) {
		System.out.println("Enter the word in English.");
		Scanner in = new Scanner(System.in);
		ENGLISH_WORD = in.nextLine();
		int i = 0; String print = ENGLISH_WORD;
		while (true) {
			i++;
			System.out.println(ServerContact.getLatin(ENGLISH_WORD) + "\r\n");
			print = print.substring(print.indexOf(" ", print.indexOf(" ") + i));
			if (print == "-1") { break; }}
		System.out.println(ServerContact.getLatin(ENGLISH_WORD));
	}}

}
