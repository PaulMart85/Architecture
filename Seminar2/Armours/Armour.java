package Seminar2.Armours;

import Seminar2.Enums.AType;

abstract public class Armour {

    protected AType armourType; // вид брони (кольчуга - легкая броня, латы - тяжелая броня и пр.)
    protected int thickness; // толщина брони

    public Armour(AType armourType, int thickness) {
        this.armourType = armourType;
        this.thickness = thickness;
    }

    @Override
    public String toString() {
        return String.format("Броня %s толщиной %d", armourType, thickness);
    }

}
