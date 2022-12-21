package Seminar3;

public class Point {

    private double x, y;

    /**
     * Координаты точки в 2D.
     * Будем отсчитывать от левого верхнего угла экрана (или гипотетической сцены)
     * @param x
     * @param y
     */
    public Point(double x, double y) {
        this.x = x;
        this.y = y;
    }

    public Point() {
        this(0,0);
    }

    public Point(Point point) {
        this(point.x, point.y);
    }

    public double getX() {
        return x;
    }

    public void setX(double x) {
        this.x = x;
    }

    public double getY() {
        return y;
    }

    public void setY(double y) {
        this.y = y;
    }

}
