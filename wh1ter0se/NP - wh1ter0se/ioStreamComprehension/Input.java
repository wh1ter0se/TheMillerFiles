import java.io.*;

public class Input
{
    BufferedReader bin;
    
    // 
    public Input(FileInputStream i){
        bin = new BufferedReader(
                new InputStreamReader(i));
    }
    
    public int[] GetRoots() {
        int lineRoot = 0;
        try { lineRoot = Integer.parseInt(bin.readLine()); } catch (IOException e) { System.err.println("there's nothing there"); }
                                                             catch (NumberFormatException e) { System.err.println("there's nothing there"); }
        int i = 1;
        int[] tempInit = new int[1];
        while (lineRoot != -1) {
            int[] temp = new int[i];
            for (int n = 0; n < tempInit.length; n++) { temp[n] = tempInit[n]; }
            temp[temp.length - 1] = lineRoot;            
            tempInit = temp;
            try {
                bin.mark(2);
                if (bin.readLine() == null) {
                    lineRoot = -1;
                } else {
                    bin.reset();
                    lineRoot = Math.abs(Integer.parseInt(bin.readLine()));
                }
            } 
            catch (IOException e) { System.err.println("program finished"); }
            catch (NumberFormatException e) { System.err.println("program finished"); }
                                                                                                           //alright so that check is causing it to skip every other result
            i++;
        }
        int rootSize = i; int[] output = tempInit;
        return output;
    }
}
