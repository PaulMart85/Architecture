package Seminar3;

public class DTcar extends Car {

    protected DTcar(String brand, String model, String color, String cabin, int wheelCount, String gearBox,
            double engineVolume) {
        super(brand, model, color, cabin, wheelCount, "DT", gearBox, engineVolume);
        //TODO Auto-generated constructor stub
    }

    @Override
    public void fuel() {
        System.out.println("Zapravka DT");        
    }
    
}
