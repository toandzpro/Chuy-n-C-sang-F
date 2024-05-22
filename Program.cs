using System.Text;

public class Bài1
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập nhiệt độ (độ C): ");
        string a = Console.ReadLine();
        double C;
        if (double.TryParse(a, out C)) // chuyển đỗi tryparse thành double
        {
            double F = C * 9 / 5 + 32;
            Console.WriteLine($"Nhiệt độ tương đương (độ F): {F}");
        }
        else
        {
            Console.WriteLine("Đầu vào không hợp lệ. Vui lòng nhập một số.");
        }
    }

}