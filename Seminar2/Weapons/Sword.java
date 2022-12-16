package Seminar2.Weapons;

import Seminar2.Settings;
import Seminar2.Enums.WType;

public class Sword extends Weapon {

    public Sword() {
        super(WType.SWORD, Settings.Sword_defaultPower); // дефолтные значения
    }
    
}
