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
            // Используйте подключение к тестовой базе данных (или создайте ее на лету)
            connectionString = "Data Source=(local);Initial Catalog=TestDB;Integrated Security=True";
        }

        [Test]
        public void Test_Button_b2_Click()
        {
            try
            {
                // Создание экземпляра страницы AddResPage
                var addResPage = new AddResPage("09.06.2023", "14:00", 1);

                // Установка значений параметров для выполнения метода b2_Click
                addResPage.t1.Text = "Иванов Иван";
                addResPage.t2.Text = "1234567890";
                addResPage.t4.Text = "14:00";
                addResPage.combo.Text = "Ожидает";
                addResPage.t6.Text = "1";
                addResPage.dp.SelectedDate = Convert.ToDateTime("09.06.2023");

                // Выполнение метода b2_Click
                addResPage.b2_Click(new object(), new RoutedEventArgs());

                // Проверка отсутствия исключений
                Assert.Pass();
            }
            catch (Exception ex)
            {
                // Если возникло исключение, вывести его сообщение в консоли теста и пометить тест как неудачный
                Console.WriteLine(ex.ToString());
                Assert.Fail();
            }
        }
    }
}