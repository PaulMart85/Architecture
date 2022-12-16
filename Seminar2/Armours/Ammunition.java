package Seminar2.Armours;

import Seminar2.Weapons.Ammo;

public abstract class Ammunition {
    
    Armour armour; // конкретный вид брони
    String option; // вариант конкретного вида брони (латы такие-то и пр)
   
    /** Амуниция. Здесь - снаряжение кроме оружия. */
    public Ammunition(Armour armour, String option) {
        this.armour = armour;
        this.option = option;
    }

    public abstract boolean isPenetrated(Ammo weapon); // пробита ли броня зависит от оружия,
                                                       // которым нанесен удар
    
}
