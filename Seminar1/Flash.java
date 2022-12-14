package Seminar1;

public class Flash extends Model {

    private Color color = Color.WHITE;
    private float power = 220.10f;

    public Flash(int id, Point3D location, Angle3D angle) {
        
        super(id, location, angle);

    }

    @Override
    public void move(Point3D point) {

        super.location = new Point3D(point.getX()+1, point.getY()+1, point.getZ()+1);
        
    }

    @Override
    public void rotate(Angle3D angle) {

        super.angle = new Angle3D(angle.getA()+5, angle.getB()+3, angle.getC()-4);      

    }

    /**
     * Изменить параметры освещения.
     * @param color
     * @param power
     */
    public void edit(Color color, float power) {

        this.color = color;
        this.power = power;

    }

    
}
