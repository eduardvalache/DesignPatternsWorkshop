using System;
using System.Collections.Generic;
// ReSharper disable InconsistentNaming

namespace WorkshopExample
{
    public class UbiquitousLanguage
    {
        private readonly TrainDataService trainDataService;

        private readonly BookingReferenceService bookingReferenceService;

        public UbiquitousLanguage()
        {
            trainDataService = new TrainDataService();
            bookingReferenceService = new BookingReferenceService();
        }

        public Reservation Reserve(string trainId, int seatsRequestedCount)
        {
            var train = trainDataService.GetTrain(trainId);

            if (train.DoesNotExceedCapacityLimit(seatsRequestedCount))
            {
                var reservationAttempt = train.BuildReservationAttempt(trainId, seatsRequestedCount);

                if (reservationAttempt.IsFulfilled)
                {
                    var bookingRef = bookingReferenceService.GetBookingReference();

                    reservationAttempt.AssignBookingReference(bookingRef);

                    trainDataService.BookSeats(reservationAttempt);

                    var reservation = reservationAttempt.Confirm();

                    return reservation;
                }
            }

            return new ReservationFailed(trainId, seatsRequestedCount);
        }
    }

    public class TrainDataService
    {
        public Train GetTrain(string trainId)
        {
            throw new NotImplementedException();
        }

        public void BookSeats(ReservationAttempt reservationAttempt)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Train> Find(Func<Train, bool> func)
        {
            throw new NotImplementedException();
        }
     
    }

    public class BookingReferenceService
    {
        public Booking GetBookingReference()
        {
            throw new NotImplementedException();
        }
    }

    public class Booking
    {

    }

    public class ReservationAttempt
    {
         public bool IsFulfilled { get; set; }

        public void AssignBookingReference(Booking bookingRef)
        {
            throw new NotImplementedException();
        }

        public Reservation Confirm()
        {
            throw new NotImplementedException();
        }
    }

    public class Reservation
    {
    }

    public class ReservationFailed : Reservation
    {
        public ReservationFailed(string trainId, int seatsRequestedCount)
        {
            throw new NotImplementedException();
        }
    }

    public class Train
    {                       
        public string Guid { get; set; }

        public bool DoesNotExceedCapacityLimit(int requestedSeatsCount)
        {
            throw new NotImplementedException();
        }

        public ReservationAttempt BuildReservationAttempt(string trainId, int seatsRequestedCount)
        {
            throw new NotImplementedException();
        }
    }
}                                        