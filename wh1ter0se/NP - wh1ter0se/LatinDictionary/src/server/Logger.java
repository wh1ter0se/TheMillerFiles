package server;

import java.util.ArrayList;
import java.util.Date;

public class Logger {
	private static ArrayList REQUESTS, ERRORS;
	private static Date NOW;
	private static String HISTORY;
	
	public Logger() {
		REQUESTS = new ArrayList();
		ERRORS = new ArrayList();
		HISTORY = "";
	}
	
	public void request(String client) {
		NOW = new Date();
		HISTORY += "\r\n" + NOW + ": request from " + client;
	}
	
	public void error(String client, String error) {
		
	}
	
	public ArrayList getRequests() {
		return REQUESTS;
	}
	
	public ArrayList getErrors() {
		return ERRORS;
	}
	
	public String getHistory() {
		return HISTORY;
	}
}
