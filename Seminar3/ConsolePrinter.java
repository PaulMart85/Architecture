package Seminar3;

import java.util.List;

public class ConsolePrinter implements Printable {

    @Override
    public void Print(List<Shape> shapes) {
    
        for (Shape shape : shapes) 
            System.out.println(shape.toString());
    
    }
    
}
