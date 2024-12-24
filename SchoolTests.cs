using Project_partA_Drozhyk_report;

namespace SchoolTests
{
    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        public void AddClassroom_ShouldThrowNotImplementedException()
        {
            var school = new School();
            Assert.ThrowsException<NotImplementedException>(() => school.AddClassroom(null));
        }

        [TestMethod]
        public void CreateSchedule_ShouldThrowNotImplementedException()
        {
            var school = new School();
            var scheduleEntry = new ScheduleEntry();
            Assert.ThrowsException<NotImplementedException>(() => school.CreateSchedule(scheduleEntry));
        }
    }
}
