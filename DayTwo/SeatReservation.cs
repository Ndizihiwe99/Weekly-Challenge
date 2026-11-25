// Cinema Seat Reservation


// Today's challenge focuses on arrays, classes, constructors, 
// conditional logic, and returning values. Trainees must implement 
// the feature and write a few tests.

// Scenario

// A small cinema needs a simple system to manage seat reservations for a screening.
//  Each seat can only be reserved once.

// Requirements

// 1. The constructor receives the total number of seats. It must throw `ArgumentOutOfRangeException` if the number is zero or negative.
// 2. Seat numbers start at `1`, not `0`.
// 3. `ReserveSeat` returns `true` when a seat is successfully reserved.
// 4. If a seat is already reserved, `ReserveSeat` returns `false` without changing the reservation.
// 5. An invalid seat number must throw `ArgumentOutOfRangeException`.

public class SeatReservation
{
    private readonly bool[] _reservedSeats;

    public SeatReservation(int seatCount)
    {
        if(seatCount <= 0)
        {
            throw new ArgumentOutOfRangeException("number of seats can't be zero");
        }
        _reservedSeats = new bool[seatCount];
        
    }

    public bool ReserveSeat(int seatNumber)
    {
        if(seatNumber <= 0 || seatNumber > _reservedSeats.Length)
        {
            throw new ArgumentOutOfRangeException("The sit number is invalid");
        }
        
        for(int i = 0; i <= _reservedSeats.Length - 1 ; i++)
        {
            var reservedSeat = _reservedSeats[seatNumber - 1] == true;

            if(reservedSeat)
            {
                return false;
            }
            else 
            {
                _reservedSeats[seatNumber - 1] = true;
                return true;
            }
            
        }

        return false;
    }

    public int GetAvailableSeatCount()
    {

        return _reservedSeats.Count(reserved => !reserved);
        
        
    }
}