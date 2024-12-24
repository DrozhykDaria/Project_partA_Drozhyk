using Project_partA_Drozhyk_report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    namespace SchoolTests
    {
        [TestClass]
        public class ScheduleEntryTests
        {
            [TestMethod]
            public void GetDetails_ShouldThrowNotImplementedException()
            {
                var scheduleEntry = new ScheduleEntry();
                Assert.ThrowsException<NotImplementedException>(() => scheduleEntry.GetDetails());
            }
        }
    }
}
