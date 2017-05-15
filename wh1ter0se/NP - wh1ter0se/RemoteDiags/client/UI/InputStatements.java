package UI;

import server.Contact;

public class InputStatements {
	private final static String BAR = "==============================";
	
	public static void initConfig() {

		System.out.println("= Select modules and sizes,  =");
		System.out.println("=    seperated by commas     =");
		System.out.println("=       Ex: 1s, 3w, 2t       =");
		System.out.println(BAR);
		System.out.println("=           Sizes:           =");
		System.out.println("=  s-Small, t-tall, w-wide   =");
		System.out.println("=          Modules:          =");
		int i = 1;
		Contact contact = new Contact();
		for (String module : contact.getModuleList()) { //TODO properly space long module names
			module = "= " + i + ". " + module;
			int n = 1;
			while (module.length() > 28) {
				module = module.substring(0, 28 * n) + "\r\n" + module.substring(28 * n); }}		
	}
}
