using System;
using Newtonsoft.Json; // Cần cài đặt thư viện Newtonsoft.Json

class Program
{
    // Hàm tính toán thông tin hình tròn và trả về JSON string
    static string CalculateCircle(double r)
    {
        double dien_tich = Math.PI * Math.Pow(r, 2);
        double chu_vi = 2 * Math.PI * r;
        double duong_kinh = 2 * r;

        var result = new
        {
            dien_tich = Math.Round(dien_tich, 2),
            chu_vi = Math.Round(chu_vi, 2),
            duong_kinh = Math.Round(duong_kinh, 2)
        };

        return JsonConvert.SerializeObject(result);
    }

    // Hàm chính
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        double r;

        while (true)
        {
            Console.Write("Nhập bán kính hình tròn (r): ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out r) && r > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Vui lòng nhập vào một số hợp lệ lớn hơn 0.");
            }
        }

        string resultJson = CalculateCircle(r);
        Console.WriteLine("Kết quả tính toán (JSON): ");
        Console.WriteLine(resultJson);
    }
}
