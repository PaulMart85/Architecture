package Seminar2.Armours;

import Seminar2.Settings;
import Seminar2.Weapons.Ammo;

public class ChainMailFirst extends Ammunition {

    /**
     * Кольчуга первого вида.
     */
    public ChainMailFirst() {
        super(new ChainMail(), "first");
    }

    @Override
    public boolean isPenetrated(Ammo weapon) {
        return weapon.getDamage() > (int)(super.armour.thickness * Settings.ChainMailFirst_penetrableCoeff);
    }
    
}
