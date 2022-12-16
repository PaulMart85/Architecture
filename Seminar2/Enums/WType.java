package Seminar2.Enums;

public enum WType {
    BOW("Лук"), 
    SWORD("Меч");

    private String tp;

    WType(String type) {
        tp = type;
    }    

    public String getWeaponType() {
        return tp;
    }

}
