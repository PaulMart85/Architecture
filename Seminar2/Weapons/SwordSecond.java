package Seminar2.Weapons;

import Seminar2.Settings;

public class SwordSecond extends Ammo {

    /**
     * Меч второго вида.
     */
    public SwordSecond() {
        super(new Sword(), "second");
    }

    @Override
    public int getDamage() { // такое повреждение от номин наносит меч второго вида 
        return (int)(super.weapon.power * Settings.SwordSecond_powerCoeff);
    }
    
}
