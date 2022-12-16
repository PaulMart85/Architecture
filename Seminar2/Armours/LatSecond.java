package Seminar2.Armours;

import Seminar2.Settings;
import Seminar2.Weapons.Ammo;

public class LatSecond extends Ammunition {

    /**
     * Латы второго вида.
     */
    public LatSecond() {
        super(new Lat(), "second");
    }

    @Override
    public boolean isPenetrated(Ammo weapon) {
        return weapon.getDamage() > (int)(super.armour.thickness * Settings.LatsSecond_penetrableCoeff);
    }
    
}
