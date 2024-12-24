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
        public class StudentTests
        {
            [TestMethod]
            public void EnrollSubject_ShouldThrowNotImplementedException()
            {
                var student = new Student();
                Assert.ThrowsException<NotImplementedException>(() => student.EnrollSubject(Subject.Math));
            }
        }
    }
}
