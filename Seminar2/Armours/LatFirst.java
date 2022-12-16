package Seminar2.Armours;

import Seminar2.Settings;
import Seminar2.Weapons.Ammo;

public class LatFirst extends Ammunition {

    /**
     * Латы первого вида.
     */
    public LatFirst() {
        super(new Lat(), "first");
    }

    @Override
    public boolean isPenetrated(Ammo weapon) {
        return weapon.getDamage() > (int)(super.armour.thickness * Settings.LatsFirst_penetrableCoeff);
    }
    
}
