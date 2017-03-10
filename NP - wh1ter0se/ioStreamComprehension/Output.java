import java.io.*;

public class Output
{
    int bufferSize;
    DataOutputStream in;
    public Output(FileOutputStream i){
        in = new DataOutputStream(i);
    }
   
   public void Write(String str) {
        try {
           in.writeChars(str);
           in.writeChars("\r\n");
        }
        catch (IOException e) { 
            System.err.println("Could not write values.");
        }
   }
}
