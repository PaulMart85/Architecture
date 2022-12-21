package Seminar3;

public class Circle extends Ellipse {

    /**
     * Создание круга по координатам центра и радиусу.
     * @param center координаты центра
     * @param radius радиус круга
     */
    public Circle(Point center, double radius) {
        super(center, radius, radius);
        this.setShapeType(ShapeType.CIRCLE);
    }

    /**
     * Создание круга по координатам центра и радиусу.
     * @param xCenter Х-координата центра
     * @param yCenter Y-координата центра
     * @param radius радиус круга
     */
    public Circle(double xCenter, double yCenter, double radius) {
        this(new Point(xCenter, yCenter), radius);
    }

    public double routeP() {

        return 2.0 * Math.PI * getSmallSemiAxis();

    }

    public double routeS() {
    
        return Math.PI * getSmallSemiAxis() * getLargeSemiAxis();

    }

    @Override
    public String toString() {
        
        return String.format("Круг (%s; %s), радиус %s : P = %.2f; S = %.2f", 
            getCenter().getX(), getCenter().getY(), getSmallSemiAxis(), routeP(), routeS());

    }

}
