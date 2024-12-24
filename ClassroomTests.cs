using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_partA_Drozhyk_report;

namespace TestProject1
{
    
    namespace SchoolTests
    {
        [TestClass]
        public class ClassroomTests
        {
            [TestMethod]
            public void GetSchedule_ShouldThrowNotImplementedException()
            {
                var classroom = new ClassroomTests();
                Assert.ThrowsException<NotImplementedException>(() => classroom.GetSchedule_ShouldThrowNotImplementedException());
            }
        }
    }
}
