package Seminar3;

public class Client {
    
    public static void main(String[] args) {

        ArrayManager arrayShapes;

        Triangle tr1 = new Triangle(new Point(1.5, 3.0), new Point(5.2, -18.54), new Point(10.1, 2.44));
        Triangle tr2 = new Triangle(new Point(1, 30), new Point(5, -3), new Point(20, -4));
        Square sqr1 = new Square(new Point(12.3, 18.1), 5.0);
        Rectangle rct1 = new Rectangle(new Point(5.2, 4.8), new Point(10.32, -2.0));
        Rectangle sqr2 = new Rectangle(new Point(10.0, 5.0), new Point(15.0, 10.0));
        Circle cir1 = new Circle(new Point(12.3, 18.5), 13.8);
        
        Triangle trNull = null;
        Triangle trNotTriangle = new Triangle(new Point(1, 2), new Point(1, 2), new Point(2, 5.3));

        // имеется один массив фигур
        Shape[] shapes1 = new Shape[]{tr1, tr2, rct1, cir1};

        // и другой массив фигур
        Shape[] shapes2 = new Shape[]{tr1, sqr1, sqr2};

        try {
            // создаем (загружаем) фигуры
            arrayShapes = new ArrayManager(shapes1);
            // добавляем фигуры
            arrayShapes.addShapes(shapes2);

            // добавление следующих фигур вызовет ошибку
            // arrayShapes.addShape(trNotTriangle);
            // arrayShapes.addShape(trNull);

            // вывод инфо о всех фигурах
            arrayShapes.printInfo(new ConsolePrinter());
            arrayShapes.printInfo(new FilePrinter());
            
        } catch (GraphicException e) {
            e.printStackTrace();
        }

    }
}
