package Seminar3;

public class Square extends Rectangle {

    /**
     * Создание квадрата по координатам левого верхнего угла и длине стороны.
     * @param topLeft координаты левого верхнего угла
     * @param sideLength длина стороны квадрата
     */
    public Square(Point topLeft, double sideLength) {
        super(topLeft, sideLength, sideLength);
        this.setShapeType(ShapeType.SQUARE);
    }

    /**
     * Создание квадрата по координатам левого верхнего угла и длине стороны.
     * @param xLeft Х-координата левого верхнего угла
     * @param yTop Y-координата левого верхнего угла
     * @param sideLength длина стороны квадрата
     */
    public Square(double xLeft, double yTop, double sideLength) {
        this(new Point(xLeft, yTop), sideLength);
    }

    @Override
    public String toString() {

        return String.format("Квадрат (%s; %s), длина стороны %s : P = %.2f; S = %.2f", 
            getTopLeft().getX(), getTopLeft().getY(), getHeight(), routeP(), routeS());

    }
    
}
