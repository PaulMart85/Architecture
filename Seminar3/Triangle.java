package Seminar3;

public class Triangle extends Shape {

    private Point nodeA, nodeB, nodeC;

    /**
     * Создание произвольного треугольника по трем вершинам.
     * @param nodeA координаты вершины А
     * @param nodeB координаты вершины В
     * @param nodeC координаты вершины С
     */ 
    public Triangle(Point nodeA, Point nodeB, Point nodeC) {
        super(ShapeType.TRIANGLE);
        this.nodeA = nodeA;
        this.nodeB = nodeB;
        this.nodeC = nodeC;
    }

    private double[] sideLength(Point nodeA, Point nodeB, Point nodeC) {

        double x1 = nodeA.getX(), y1 = nodeA.getY(),
               x2 = nodeB.getX(), y2 = nodeB.getY(),
               x3 = nodeC.getX(), y3 = nodeC.getY();

        double d1 = Math.sqrt(Math.pow(x1-x2, 2) + Math.pow(y1-y2, 2));
        double d2 = Math.sqrt(Math.pow(x3-x2, 2) + Math.pow(y3-y2, 2));
        double d3 = Math.sqrt(Math.pow(x1-x3, 2) + Math.pow(y1-y3, 2));

        return new double[]{d1, d2, d3};
    }

    public double routeP() {

        double[] sideLens = sideLength(nodeA, nodeB, nodeC);
        return sideLens[0] + sideLens[1] + sideLens[2];

    }

    public double routeS() {

        double[] sideLens = sideLength(nodeA, nodeB, nodeC);
        double halfP = (sideLens[0] + sideLens[1] + sideLens[2]) * 0.5;

        return Math.sqrt( halfP * (halfP-sideLens[0]) * (halfP-sideLens[1]) * (halfP-sideLens[2]) );
    }

    public boolean verifyShape() {        

        double[] sideLens = sideLength(nodeA, nodeB, nodeC);

        if (sideLens[0] <= Math.abs(sideLens[1]-sideLens[2]) || 
            sideLens[0] >= sideLens[1]+sideLens[2]) return false;
        
        return true;

    }

    public Point getNodeA() {
        return nodeA;
    }

    public void setNodeA(Point nodeA) {
        this.nodeA = nodeA;
    }

    public Point getNodeB() {
        return nodeB;
    }

    public void setNodeB(Point nodeB) {
        this.nodeB = nodeB;
    }

    public Point getNodeC() {
        return nodeC;
    }

    public void setNodeC(Point nodeC) {
        this.nodeC = nodeC;
    }

    @Override
    public String toString() {
        
        return String.format("Треугольник (%s; %s), (%s; %s), (%s; %s) : P = %.2f; S = %.2f", 
            nodeA.getX(), nodeA.getY(), nodeB.getX(), nodeB.getY(), nodeC.getX(), nodeC.getY(), routeP(), routeS());

    }
    
}
