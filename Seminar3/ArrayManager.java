package Seminar3;

import java.util.ArrayList;
import java.util.List;

public class ArrayManager {
    
    private List<Shape> shapes;

    public ArrayManager() {
        shapes = new ArrayList<>();
    };

    public ArrayManager(Shape[] shapes) throws GraphicException {
        this();
        addShapes(shapes);
    }

    public List<Shape> getShapes() {
        return shapes;
    }
    public Shape getShape(int index) {
        return shapes.get(index);
    }

    // добавить массив фигур
    public void addShapes(Shape[] shapes) throws GraphicException {
        
        for(Shape shape : shapes) {
            verify(shape);
            this.shapes.add(shape);
        }

    }

    // добавить новую фигуру
    public void addShape(Shape shape) throws GraphicException {
        verify(shape);
        this.shapes.add(shape);
    }

    // проверка на возможность создания фигуры
    private void verify(Shape shape) throws GraphicException {
        if(shape == null) throw new GraphicException(GraphicErrorCode.NULL_SHAPE);
        if(!shape.verifyShape()) throw new GraphicException(GraphicErrorCode.NOT_SHAPE, shape);
    }

    // печать информации о всех фигурах
    public void printInfo(Printable printer) throws GraphicException {
        printer.Print(shapes);
    }
    
}
