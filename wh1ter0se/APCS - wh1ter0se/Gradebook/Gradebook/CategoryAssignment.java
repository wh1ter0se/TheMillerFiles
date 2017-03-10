/****************************************************
**
** CategoryAssignment class
**
** This class represents an CategoryAssignment. 
** Do not add any additional methods to this class.
**
****************************************************/
public class CategoryAssignment extends Assignment {
    private String category;
    
    public CategoryAssignment(String n, double ptsPoss, double ptsEarned, String cat) {
        super(n, ptsPoss, ptsEarned);
        category = cat;
    }

    public String getCategoryName() {
        return category;
    }
}
