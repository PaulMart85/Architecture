package Seminar3;

import java.io.IOException;

public class GraphicException extends Exception {

    private GraphicErrorCode errCode;

    public GraphicException(GraphicErrorCode errCode) {
        super(errCode.getErrorString());
        this.errCode = errCode;
    }

    public GraphicException(GraphicErrorCode errCode, Shape shape) {
        super(shape.getShapeType() + " : " + errCode.getErrorString());
        this.errCode = errCode;
    }

    public GraphicException(GraphicErrorCode errCode, IOException ex) {
        super(errCode.getErrorString() + ex.fillInStackTrace());
        this.errCode = errCode;
    }

    public GraphicErrorCode getGraphicErrorCode() {
        return errCode;
    }
}
