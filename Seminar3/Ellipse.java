package Seminar3;

public class Ellipse extends Shape {

    private Point center;
    private double smallSemiAxis, largeSemiAxis;

    /**
     * Создание произвольного эллипса по координатам центра и длинам полуосей. 
     * @param center координаты центра
     * @param smallSemiAxis малая полуось эллипса
     * @param largeSemiAxis большая полуось эллипса
     */
    public Ellipse(Point center, double smallSemiAxis, double largeSemiAxis) {
        super(ShapeType.ELLIPSE);
        this.center = center;
        this.smallSemiAxis = smallSemiAxis;
        this.largeSemiAxis = largeSemiAxis;
    }

    /**
     * Создание произвольного эллипса по координатам центра и длинам полуосей. 
     * @param xCenter Х-координата центра
     * @param yCenter Y-координата центра
     * @param smallSemiAxis малая полуось эллипса
     * @param largeSemiAxis большая полуось эллипса
     */
    public Ellipse(double xCenter, double yCenter, double smallSemiAxis, double largeSemiAxis) {
        this(new Point(xCenter, yCenter), smallSemiAxis, largeSemiAxis);
    }

    public double routeP() {

        return 0;

    }

    public double routeS() {

        return 0;

    }

    public boolean verifyShape() {        

        if (getSmallSemiAxis() == 0 || getLargeSemiAxis() == 0) return false;
        return true;

    }

    public Point getCenter() {
        return center;
    }

    public void setCenter(Point center) {
        this.center = center;
    }

    public double getSmallSemiAxis() {
        return smallSemiAxis;
    }

    public void setSmallSemiAxis(double smallSemiAxis) {
        this.smallSemiAxis = smallSemiAxis;
    }

    public double getLargeSemiAxis() {
        return largeSemiAxis;
    }

    public void setLargeSemiAxis(double largeSemiAxis) {
        this.largeSemiAxis = largeSemiAxis;
    }  

}
