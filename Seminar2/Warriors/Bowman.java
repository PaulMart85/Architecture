package Seminar2.Warriors;

import java.util.ArrayList;
import java.util.List;
import java.util.Random;

import Seminar2.Settings;
import Seminar2.Armours.*;
import Seminar2.Weapons.*;

public class Bowman extends Warrior {

    private Random rnd = new Random();
    
    // агрегация
    public Bowman(String name, List<Ammo> weapon, List<Ammunition> ammun, int hlth) {
        super(name, weapon, ammun, hlth);
    }

    // композиция
    public Bowman() { 
        super("Bowman", new ArrayList<Ammo>(), new ArrayList<Ammunition>(), Settings.Bowman_defaultHealth);
        issueAmmoes();
        equipArmours();
    }

    /**
     * Выдать оружие.
     */
    private void issueAmmoes() {
        ammoes.add(new BowFirst());
        ammoes.add(new BowSecond());
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
            System.out.println("Bowman, ты побежден!");
            return;
        }

        if (hit == null) {
            System.out.println("Knight промахнулся!");
            return;
        }

        int index = rnd.nextInt(armours.size()); // случайный выбор брони для очередной защиты
        Ammunition arm = armours.get(index);

        if (arm.isPenetrated(hit)) {
            System.out.println("Bowman, ты ранен!");
            this.health -= Settings.Bowman_healthDecrease;
        }
        else System.out.println("Bowman, твоя броня не пробита!");

    }
   
}
