/****************************************************
**
** Assignment class
**
** This class represents an Assignment. 
**
****************************************************/
public class Assignment {
    private String name;
    private double pointsPossible;
    private double pointsEarned;

    public Assignment (String n, double ptsPoss, double ptsEarned) {
        name = n;
        pointsPossible = ptsPoss;
        pointsEarned = ptsEarned;
    }
    
    public String getName() {
        return name;
    }
  
    public double getPointsPossible() {
        return pointsPossible;
    }

    public double getPointsEarned() {
        return pointsEarned;
    }
}
