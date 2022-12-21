package Seminar3;

public enum ShapeType {
    CIRCLE("Круг"),
    ELLIPSE("Эллипс"),
    RECTANGLE("Прямоугольник"), 
    SQUARE("Квадрат"), 
    TRIANGLE("Треугольник"),;
    
    private String type;

    ShapeType(String type) {
        this.type = type;
    }

    public String getType() {
        return type;
    }

}
