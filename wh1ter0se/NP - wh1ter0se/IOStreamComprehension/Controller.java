
/**
 * Write a description of class Main here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
import java.io.*;

public class Controller
{

    public Controller(){}

    public int[] Input()
    {
        FileInputStream fin = null;
        try {
            fin = new FileInputStream("inputText.txt");
        }
        catch (FileNotFoundException e){
            System.err.println("what did you do to my input file man? it's not there anymore.");
        }
        Input input = new Input(fin);
        
        return input.GetRoots();
    }
    
    public void Output(int[] roots) {
        FileOutputStream fos = null;
        try {
            fos = new FileOutputStream("outputText.txt");
        }
        catch (FileNotFoundException e){
            System.err.println("what did you do to my output file man? it's not there anymore.");
        }
        Output output = new Output(fos);
        for (int i = 0; i < (roots.length - 1); i++) {
            output.Write(Integer.toString(roots[i] * roots[i]));
        }
    }
}
