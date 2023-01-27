package ru.geekbrains.lesson8.views;

import ru.geekbrains.lesson8.models.Table;
import ru.geekbrains.lesson8.presenters.View;
import ru.geekbrains.lesson8.presenters.ViewObserver;

import java.util.Collection;
import java.util.Date;

public class BookingView implements View {

    private ViewObserver observer;

    public void setObserver(ViewObserver observer){
        this.observer = observer;
    }

    public void showTables(Collection<Table> tables){
        for (Table table: tables) {
            System.out.println(table);
        }
    }

    /**
     * Действие клиента (пользователь нажал на кнопку бронирования), бронирование столика
     * @param orderDate дата брони
     * @param tableNo номер столика
     * @param name имя клиента
     */
    public int reservationTable(Date orderDate, int tableNo, String name){
        return observer.onReservationTable(orderDate, tableNo, name);
    }

    /**
     * Сообщение пользователю о результате бронирования
     * @param reservationNo номер брони
     */
    public int printReservationTableResult(int reservationNo){
        System.out.printf("Столик успешно забронирован. Номер вашей брони: #%d\n", reservationNo);
        return reservationNo;
    }

    /**
     * Действие клиента (пользователь нажал на кнопку изменения бронирования),
     * старую бронь отменить
     * новую бронь добавить
     *
     * @param oldReservation номер старой брони
     * @param orderDate дата новой брони
     * @param tableNo номер столика
     * @param name имя клиента
     */
    public int changeReservationTable(int oldReservation, Date orderDate, int tableNo, String name){
        return observer.onChangeReservationTable(oldReservation, orderDate, tableNo, name);
    }

}
