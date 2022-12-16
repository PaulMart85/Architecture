package Seminar2.Ifaces;

import Seminar2.Weapons.Ammo;

public interface Actions {
    Ammo strike();
    void whenHit(Ammo hit);
}
