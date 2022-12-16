package Seminar2.Warriors;

import java.util.List;

import Seminar2.Armours.Ammunition;
import Seminar2.Ifaces.*;
import Seminar2.Weapons.Ammo;

abstract public class Warrior implements Actions, States {
    
    protected String warriorName;
    protected List<Ammo> ammoes;
    protected List<Ammunition> armours;
    protected int health;

    /**
     * Наш герой.
     * Герой имеет имя, снабжается оружием и броней, и, конечно, имеет некоторый уровень здоровья (или кол-во жизней)
     * @param name имя героя
     * @param weapon боеприпасы
     * @param ammun броня
     * @param hlth уровень здоровья. 
     * Герой наносит удар по противнику имеющимся оружием, которое выбирается случайным образом при каждом ходе,
     * поражая при этом броню противника. Броня противника каждым ходом выбирается также случайным образом. 
     * В случае, когда броня будет пробита, уровень здоровья (или кол-во жизней) противника уменьшается.
     * По достижении уровня здоровья значения 0 противник считается побежденным. 
     */
    public Warrior(String name, List<Ammo> weapon, List<Ammunition> ammun, int hlth) {
        warriorName = name;
        ammoes = weapon;
        armours = ammun;
        health = hlth;
    }

    public int getHealth() {
        return health;
    }

    /**
     * Текущее состояние героя.
     * @return
     */
    @Override
    public String indicateState() {
        return String.format("\t%s  Health:%d", warriorName, health);
    }

    @Override
    public String status() {

        if (this.health > 0) return "Жив!";
        else return "Побежден!";
    }

}
