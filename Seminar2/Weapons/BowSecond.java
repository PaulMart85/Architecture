package Seminar2.Weapons;

import Seminar2.Settings;

public class BowSecond extends Ammo {

    /**
     * Лук второго вида.
     */
    public BowSecond() {
        super(new Bow(), "second");
    }

    @Override
    public int getDamage() { // такое повреждение от номин наносит лук второго вида 
        return (int)(super.weapon.power * Settings.BowSecond_powerCoeff);
    }
    
}
