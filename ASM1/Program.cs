using System;
using System.Collections;
using System.IO;

namespace ASM1
{
    class SinhVien
    {
        private string maSV;
        private string hoTen;
        private string ngaySinh;
        private string diaChi;
        private string dienThoai;

        //Constructors khong co tham so
        public SinhVien()
        {
            MaSV = "SE141059";
            HoTen = "PhamManhDung";
            NgaySinh = "5/8/2000";
            DiaChi = "Quan2";
            DienThoai = "034316";
        }
        //Constructors voi tham so
        public SinhVien(string id, string name, string date, string adr, string phone)
        {
            this.maSV = id;
            this.hoTen = name;
            this.ngaySinh = date;
            this.diaChi = adr;
            this.dienThoai = phone;
        }

        //Cac properties (set, get)

        public string MaSV { get => maSV; set => maSV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }

        public void XemThongTin()
        {
            //Xuat thong tin cac sinh vien//
            Console.WriteLine("MaSinhVien: " + MaSV);
            Console.WriteLine("HoTen: " + HoTen);
            Console.WriteLine("NgaySinh: " + NgaySinh);
            Console.WriteLine("DiaChi: " + DiaChi);
            Console.WriteLine("DienThoai: " + DienThoai);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList DSSV = new ArrayList(50);
            DSSV.Add(new SinhVien());
            int stop;
            do
            {
                int choice;
                Console.WriteLine("*********************************");
                Console.WriteLine("1. Hien thi danh sach sinh vien");
                Console.WriteLine("2. Them sinh vien");
                Console.WriteLine("3. Tim sinh vien");
                Console.WriteLine("4. Cap nhat sinh vien");
                Console.WriteLine("5. Thoat");
                Console.Write("Chon 1 den 5: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            foreach (SinhVien sinhVien in DSSV)
                                sinhVien.XemThongTin();
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Nhap danh sach sinh vien.");
                            Console.Write("Nhap MaSV: ");
                            string id = Console.ReadLine();
                            foreach(SinhVien sinhVien in DSSV)
                            {
                                if(id == sinhVien.MaSV)
                                {
                                    Console.WriteLine("Trung ma sinh vien!");
                                }
                                else
                                {
                                    Console.Write("Ho ten SV: ");
                                    string name = Console.ReadLine();
                                    Console.Write("Ngay sinh: ");
                                    string date = Console.ReadLine();
                                    Console.Write("Dia chi: ");
                                    string adr = Console.ReadLine();
                                    Console.Write("Dien thoai: ");
                                    string phone = Console.ReadLine();
                                    DSSV.Add(new SinhVien(id, name, date, adr, phone));
                                    Console.WriteLine("Da them sinh vien!");
                                }
                                break;
                            }
                        }
                        break;
                    case 3:
                        {
                            Console.Write("Nhap Ma SV ban muon tim: ");
                            string mssv = Console.ReadLine();
                            foreach (SinhVien sinhVien in DSSV)
                            {
                                if (mssv == sinhVien.MaSV)
                                {
                                    sinhVien.XemThongTin();
                                }
                                else
                                {
                                    Console.WriteLine("Khong tim thay sinh vien ma " + mssv);
                                }
                            }
                        }
                        break;
                    case 4:
                        {
                            Console.Write("Nhap ma sinh vien can cap nhat: ");
                            string cn = Console.ReadLine();
                            foreach (SinhVien sinhvien in DSSV)
                            {
                                if (cn == sinhvien.MaSV)
                                {
                                    Console.Write("Nhap ho va ten sv moi: ");
                                    string nname = Console.ReadLine();
                                    sinhvien.HoTen = nname;

                                    Console.Write("Nhap ngay sinh moi: ");
                                    string ndate = Console.ReadLine();
                                    sinhvien.NgaySinh = ndate;

                                    Console.Write("Nhap dia chi moi: ");
                                    string nadr = Console.ReadLine();
                                    sinhvien.DiaChi = nadr;

                                    Console.Write("Nhap so dien thoai moi: ");
                                    string nphone = Console.ReadLine();
                                    sinhvien.DienThoai = nphone;
                                    
                                    Console.Write("Da cap nhat sinh vien: ");

                                }
                                else
                                {
                                    Console.Write("Khong tim thay sinh vien");
                                }
                            }
                        }
                        break;
                    case 5:
                        Console.Write("Thoat");
                        break;
                }
                Console.Write("nhan 1 de tiep tuc, 0 de thoat: ");
                stop = int.Parse(Console.ReadLine());
            } while (stop != 0);
            //1. xem danh sach sinh vien
            //2. them sinh vien
            //3. tim sinh vien
            //4. cap nhat thong tin sinh vien



            
        }
    }
}
