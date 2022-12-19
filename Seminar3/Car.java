package Seminar3;

// Создать конкретный автомобиль путём наследования класса «Car».

// Расширить абстрактный класс «Car», добавить метод: подметать улицу. 
// Создать конкретный автомобиль путём наследования класса «Car». Провести проверку принципа SRP.


// Расширить абстрактный класс «Car», добавить метод: включение противотуманных фар, перевозка груза. 
// Провести проверку принципа OCP.


// Создать конкретный автомобиль путём наследования класса «Car», определить число колёс = 3. 
// Провести проверку принципа LSP.


// 1. Спроектировать абстрактный класс «Car» у которого должны быть свойства: 
// марка, модель, цвет, тип кузова, число колёс, тип топлива, тип коробки передач, 
// объём двигателя; методы: движение, обслуживание, переключение передач, включение фар, 
// включение дворников.


// Создать конкретный автомобиль путём наследования класса «Car», определить метод «движение» - «полёт». 
// Провести проверку принципа LSP.



// Создать интерфейс «Заправочная станция», создать метод: заправка топливом.
// Имплементировать метод интерфейса «Заправочная станция» в конкретный класс «Car».


// Добавить в интерфейс «Заправочная станция» методы: протирка лобового стекла, протирка фар, протирка зеркал.
// Имплементировать все методы интерфейса «Заправочная станция» в конкретный класс «Car». 
// Провести проверку принципа ISP.



// Создать дополнительный/е интерфейсы и имплементировать их в конкретный класс «Car». 
// Провести проверку принципа ISP.
// Создать путём наследования класса «Car» два автомобиля: с бензиновым и дизельным двигателями, 
// имплементировать метод «Заправка топливом» интерфейса «Заправочная станция». 
// Реализовать заправку каждого автомобиля подходящим топливом. Провести проверку принципа DIP.




abstract public class Car implements GasStation { 

    protected String brand;    
    protected String model;    
    protected String color;
    protected String cabin;
    protected int wheelCount;    
    protected String fuel;
    protected String gearBox;
    protected double engineVolume;
    
    protected Car(String brand, String model, String color, String cabin, int wheelCount, String fuel, String gearBox,
            double engineVolume) {
        this.brand = brand;
        this.model = model;
        this.color = color;
        this.cabin = cabin;
        this.wheelCount = wheelCount;
        this.fuel = fuel;
        this.gearBox = gearBox;
        this.engineVolume = engineVolume;
    }

    public void move() { // default = protected - наследование = package visible
        System.out.println("Drive");
    }

    void service() {
        System.out.println("Go to service");
    }

    void changeGear() {
        System.out.println("Gear changed");
    }

    void turnLight() {
        System.out.println("Light");
    }

    void turnWipers() {
        System.out.println("Wipers");
    }

    void transportLoads() {
        System.out.println("Cargo");
    }

    // public int getWheelCount() {
    //     return wheelCount;
    // }

    // public int setWCount(int ){

    // }

    
}
