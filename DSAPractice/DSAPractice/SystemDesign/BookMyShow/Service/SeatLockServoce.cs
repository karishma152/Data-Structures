using DSAPractice.SystemDesign.BookMyShow.Enums;
using DSAPractice.SystemDesign.BookMyShow.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.SystemDesign.BookMyShow.Service
{
    public class SeatLockService
    {
        public bool LockSeat(ShowSeat seat)
        {
            if (seat.Status != SeatStatusEnum.Available)
            {
                return false;
            }

            seat.Status = SeatStatusEnum.Locked;

            return true;
        }

        public void UnlockSeat(ShowSeat seat)
        {
            seat.Status = SeatStatusEnum.Available;
        }

        public void ConfirmSeat(ShowSeat seat)
        {
            seat.Status = SeatStatusEnum.Booked;
        }
    }
}
