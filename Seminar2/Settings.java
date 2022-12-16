package Seminar2;

public class Settings {

    // КОЭФФИЦИЕНТЫ СОСТОЯНИЯ ВОИНОВ
    // исходное значение уровня здоровья для Лучника
    public static final int Bowman_defaultHealth = 12;
    // исходное значение уровня здоровья для Рыцаря
    public static final int Knight_defaultHealth = 10;
    // величина, на которую уменьшается здоровье Лучника при его ранении (при пробитии брони)
    public static final int Bowman_healthDecrease = 1;
    // величина, на которую уменьшается здоровье Лучника при его ранении (при пробитии брони)
    public static final int Knight_healthDecrease = 1;


    // КОЭФФИЦИЕНТЫ БРОНЕСТОЙКОСТИ:
    // номинальная толщина кольчуги (легкой брони)
    public static final int ChainMail_defaultThickness = 8;
    // добавочный вес к номинальной толщине кольчуги первого вида
    public static final double ChainMailFirst_penetrableCoeff = 0.6;
    // добавочный вес к номинальной толщине кольчуги второго вида
    public static final double ChainMailSecond_penetrableCoeff = 0.8;
    // номинальная толщина лат (тяжелой брони)
    public static final int Lats_defaultThickness = 18;
    // добавочный вес к номинальной толщине лат первого вида
    public static final double LatsFirst_penetrableCoeff = 0.45;
    // добавочный вес к номинальной толщине лат второго вида
    public static final double LatsSecond_penetrableCoeff = 1.0;


    // КОЭФФИЦИЕНТЫ УРОНА
    // номинальная ударная сила лука
    public static final int Bow_defaultPower = 12;
    // вес урона к номинальной ударной силе лука первого вида
    public static final double BowFirst_powerCoeff = 0.5;
    // вес урона к номинальной ударной силе лука второго вида
    public static final double BowSecond_powerCoeff = 1.0;
    // номинальная ударная сила меча
    public static final int Sword_defaultPower = 10;
    // вес урона к номинальной ударной силе меча первого вида
    public static final double SwordFirst_powerCoeff = 0.7;
    // вес урона к номинальной ударной силе меча второго вида
    public static final double SwordSecond_powerCoeff = 0.9;

}
