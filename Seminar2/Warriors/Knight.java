package Seminar2.Warriors;

import java.util.ArrayList;
import java.util.List;
import java.util.Random;

import Seminar2.Settings;
import Seminar2.Armours.*;
import Seminar2.Weapons.*;

public class Knight extends Warrior {

    private Random rnd = new Random();
    
    // агрегация
    public Knight(String name, List<Ammo> weapon, List<Ammunition> ammun, int hlth) {
        super(name, weapon, ammun, hlth);
    }

    // композиция
    public Knight() { 
        super("Knight", new ArrayList<Ammo>(), new ArrayList<Ammunition>(), Settings.Knight_defaultHealth);
        issueAmmoes();
        equipArmours();
    }

    /**
     * Выдать оружие.
     */
    private void issueAmmoes() {
        ammoes.add(new SwordFirst());
        ammoes.add(new SwordSecond());
    }

    /**
     * Снабдить броней.
     */
    private void equipArmours() {
        armours.add(new ChainMailFirst());
        armours.add(new ChainMailSecond());
        armours.add(new LatFirst());
        armours.add(new LatSecond());
    }

    @Override
    public Ammo strike() {
        int index = rnd.nextInt(ammoes.size() + 1); // случайный выбор оружия для нанесения очередного удара
        return index < ammoes.size() ? ammoes.get(index) : null; // null значит "промах"
    }

    @Override
    public void whenHit(Ammo hit) {

        if (status() == "Побежден!")  {
            System.out.println("Knight, ты побежден!");
            return;
        }

        if (hit == null) {
            System.out.println("Bowman промахнулся!");
            return;
        }

        int index = rnd.nextInt(armours.size()); // случайный выбор брони для очередной защиты
        Ammunition arm = armours.get(index);

        if (arm.isPenetrated(hit)) {
            System.out.println("Knight, ты ранен!");
            this.health -= Settings.Knight_healthDecrease;
        }
        else System.out.println("Knight, твоя броня не пробита!");

    }
    
}
