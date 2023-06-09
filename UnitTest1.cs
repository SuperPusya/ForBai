using NUnit.Framework;
using WpfApp1;

namespace TestProject1
{
    public class AddResPageTests
    {
        private string connectionString;

        [SetUp]
        public void Setup()
        {
            // ����������� ����������� � �������� ���� ������ (��� �������� �� �� ����)
            connectionString = "Data Source=(local);Initial Catalog=TestDB;Integrated Security=True";
        }

        [Test]
        public void Test_Button_b2_Click()
        {
            try
            {
                // �������� ���������� �������� AddResPage
                var addResPage = new AddResPage("09.06.2023", "14:00", 1);

                // ��������� �������� ���������� ��� ���������� ������ b2_Click
                addResPage.t1.Text = "������ ����";
                addResPage.t2.Text = "1234567890";
                addResPage.t4.Text = "14:00";
                addResPage.combo.Text = "�������";
                addResPage.t6.Text = "1";
                addResPage.dp.SelectedDate = Convert.ToDateTime("09.06.2023");

                // ���������� ������ b2_Click
                addResPage.b2_Click(new object(), new RoutedEventArgs());

                // �������� ���������� ����������
                Assert.Pass();
            }
            catch (Exception ex)
            {
                // ���� �������� ����������, ������� ��� ��������� � ������� ����� � �������� ���� ��� ���������
                Console.WriteLine(ex.ToString());
                Assert.Fail();
            }
        }
    }
}