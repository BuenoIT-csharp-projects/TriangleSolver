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

        [Test]
        public void Triangle_Isosceles_1_Valid()
        {
            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";
            Triangle t1 = new Triangle();
            string actual = t1.AnalyzeTriangle(3, 3, 5);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Triangle_Isosceles_2_Valid()
        {
            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";
            Triangle t1 = new Triangle();
            string actual = t1.AnalyzeTriangle(3, 5, 3);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Triangle_Isosceles_3_Valid()
        {
            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";
            Triangle t1 = new Triangle();
            string actual = t1.AnalyzeTriangle(5, 3, 3);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Triangle_Scalene_1_Valid()
        {
            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            Triangle t1 = new Triangle();
            string actual = t1.AnalyzeTriangle(2, 3, 4);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Triangle_Scalene_2_Valid()
        {
            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            Triangle t1 = new Triangle();
            string actual = t1.AnalyzeTriangle(4, 3, 2);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Triangle_Scalene_3_Valid()
        {
            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            Triangle t1 = new Triangle();
            string actual = t1.AnalyzeTriangle(6, 4, 5);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Triangle_Scalene_4_Valid()
        {
            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            Triangle t1 = new Triangle();
            string actual = t1.AnalyzeTriangle(5, 4, 6);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Triangle_Scalene_5_Valid()
        {
            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            Triangle t1 = new Triangle();
            string actual = t1.AnalyzeTriangle(7, 10, 6);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Triangle_Zero_Length_1_Valid()
        {
            string expected = "Based on the values entered, the triangle is INVALID";
            Triangle t1 = new Triangle();
            string actual = t1.AnalyzeTriangle(6, 0, 6);
            Assert.AreEqual(expected, actual);
        }
    }
}