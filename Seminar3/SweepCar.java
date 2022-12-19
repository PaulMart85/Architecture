package Seminar3;

public class SweepCar extends Car implements CleanSurfaces {
    
    protected SweepCar(String brand, String model, String color, String cabin, int wheelCount, String fuel,
            String gearBox, double engineVolume) {
        super(brand, model, color, cabin, wheelCount, fuel, gearBox, engineVolume);
        //TODO Auto-generated constructor stub
    }

    void sweepStreet() {
        System.out.println("Sweep");
    }

    @Override
    public void fuel() {
        // TODO Auto-generated method stub
        
    }

    @Override
    public void protirkaStekla() {
        // TODO Auto-generated method stub
        
    }

    @Override
    public void protirkaFar() {
        // TODO Auto-generated method stub
        
    }

    @Override
    public void protirkaZerkal() {
        // TODO Auto-generated method stub
        
    }
    
}
