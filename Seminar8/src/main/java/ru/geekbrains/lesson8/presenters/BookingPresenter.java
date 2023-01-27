package ru.geekbrains.lesson8.presenters;

import ru.geekbrains.lesson8.models.Table;

import java.util.Collection;
import java.util.Date;
import java.util.Optional;

public class BookingPresenter implements ViewObserver {

    private final Model model;

    private Collection<Table> tables;
    private final View bookingView;

    public BookingPresenter(Model model, View view){
        this.model = model;
        this.bookingView = view;
        view.setObserver(this);
    }

    /**
     * Получение списка всех столиков
     */
    public void loadTables(){
        tables = model.loadTables();
    }

    /**
     * Отобразить список столиков на представлении
     */
    public void updateView(){
        bookingView.showTables(tables);
    }

    /**
     * Показать результат резервирования столика
     * @param reservationNo номер брони
     */
    public int printReservationTableResult(int reservationNo){
        return bookingView.printReservationTableResult(reservationNo);
    }

    /**
     * Произошло событие, пользователь нажал на кнопку резерва столика
     * @param orderDate
     * @param tableNo
     * @param name
     */
    public int onReservationTable(Date orderDate, int tableNo, String name){
        // Optional<Table> table = tables.stream().filter(t -> t.getNo() == tableNo).findFirst();
        // if (table.isPresent())
            // int reservationNo = model.reservationTable(orderDate, tableNo, name);
        // BookingPresenter сообщает View о результате бронирования
        return printReservationTableResult(
                model.reservationTable(orderDate, tableNo, name)
        );
    }

    public int onChangeReservationTable(int oldReservation, Date orderDate, int tableNo, String name){

        // BookingPresenter сообщает View о результате бронирования
        return printReservationTableResult(
                model.changeReservationTable(oldReservation, orderDate, tableNo, name)
        );
    }

}
