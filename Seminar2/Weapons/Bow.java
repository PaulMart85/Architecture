package Seminar2.Weapons;

import Seminar2.Settings;
import Seminar2.Enums.WType;

public class Bow extends Weapon {

    public Bow() {
        super(WType.BOW, Settings.Bow_defaultPower); // дефолтные значения
    }

}
