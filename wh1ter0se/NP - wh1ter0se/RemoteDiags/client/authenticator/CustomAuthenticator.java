package authenticator;

import java.net.Authenticator;
import java.net.InetAddress;
import java.net.PasswordAuthentication;

public class CustomAuthenticator extends Authenticator {
	protected PasswordAuthentication getPasswordAuthentication() {
		 String prompt = getRequestingPrompt();
		 String hostname = getRequestingHost();
		 InetAddress ipaddr = getRequestingSite();
		 int port = getRequestingPort();
		 String username = "root";
		 String password = "toor";
		 return new PasswordAuthentication(username, password.toCharArray());
	}
}
