using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan1_Lab1_BT4_Hao
{

    class ConNguoi
    {
        String hoten;
        DateTime namsinh;
        string bangcap;



        public ConNguoi()
        {
            hoten = ""
; namsinh = new DateTime();
            bangcap = "";

        }

        public ConNguoi(string hoten, DateTime namsinh, string bangcap)
        {
            this.hoten = hoten;
            this.namsinh = namsinh;
            this.bangcap = bangcap;
        }



        public string Hoten { get => hoten; set => hoten = value; }
        public DateTime Namsinh { get => namsinh; set => namsinh = value; }
        public string Bangcap { get => bangcap; set => bangcap = value; }


        public void Input()
        {
            Console.Write("Nhập họ tên: ");
            hoten = Console.ReadLine();
            Console.Write("Nhập năm sinh: ");
            namsinh = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Nhập bằng cấp: ");
            bangcap = Console.ReadLine();
        }
        public void Output()
        {
            Console.WriteLine("Họ tên: " + hoten);
            Console.WriteLine("Năm sinh: " + namsinh);
            Console.WriteLine("Bằng cấp: " + bangcap);

        }
    }
    class Luong : ConNguoi
    {
        string chucvu;
        int snc;
        int bacluong;


        public Luong()
        {
            chucvu = "";
            snc = 0;
            bacluong = 0;
        }
        public Luong(string hoten, DateTime namsinh, string bangcap, string chucvu, int snc, int bacluong) : base(hoten, namsinh, bangcap)
        {
            this.chucvu = chucvu;
            this.snc = snc;
            this.bacluong = bacluong;

        }
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public int Snc { get => snc; set => snc = value; }
        public int Bacluong { get => bacluong; set => bacluong = value; }

        public void Input()
        {
            base.Input();
            Console.Write("Nhập chức vụ ");
            chucvu = Console.ReadLine();
            Console.Write("Nhập số ngày công trong tháng: ");
            Snc = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập bậc lương ");
            Bacluong = Convert.ToInt32(Console.ReadLine());
        }
        public void Output()
        {
            base.Output();
            Console.WriteLine("Chức vụ: " + chucvu);
            Console.WriteLine("Số ngày công trong tháng: " + Snc);
            Console.WriteLine("Bậc lương: " + Bacluong);
            Console.WriteLine("Tổng lương: " + TongLuong());




        }
        public float TongLuong()
        {
            return bacluong * snc;
        }


    }
    class NhaKhoaHoc : Luong
    {
        int sbbc;


        public NhaKhoaHoc()
        {
            sbbc = 0;

        }

        public NhaKhoaHoc(string hoten, DateTime namsinh, string bangcap, string chucvu, int sbbc, int snc, int bacluong) : base(hoten, namsinh, bangcap, chucvu, snc, bacluong)
        {
            this.sbbc = sbbc;

        }
        public void Input()
        {
            base.Input();
            Console.Write("Nhập số bài báo cáo đã công bố: ");
            sbbc = Convert.ToInt32(Console.ReadLine());


        }
        public void Output()
        {
            base.Output();
            Console.WriteLine("Số bài báo cáo đã công bố: " + sbbc);
            Console.WriteLine();

        }
    }
    class NhaQuanLy : Luong
    {
        public NhaQuanLy()
        {
        }

        public NhaQuanLy(string hoten, DateTime namsinh, string bangcap, string chucvu, int sbbc, int snc, int bacluong) : base(hoten, namsinh, bangcap, chucvu, snc, bacluong)

        {


        }
        public void Intput()
        {
            base.Input();
        }
        public void Output()
        {
            base.Output();
            Console.WriteLine();



        }

    }
    class NVPThiNghiem : ConNguoi
    {
        float luong;
        public NVPThiNghiem()
        {
            luong = 0;
        }



        public NVPThiNghiem(string hoten, DateTime namsinh, string bangcap, float luong) : base(hoten, namsinh, bangcap)
        {

            this.luong = luong;
        }
        public void Input()
        {
            base.Input();
            Console.Write("Nhập lương trong tháng: ");
            luong = float.Parse(Console.ReadLine());


        }
        public void Output()
        {
            base.Output();
            Console.WriteLine("Lương trong tháng: " + luong);
            Console.WriteLine();


        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            List<NhaKhoaHoc> listKH = new List<NhaKhoaHoc>();
            List<NhaQuanLy> listQL = new List<NhaQuanLy>();
            List<NVPThiNghiem> listPTN = new List<NVPThiNghiem>();

            int chose;
            do
            {
                Console.Write("\n1. Nhập 1 Nhà khoa học");
                Console.Write("\n2. Nhập 1 Nhà quản lý");
                Console.Write("\n3. Nhập 1 nhân viên phòng thí nghiệm");
                Console.Write("\n4. Xuất danh sách nhà khoa học");
                Console.Write("\n5. Xuất danh sách nhà quản lý");
                Console.Write("\n6. Xuất danh sách nhân viên phòng thí nghiệm");
                Console.Write("\n0. Thoát");
                Console.Write("\nChọn chức năng: ");
                chose = Convert.ToInt32(Console.ReadLine());
                switch (chose)
                {
                    case 1:
                        NhaKhoaHoc kh = new NhaKhoaHoc();
                        kh.Input();
                        listKH.Add(kh);
                        break;
                    case 2:
                        NhaQuanLy ql = new NhaQuanLy();
                        ql.Input();
                        listQL.Add(ql);
                        break;
                    case 3:
                        NVPThiNghiem tn = new NVPThiNghiem();
                        tn.Input();
                        listPTN.Add(tn);
                        break;
                    case 4:
                        foreach (NhaKhoaHoc k in listKH)
                        {
                            k.Output();
                        }
                        break;
                    case 5:
                        foreach (NhaQuanLy q in listQL)
                        {
                            q.Output();
                        }
                        break;
                    case 6:
                        foreach (NVPThiNghiem n in listPTN)
                        {
                            n.Output();
                        }
                        break;
                    default:
                        chose = 0;
                        break;
                }

            } while (chose != 0);

        }
    }
}
