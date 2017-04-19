package server;

import java.io.IOException;
import java.io.OutputStreamWriter;
import java.io.Writer;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.Date;

import com.sun.istack.internal.logging.Logger;

public class Server {
	public final static int PORT = 13;
	public final static Logger LOG;
    
    public static void main(String[] args) {
    	try (ServerSocket server = new ServerSocket(PORT)) {
            while (true) {
            	try (Socket connection = server.accept()) {
                    Writer out = new OutputStreamWriter(connection.getOutputStream());
                    Date now = new Date();
                    out.write(now.toString() + "\r\n");
                    out.flush();
                    connection.close();
                } catch (IOException ex) { System.err.println(ex); }
            }
        } catch (IOException ex) { System.err.println(ex); }
    }
    
    private void error() {
    	
    }
    
    private void log() {
    	
    }
}
