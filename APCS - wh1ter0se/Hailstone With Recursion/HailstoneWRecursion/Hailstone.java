
/**
 * Write a description of class Hailstone here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class Hailstone
{
    int a;
    int hailCount;
    int highVal;
    int[] highestLength = new int[5];
    int[] highestVal = new int[5];
    int[] lengthSeeds = new int[5];
    int[] valSeeds = new int[5];
    String numCounts;
    
    Hailstone() {
        
    }
   
    public void KiloRace() {
        for (int i = 0; i < 1000; i++) {
            a = i + 1;
            hailCount = 0; highVal = i;
            numCounts += a + " ";
            HailCaesar(a);
            numCounts += "\r\nLength: " + hailCount + "    Highest value: " + highVal + "\r\n\r\n";                                
            HighLength(hailCount); HighVal(highVal);
            String loading = "Loading....... "; loading += (i / 10) + "%";
            System.out.println(loading);
        }
        PrintEverything();        
    }
    
    public int HailCaesar(int num) {
        hailCount++;
        if (num == 1) {
            numCounts += "1 ";
            return 1;
        } else {
            if (num % 2 == 0) { num = num / 2;} else { num = num * 3 + 1;}
            if (num > highVal) { highVal = num; }
            numCounts += num + " ";
            HailCaesar(num);
            return num;
        }
    }
    
    public void HighVal(int highVal) {
        for (int j = 0; j < 5; j++) {
                if (highestVal[j] < highVal) {
                    for (int q = 4; q > j; q--) {
                        highestVal[(q)] = highestVal[q - 1];
                    }
                    for (int q = 4; q > j; q--) {
                        valSeeds[(q)] = valSeeds[q - 1];
                    }
                    highestVal[j] = highVal;
                    valSeeds[j] = a;
                    j = 5;
                }
            }
    }
    
    public void HighLength(int length) {
        for (int j = 0; j < 5; j++) {
                if (highestLength[j] < length) {
                    for (int q = 4; q > j; q--) {
                        highestLength[(q)] = highestLength[q - 1];
                    }
                    for (int q = 4; q > j; q--) {
                        lengthSeeds[(q)] = lengthSeeds[q - 1];
                    }
                    highestLength[j] = length;
                    lengthSeeds[j] = a;
                    j = 5;
                }
            }
    }
    
    public void PrintEverything() {
        System.out.println(numCounts);
        String output = "Highest values: ";
        for (int i = 0; i < 5; i++) {
            output += "[" + highestVal[i] + " (" + valSeeds[i] + ")" + "]    ";
        }
        System.out.println(output);
        output = "Highest lengths: ";
        for (int i = 0; i < 5; i++) {
            output += "[" + highestLength[i] + " (" + lengthSeeds[i] + ")" + "]    ";
        }
        System.out.println(output);
    }
}
