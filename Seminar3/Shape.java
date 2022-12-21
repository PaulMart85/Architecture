package Seminar3;

public abstract class Shape implements Verifiable, Routable {
    
    private ShapeType shapeType;

    public Shape(ShapeType shapeType) {
        this.shapeType = shapeType;
    }

    public String getShapeType() {
        return shapeType.getType();
    }

    public void setShapeType(ShapeType shapeType) {
        this.shapeType = shapeType;
    }

}
