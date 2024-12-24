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
        public class TeacherTests
        {
            [TestMethod]
            public void AssignSubject_ShouldThrowNotImplementedException()
            {
                var teacher = new Teacher();
                Assert.ThrowsException<NotImplementedException>(() => teacher.AssignSubject(Subject.Math));
            }
        }
    }
}
