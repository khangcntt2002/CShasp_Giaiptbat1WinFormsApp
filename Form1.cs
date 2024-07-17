namespace CShasp_Giaiptbat1WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Hello, Chào các bạn nha !");
        Console.WriteLine("ứng dụng giải PT Bật 1");


        double a, b;
        Console.WriteLine("Hãy nhập a : ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Hãy nhập b : ");
        b = Convert.ToDouble(Console.ReadLine());

        string ketqua = GiaiPTBat1(a, b);
        Console.WriteLine($"ứng dụng giải PT Bật 1 {ketqua} ");


    }
    /// <summary>
    /// Hàm giải phương trình bật 1
    /// </summary>
    /// <param name="a">Đổi số a kiểu double</param>
    /// <param name="b">Đổi số b kiểu double</param>
    /// <returns>chuỗi kết quả</returns>
    private static string GiaiPTBat1(double a, double b)
    {
        //
        if (a == 0)
        {
            if (b == 0)
            {
                return "phương trình có vô số nghiệm";

            }
            else
            {
                return "phương trình vô nghiệm";
            }

        }
        else
        {
            return "phương trình có 1 nghiệm là: " + (-b / a).ToString();
        }
    }

}



