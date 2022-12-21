package Seminar3;

public enum GraphicErrorCode {

    NOT_SHAPE("такую фигуру создать невозможно."),
    NULL_SHAPE("null в качестве фигуры недопустим."),
    WRONG_FILE("неверный файл.");

    private String errorString;

    GraphicErrorCode(String errorString) {
        this.errorString = errorString;
    }

    public String getErrorString() {
        return errorString;
    }

}
