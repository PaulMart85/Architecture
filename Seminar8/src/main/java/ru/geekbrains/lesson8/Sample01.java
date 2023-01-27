package ru.geekbrains.lesson8;

import ru.geekbrains.lesson8.models.TableModel;
import ru.geekbrains.lesson8.presenters.BookingPresenter;
import ru.geekbrains.lesson8.views.BookingView;

import java.util.Date;

public class Sample01 {

    /**
     * ДОМАШНЯЯ РАБОТА
     * Метод changeReservationTable должен ЗАРАБОТАТЬ!
     *
     * @param args
     */
    public static void main(String[] args) {
        TableModel model = new TableModel();
        BookingView view = new BookingView();
        BookingPresenter bookingPresenter = new BookingPresenter(model, view);

        bookingPresenter.loadTables();
        bookingPresenter.updateView();

        // Станислав бронирует столик № 4
        int firstClientOrder = view.reservationTable(new Date(), 4, "Станислав");

        // Роман бронирует столик № 3
        int secondClientOrder = view.reservationTable(new Date(), 3, "Роман");

        // Станислав решил отменить текущую бронь и забронировать столик 5
        firstClientOrder = view.changeReservationTable(firstClientOrder, new Date(), 5, "Станислав");

    }

}
