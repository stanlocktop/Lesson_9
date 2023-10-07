class Program
{
    static void Main(string[] args)
    {
        // ����� � �������� ������������. 
        1) ���������: ������� ���� �� ������ Rectangle.

        //� �� ����� ������� ��� ����, �� �������� ������� ����� side1, side2. ������� ����������� ����������� Rectangle(double side1, double side2), � �� ����� ���� side1 � side2 ������������� ���������� ���������. ������� ��� ������, �� ���������� ����� ������������ -double AreaCalculator() � �������� ������������ - double PerimeterCalculator().

        //������� ���������� double Area �� double Perimeter �� ��������� ������ ������ get.�������� ��������, ��� ������ �� ����������� ������� ���� ����� ������������ �� �������� �������� � ����� �� �����.
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.Write("������ ������� ������� 1: ");
        double side1 = double.Parse(Console.ReadLine());

        Console.Write("������ ������� ������� 2: ");
        double side2 = double.Parse(Console.ReadLine());

        Rectangle rectangle = new Rectangle(side1, side2);

        Console.WriteLine($"�������� ������������: {rectangle.Perimeter}");
        Console.WriteLine($"����� ������������: {rectangle.Area}");

        Console.WriteLine("\n������ ��� �����������:");
        // 2) �������� ���� User, �� ������ ���������� ��� ����������� (����, ��'�, �������, ��, ���� ���������� ������). ���� ���� ���������� ������ �� ���� �������������� ���� ���� ��� (��� �������� ���������� ����� �����) ��� ��������� ���� �������� ����. ��������� ��������� �� ����� ���������� ��� �����������.
        Console.Write("����: ");
        string login = Console.ReadLine();

        Console.Write("��'�: ");
        string firstName = Console.ReadLine();

        Console.Write("�������: ");
        string lastName = Console.ReadLine();

        Console.Write("³�: ");
        int age = int.Parse(Console.ReadLine());

        User user = new User(login, firstName, lastName, age);

        Console.WriteLine("\n���������� ��� �����������:");
        user.DisplayUserInfo();
        Console.ReadKey();
    }
}