package Seminar2.Weapons;

import Seminar2.Settings;

public class BowFirst extends Ammo {

    /**
     * Лук первого вида.
     */
    public BowFirst() {
        super(new Bow(), "first");
    }

    @Override
    public int getDamage() { // такое повреждение от номин наносит лук первого вида 
        return (int)(super.weapon.power * Settings.BowFirst_powerCoeff);
    }
    
}
