package Seminar3;

public class BenzineCar extends Car {

    protected BenzineCar(String brand, String model, String color, String cabin, int wheelCount,
            String gearBox, double engineVolume) {
        super(brand, model, color, cabin, wheelCount, "Benz", gearBox, engineVolume);
        //TODO Auto-generated constructor stub
    }

    @Override
    public void fuel() {
        System.out.println("Benzine zapravka");
    }
    
}
