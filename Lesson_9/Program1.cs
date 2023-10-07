class Program
{
    static void Main(string[] args)
    {
        // площа і периметр прямокутника. 
        1) Необхідно: створіть клас під назвою Rectangle.

        //У тілі класу створіть два поля, які описують довжини сторін side1, side2. Створіть спеціальний конструктор Rectangle(double side1, double side2), у тілі якого поля side1 і side2 ініціалізуються значеннями аргументів. Створіть два методи, які обчислюють площу прямокутника -double AreaCalculator() і периметр прямокутника - double PerimeterCalculator().

        //Створіть властивості double Area та double Perimeter за допомогою одного методу get.Напишіть програму, яка приймає від користувача довжину двох сторін прямокутника та відображає периметр і площу на екрані.
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.Write("Введіть довжину сторони 1: ");
        double side1 = double.Parse(Console.ReadLine());

        Console.Write("Введіть довжину сторони 2: ");
        double side2 = double.Parse(Console.ReadLine());

        Rectangle rectangle = new Rectangle(side1, side2);

        Console.WriteLine($"Периметр прямокутника: {rectangle.Perimeter}");
        Console.WriteLine($"Площа прямокутника: {rectangle.Area}");

        Console.WriteLine("\nВведіть дані користувача:");
        // 2) Створити клас User, що містить інформацію про користувача (логін, ім'я, прізвище, вік, дату заповнення анкети). Поле дата заповнення анкети має бути проініціалізоване лише один раз (при створенні екземпляра цього класу) без можливості його подальшої зміни. Реалізуйте виведення на екран інформації про користувача.
        Console.Write("Логін: ");
        string login = Console.ReadLine();

        Console.Write("Ім'я: ");
        string firstName = Console.ReadLine();

        Console.Write("Прізвище: ");
        string lastName = Console.ReadLine();

        Console.Write("Вік: ");
        int age = int.Parse(Console.ReadLine());

        User user = new User(login, firstName, lastName, age);

        Console.WriteLine("\nІнформація про користувача:");
        user.DisplayUserInfo();
        Console.ReadKey();
    }
}