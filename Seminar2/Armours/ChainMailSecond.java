package Seminar2.Armours;

import Seminar2.Settings;
import Seminar2.Weapons.Ammo;

public class ChainMailSecond extends Ammunition {

    /**
     * Кольчуга второго вида.
     */
    public ChainMailSecond() {
        super(new ChainMail(), "second");
    }

    @Override
    public boolean isPenetrated(Ammo weapon) {
        return weapon.getDamage() > (int)(super.armour.thickness * Settings.ChainMailSecond_penetrableCoeff);
    }
    
}
