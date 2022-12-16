package Seminar2;

import Seminar2.Warriors.*;

public class Battle {
    public static void main(String[] args) {
    
        Warrior bowman = new Bowman();
        Warrior knight = new Knight();

        int stp = 1;
        while(bowman.getHealth() > 0 && knight.getHealth() > 0) {
            System.out.println("Ход " + stp++);
            System.out.println("-----------------------------------------------");
            knight.whenHit(bowman.strike());
            System.out.println(knight.indicateState());
            bowman.whenHit(knight.strike());
            System.out.println(bowman.indicateState());
            System.out.println("===============================================");    
        }

        if (bowman.status() == "Побежден!" && knight.status() == "Побежден!") 
            System.out.println("\n\t\t!!! НИЧЬЯ !!!\n\n");
        else if (bowman.status() == "Побежден!")
            System.out.println("\n\t\t!!! РЫЦАРЬ ПОБЕДИЛ !!!\n\n");
        else System.out.println("\n\t\t!!! ЛУЧНИК ПОБЕДИЛ !!!\n\n");

    }
    
}
