package Seminar2.Weapons;

public abstract class Ammo {
    
    Weapon weapon; // конкретный вид оружия
    String variant; // вариант конкретного вида оружия (лук такой-то и пр)
   
    /** Боеприпасы. */
    public Ammo(Weapon weapon, String variant) {
        this.weapon = weapon;
        this.variant = variant;
    }
 
    public abstract int getDamage(); // способность нанести урон связана с ударной силой оружия
                              // с учетом варианта конкретного вида оружия
    
}
