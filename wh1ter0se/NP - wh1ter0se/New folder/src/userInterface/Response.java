package userInterface;

import java.util.Scanner;

public class Response {
	public static Scanner IN;
	
	public Response() {
		IN = new Scanner(System.in);
	}
	
	public static String check() {
		return IN.nextLine();
	}
	
}
