using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskLib;

namespace UnitTestLib
{

    [TestClass]
    public class MeetingRoomsTest
    {
        [TestMethod]
        public void CanAttendMeetingTest1()
        {
            var input = new[]
            {
                new int[] {0, 30},
                new int[] {5, 10},
                new int[] {15, 20}};

            const bool result = false;

            Assert.AreEqual(result, MeetingRooms.CanAttendMeeting(input));
        }

        [TestMethod]
        public void CanAttendMeetingTest2()
        {
            var input = new[]
            {
                new int[] {17, 10},
                new int[] {2, 4}};

            const bool result = true;

            Assert.AreEqual(result, MeetingRooms.CanAttendMeeting(input));
        }

        [TestMethod]
        public void CanAttendMeetingTest3()
        {
            var input = new[]
            {
                new int[] {2, 10},
                new int[] {3, 4},
                new int[] {6, 9}};

            const bool result = false;

            Assert.AreEqual(result, MeetingRooms.CanAttendMeeting(input));
        }

        [TestMethod]
        public void MaxPeopleNumberTest1()
        {
            var input = new[]
            {
                new int[] {2, 10},
                new int[] {3, 4},
                new int[] {6, 9}
            };

            const int result = 2;

            Assert.AreEqual(result, MeetingRooms.MaxPeopleNumber(input));
        }

        [TestMethod]
        public void MaxPeopleNumberTest2()
        {
            var input = new[]
            {
                new int[] {1, 3},
                new int[] {2, 4},
                new int[] {2, 5},
                new int[] {3, 4},
                new int[] {3, 6},
                new int[] {4, 5},
                new int[] {5, 6}
            };

            const int result = 4;

            Assert.AreEqual(result, MeetingRooms.MaxPeopleNumber(input));
        }

        [TestMethod]
        public void MaxPeopleNumberTest3()
        {
            var input = new[]
            {
                new int[] {1, 8},
                new int[] {2, 7},
                new int[] {3, 5},
                new int[] {5, 7},
                new int[] {6, 7},
                new int[] {6, 8},
                new int[] {7, 8},
            };

            const int result = 5;

            Assert.AreEqual(result, MeetingRooms.MaxPeopleNumber(input));
        }

    }
}