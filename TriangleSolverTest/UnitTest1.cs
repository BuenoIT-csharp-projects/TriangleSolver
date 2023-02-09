using TriangleSolver;
using NUnit.Framework;

namespace TriangleSolverTest
{
    public class UnitTest1
    {
        [Test]
        public void Triangle_Equilateral_Valid()
        {
            string expected = "Based on all sides being equal, the type of triangle is an EQUILATERAL";
            Triangle t1 = new Triangle();
            string actual = t1.AnalyzeTriangle(3,3,3);
            Assert.AreEqual(expected, actual);
        }
    }
}