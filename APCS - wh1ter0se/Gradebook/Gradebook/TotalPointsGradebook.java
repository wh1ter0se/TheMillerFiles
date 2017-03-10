/****************************************************
**
** TotalPointsGradebook class
**
** This class represents a Gradebook that calculates
** grades according to the total points grading system.
**
****************************************************/
import java.util.ArrayList;

public class TotalPointsGradebook implements Gradebook {
    private ArrayList<Assignment> myGrades;
    
    public TotalPointsGradebook() {
        myGrades = new ArrayList<Assignment>();
    }
    
    public void add(Assignment assign) {
        myGrades.add(assign);
    }
    
    public double calculateGrade() {
        double maxPoints = 0.00;
        double earnedPoints = 0.00;
        double grade = 0.00;
        
        for (int i = 0; i < myGrades.size(); i++) {
            Assignment currentAssignment = myGrades.get(i);
            maxPoints += currentAssignment.getPointsPossible();
            earnedPoints += currentAssignment.getPointsEarned();
        }
        grade = earnedPoints / maxPoints;
        return grade;
    }
}
