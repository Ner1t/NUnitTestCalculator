using NUnit.Framework;


namespace NUnitTestCalculator
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            

             for (double x = 1 ; x <= 20; x++)
             {
                for (double y = 1 ; y <= 20; y++)
                {
                    //double x = 2;
                    //double y = 14;
                    Calculator.Methods k = new Calculator.Methods();
                    k.addition(x, y);
                    var s = k.addition(x, y);
                    Assert.IsTrue(x + y == s, "���������� x= {0}, y= {1}, ����� ����� �����:{2} � ������ ���� ����� {3}", x, y, s, x + y);

                    k.difference(x, y);
                    var o = k.difference(x, y);
                    Assert.IsTrue(x - y == o, "���������� x= {0}, y= {1}, �������� ����� �����:{2} � ������ ���� ����� {3}", x, y, o, x - y);

                    k.division(x, y);
                    var d = k.division(x, y);

                    if (y == 0)
                    { Assert.Pass(); }
                    else
                    {
                        Assert.IsTrue(x / y == d, "���������� x= {0}, y= {1}, ��������� ������� ����� �����:{2} � ������ ���� ����� {3}", x, y, d, x / y);
                    }


                    k.multiplication(x, y);
                    var m = k.multiplication(x, y);
                    Assert.IsTrue(x * y == m, "���������� x= {0}, y= {1}, ��������� ��������� ����� �����:{2} � ������ ���� ����� {3}", x, y, d, x * y);
                }
             }
            
        }

    }
}