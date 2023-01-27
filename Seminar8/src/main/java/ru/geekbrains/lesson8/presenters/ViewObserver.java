package ru.geekbrains.lesson8.presenters;

import java.util.Date;

public interface ViewObserver {
    int onReservationTable(Date orderDate, int tableNo, String name);
    int onChangeReservationTable(int oldReservation, Date orderDate, int tableNo, String name);
}
