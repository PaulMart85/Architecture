package Seminar2.Weapons;

import Seminar2.Enums.WType;

abstract public class Weapon {

    protected WType weaponType; // вид оружия (лук, меч и пр)
    protected int power; // ударная сила
    
    public Weapon(WType weaponType, int power) {
        this.weaponType = weaponType;
        this.power = power;
    }

    @Override
    public String toString() {
        return String.format("Оружие %s с ударной силой %d", weaponType, power);
    }

}
