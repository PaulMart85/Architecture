package Seminar1;

public class Camera extends Model {

    public Camera(int id, Point3D location, Angle3D angle) {

        super(id, location, angle);
        
    }

    @Override
    public void move(Point3D point) {

        super.location = new Point3D(point);

    }

    @Override
    public void rotate(Angle3D angle) {

        super.angle = new Angle3D(angle);        

    }

}
