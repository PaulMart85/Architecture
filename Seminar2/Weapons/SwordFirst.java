package Seminar2.Weapons;

import Seminar2.Settings;

public class SwordFirst extends Ammo {

    /**
     * Меч первого вида.
     */
    public SwordFirst() {
        super(new Sword(), "first");
    }

    @Override
    public int getDamage() { // такое повреждение от номин наносит меч первого вида 
        return (int)(super.weapon.power * Settings.SwordFirst_powerCoeff);
    }
    
}
