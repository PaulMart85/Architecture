package Seminar1;

abstract public class Model {
    protected int id;
    protected Point3D location;
    protected Angle3D angle;

    public Model(int id, Point3D location, Angle3D angle) {
        this.id = id;
        this.location = location;
        this.angle = angle;
    }

    /**
     * Перемещение модели в заданную точку сцены.
     * @param point
     */
    abstract public void move(Point3D point); 

    /**
     * Вращение модели на заданный угол.
     * @param angle
     */
    abstract public void rotate(Angle3D angle);

    public int getId() {
        return id;
    }

    public Point3D getLocation() {
        return location;
    }

    public Angle3D getAngle() {
        return angle;
    } 

}
