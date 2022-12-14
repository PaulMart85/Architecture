package Seminar1;

public class Angle3D {
    private int a, b, c;

    public Angle3D(int a, int b, int c) {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public Angle3D() {
        this(0,0,0);
    }

    public Angle3D(Angle3D angle) {
        this(angle.a, angle.b, angle.c);
    }

    public int getA() {
        return a;
    }

    public void setA(int a) {
        this.a = a;
    }

    public int getB() {
        return b;
    }

    public void setB(int b) {
        this.b = b;
    }

    public int getC() {
        return c;
    }

    public void setC(int c) {
        this.c = c;
    }

    @Override
    public int hashCode() {
        final int prime = 31;
        int result = 1;
        result = prime * result + a;
        result = prime * result + b;
        result = prime * result + c;
        return result;
    }

    @Override
    public boolean equals(Object obj) {
        if (this == obj)
            return true;
        if (obj == null)
            return false;
        if (getClass() != obj.getClass())
            return false;
        Angle3D other = (Angle3D) obj;
        if (a != other.a)
            return false;
        if (b != other.b)
            return false;
        if (c != other.c)
            return false;
        return true;
    }

}
