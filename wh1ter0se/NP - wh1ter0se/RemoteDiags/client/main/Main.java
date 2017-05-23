//TODO implement threads
//TODO implement cookies
//TODO implement auth calss

package main;

import UI.*;
import server.Contact;

public class Main {

	public static void main(String[] args) {
		StaticStatements.welcome();
		InputStatements.initConfig();
		Contact.readHeader();
	}

}
