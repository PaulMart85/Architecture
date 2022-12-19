package Seminar3;

public class Client {
    public static void main(String[] args) {

        Car car = new Concret1("BMW", "7", "White", "Sedan", 4,
                                         "A95", "Auto", 3.5);

        car.wheelCount = 5;

        Car car2 = new DTcar("BMW", "7", "White", "Sedan", 4, 
             "Auto", 3.5);

        Car car3 = new BenzineCar("BMW", "7", "White", "Sedan", 4,
         "Auto", 3.5);

         car2.fuel();
         car3.fuel();


    }
}
