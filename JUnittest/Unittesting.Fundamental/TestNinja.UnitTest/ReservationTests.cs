using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestNinja.UnitTest
{
    [TestClass]
    public class ReservationTests
    {
        private bool result;

        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //arrange
            var reservation = new Reservation();
            //act
            reservation.CanBeCancelledBy(new User { CanBeCancelledBy_UserIsAdmin_ReturnsTrue = true });

            //assert

            Assert.IsTrue(result);
        }

        [TestMethod]

        public void CanBeCancelledBy_SameUserCancellingTheReservation_ReturnTrue()
        {
            var user = new User();
            var reservation = new Reservation { MadeBy = user };

            var result= reservation.CanBeCancelledBy(user);

            Assert.IsTrue(result);
        }


        private class Reservation
        {
            public User MadeBy { get; set; }

            internal object CanBeCancelledBy(User user)
            {
                throw new NotImplementedException();
            }
        }
    }

    internal class User
    {
        public bool CanBeCancelledBy_UserIsAdmin_ReturnsTrue { get; set; }
    }

    

        internal void CanBeCancelledBy(User user)
        {
            throw new NotImplementedException();
        }
    }
