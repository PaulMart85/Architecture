package Seminar3;

public class Rectangle extends Shape {

    private Point topLeft, bottomRight;

    /**
     * Создание произвольного прямоугольника по координатам углов - левого верхнего и правого нижнего. 
     * @param topLeft координаты левого верхнего угла
     * @param bottomRight координаты правого нижнего угла
     */
    public Rectangle(Point topLeft, Point bottomRight) {
        super(ShapeType.RECTANGLE);
        this.topLeft = topLeft;
        this.bottomRight = bottomRight;
    }

    /**
     * Создание произвольного прямоугольника по координатам левого верхнего угла, ширине и высоте.
     * @param xLeft Х-координата левого верхнего угла
     * @param yTop Y-координата левого верхнего угла
     * @param width ширина прямоугольника
     * @param height высота прямоугольника
     */
    public Rectangle(double xLeft, double yTop, double width, double height) {
        this(new Point(xLeft, yTop), new Point(xLeft+width, yTop+height));
    }

    /**
     * Создание произвольного прямоугольника по координатам левого верхнего угла, ширине и высоте.
     * @param topLeft координаты левого верхнего угла
     * @param width ширина прямоугольника
     * @param height высота прямоугольника
     */
    public Rectangle(Point topLeft, double width, double height) {
        this(topLeft.getX(), topLeft.getY(), width, height);
    }

    public double routeP() {

        return getWidth() * 2.0 + getHeight() * 2.0;

    }

    public double routeS() {

        return getWidth() * getHeight();

    }

    public boolean verifyShape() {        

        if (topLeft.getX() != bottomRight.getX() && topLeft.getY() != bottomRight.getY()) return true;
        return false;

    }  

    @Override
    public String toString() {
        
        return String.format("Прямоугольник (%s; %s), (%s; %s) : P = %.2f; S = %.2f", 
            topLeft.getX(), topLeft.getY(), bottomRight.getX(), bottomRight.getY(), routeP(), routeS());

    }

    public Point getTopLeft() {
        return topLeft;
    }

    public void setTopLeft(Point topLeft) {
        this.topLeft = topLeft;
    }

    public Point getBottomRight() {
        return bottomRight;
    }

    public void setBottomRight(Point bottomRight) {
        this.bottomRight = bottomRight;
    }

    public double getWidth() {
        return Math.abs(bottomRight.getX() - topLeft.getX());
    }

    public double getHeight() {
        return Math.abs(bottomRight.getY() - topLeft.getY());
    }
    
}
