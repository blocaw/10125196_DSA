using System;
using System.Collections.Generic;

namespace Buoi02_DanhSach 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            // ================= CHƯƠNG 4: MẢNG VÀ DANH SÁCH LIÊN KẾT =================
            Console.WriteLine("=== Chương 4 - Bài 1: Nhập, xuất và chèn phần tử vào mảng ===");
            Bai1_Chuong4();

            Console.WriteLine("\n=== Chương 4 - Bài 2: Quản lý danh sách nhân viên ===");
            Bai2_Chuong4();

            Console.WriteLine("\n=== Chương 4 - Bài 3: Xử lý ma trận vuông ===");
            Bai3_Chuong4();

            Console.WriteLine("\n=== Chương 4 - Bài 4: Danh sách liên kết đơn (số dương) ===");
            Bai4_Chuong4();

            Console.WriteLine("\n=== Chương 4 - Bài 5: Danh sách liên kết đơn (số nguyên) ===");
            Bai5_Chuong4();

            // ================= CHƯƠNG 5: STACK VÀ QUEUE =================
            Console.WriteLine("\n=== Chương 5 - Bài 1: Kiểm tra tính hợp lệ của dấu ngoặc ===");
            Bai1_Chuong5();

            Console.WriteLine("\n=== Chương 5 - Bài 2: Mô phỏng lịch sử trình duyệt (Back/Forward) ===");
            Bai2_Chuong5();

            Console.WriteLine("\n=== Chương 5 - Bài 3: Mô phỏng ngăn xếp lời gọi hàm ===");
            Bai3_Chuong5();

            Console.WriteLine("\n=== Chương 5 - Bài 4: Mô phỏng hàng đợi in ấn ===");
            Bai4_Chuong5();

            Console.WriteLine("\n=== Chương 5 - Bài 5: Mô phỏng hàng đợi gói tin ===");
            Bai5_Chuong5();

            Console.WriteLine("\n=== Chương 5 - Bài 6: Mô phỏng hàng đợi phục vụ khách hàng ===");
            Bai6_Chuong5();

            // ================= CHƯƠNG 6: CÂY NHỊ PHÂN =================
            Console.WriteLine("\n=== Chương 6 - Bài 1: Đếm số nút trên cây ===");
            Bai1_Chuong6();

            Console.WriteLine("\n=== Chương 6 - Bài 2: Tính tổng giá trị các nút ===");
            Bai2_Chuong6();

            Console.WriteLine("\n=== Chương 6 - Bài 3: Hiển thị các nút (NLR) ===");
            Bai3_Chuong6();

            Console.WriteLine("\n=== Chương 6 - Bài 4: Hiển thị các nút chẵn ===");
            Bai4_Chuong6();

            Console.WriteLine("\n=== Chương 6 - Bài 5: Đếm số nút chẵn ===");
            Bai5_Chuong6();

            Console.WriteLine("\n=== Chương 6 - Bài 6: Tìm nút và đếm số con trực tiếp ===");
            Bai6_Chuong6();

            Console.WriteLine("\n=== Chương 6 - Bài 7: Hiển thị cây con trái ===");
            Bai7_Chuong6();

            Console.WriteLine("\n=== Chương 6 - Bài 8: Duyệt cây theo 3 thứ tự NLR, LNR, LRN ===");
            Bai8_Chuong6();
        }

        // ===== CHƯƠNG 4 =====
        static void Bai1_Chuong4()
        {
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0) { Console.WriteLine("n phải dương"); return; }
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "] = ");
                a[i] = int.Parse(Console.ReadLine());
                if (a[i] <= 0) { Console.WriteLine("Phải nhập số dương"); i--; }
            }
            Console.WriteLine("Dãy ban đầu: " + string.Join(" ", a));
            Console.Write("Nhập x: "); int x = int.Parse(Console.ReadLine());
            Console.Write("Nhập vị trí k (0 đến n): "); int k = int.Parse(Console.ReadLine());
            if (k < 0 || k > n) { Console.WriteLine("Vị trí không hợp lệ"); return; }
            int[] tmp = new int[n + 1];
            for (int i = 0; i < k; i++) tmp[i] = a[i];
            tmp[k] = x;
            for (int i = k; i < n; i++) tmp[i + 1] = a[i];
            a = tmp;
            Console.WriteLine("Dãy sau khi chèn: " + string.Join(" ", a));
        }

        struct NhanVien
        {
            public string MaNV, HoTen, PhongBan;
            public int NamSinh, LuongCB, Thuong;
            public int ThucLinh() { return LuongCB + Thuong; }
        }

        static void InNhanVien(NhanVien nv)
        {
            Console.WriteLine(nv.MaNV + " | " + nv.HoTen + " | " + nv.NamSinh + " | " + nv.PhongBan + " | Lương: " + nv.LuongCB + " | Thưởng: " + nv.Thuong + " | Thực lĩnh: " + nv.ThucLinh());
        }

        static void Bai2_Chuong4()
        {
            Console.Write("Số nhân viên: "); int n = int.Parse(Console.ReadLine());
            if (n <= 0) return;
            NhanVien[] ds = new NhanVien[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhân viên " + (i + 1));
                Console.Write("Mã: "); ds[i].MaNV = Console.ReadLine();
                Console.Write("Họ tên: "); ds[i].HoTen = Console.ReadLine();
                Console.Write("Năm sinh: "); ds[i].NamSinh = int.Parse(Console.ReadLine());
                Console.Write("Phòng ban: "); ds[i].PhongBan = Console.ReadLine();
                Console.Write("Lương cơ bản: "); ds[i].LuongCB = int.Parse(Console.ReadLine());
                Console.Write("Thưởng: "); ds[i].Thuong = int.Parse(Console.ReadLine());
            }

            long tong = 0;
            for (int i = 0; i < n; i++) tong += ds[i].ThucLinh();
            Console.WriteLine("a. Tổng thực lĩnh: " + tong);

            int min = ds[0].LuongCB;
            for (int i = 1; i < n; i++) if (ds[i].LuongCB < min) min = ds[i].LuongCB;
            Console.WriteLine("b. Nhân viên lương cơ bản thấp nhất:");
            foreach (NhanVien nv in ds) if (nv.LuongCB == min) InNhanVien(nv);

            int dem = 0;
            foreach (NhanVien nv in ds) if (nv.Thuong >= 1200000) dem++;
            Console.WriteLine("c. Số nhân viên thưởng >= 1200000: " + dem);

            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                    if (string.Compare(ds[i].PhongBan, ds[j].PhongBan, StringComparison.CurrentCulture) > 0 ||
                       (ds[i].PhongBan == ds[j].PhongBan && string.Compare(ds[i].MaNV, ds[j].MaNV, StringComparison.Ordinal) < 0))
                    { NhanVien t = ds[i]; ds[i] = ds[j]; ds[j] = t; }
            Console.WriteLine("d. Danh sách sau sắp xếp:");
            foreach (NhanVien nv in ds) InNhanVien(nv);

            Console.WriteLine("e. Tăng lương cơ bản 5%:");
            for (int i = 0; i < n; i++)
            {
                ds[i].LuongCB = (int)Math.Round(ds[i].LuongCB * 1.05, MidpointRounding.AwayFromZero);
                InNhanVien(ds[i]);
            }
        }

        static void Bai3_Chuong4()
        {
            Console.Write("Nhập n (1..99): "); int n = int.Parse(Console.ReadLine());
            if (n <= 0 || n >= 100) return;
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                { Console.Write("a[" + i + "," + j + "] = "); a[i, j] = int.Parse(Console.ReadLine()); }

            long tong = 0, cheoPhu = 0;
            int minDuong = int.MaxValue;
            bool tang = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    tong += a[i, j];
                    if (a[i, j] > 0 && a[i, j] < minDuong) minDuong = a[i, j];
                }
                cheoPhu += a[i, n - 1 - i];
                if (i > 0 && a[i, i] <= a[i - 1, i - 1]) tang = false;
            }
            Console.WriteLine("a. Tổng = " + tong);
            Console.WriteLine("b. Dương nhỏ nhất = " + (minDuong == int.MaxValue ? "Không có" : minDuong.ToString()));
            Console.WriteLine("c. Tổng đường chéo phụ = " + cheoPhu);
            Console.WriteLine("d. Đường chéo chính tăng nghiêm ngặt: " + (tang ? "Có" : "Không"));
        }

        class NutDS
        {
            public int GiaTri;
            public NutDS Tiep;
            public NutDS(int x) { GiaTri = x; }
        }

        static NutDS NhapDanhSach(bool chiDuong)
        {
            Console.Write("Số phần tử: "); int n = int.Parse(Console.ReadLine());
            NutDS dau = null, cuoi = null;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phần tử " + (i + 1) + ": "); int x = int.Parse(Console.ReadLine());
                if (chiDuong && x <= 0) { Console.WriteLine("Phải là số dương"); i--; continue; }
                NutDS moi = new NutDS(x);
                if (dau == null) dau = moi; else cuoi.Tiep = moi;
                cuoi = moi;
            }
            return dau;
        }

        static void InDanhSach(NutDS dau)
        {
            for (NutDS p = dau; p != null; p = p.Tiep) Console.Write(p.GiaTri + " ");
            Console.WriteLine();
        }

        static void Bai4_Chuong4()
        {
            NutDS dau = NhapDanhSach(true);
            Console.Write("Nhập x: "); int x = int.Parse(Console.ReadLine());
            int dem = 0, min = int.MaxValue;
            for (NutDS p = dau; p != null; p = p.Tiep)
            { if (p.GiaTri == x) dem++; if (p.GiaTri < min) min = p.GiaTri; }
            Console.WriteLine("a. Số lần xuất hiện của x: " + dem);
            Console.WriteLine("b. Số dương nhỏ nhất: " + (min == int.MaxValue ? "Không có" : min.ToString()));

            if (dau != null && dau.GiaTri == x) dau = dau.Tiep;
            else
            {
                NutDS p = dau;
                while (p != null && p.Tiep != null && p.Tiep.GiaTri != x) p = p.Tiep;
                if (p != null && p.Tiep != null) p.Tiep = p.Tiep.Tiep;
            }
            Console.WriteLine("c. Danh sách sau khi xóa lần xuất hiện đầu của x:");
            InDanhSach(dau);
        }

        static bool LaNguyenTo(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i <= x / i; i++) if (x % i == 0) return false;
            return true;
        }

        static void Bai5_Chuong4()
        {
            NutDS dau = NhapDanhSach(false);
            Console.Write("Nhập x: "); int x = int.Parse(Console.ReadLine());
            int max = int.MinValue, minDuong = int.MaxValue, snt = 0, am = 0, duong = 0, khong = 0, bangX = 0;
            long tong = 0;
            for (NutDS p = dau; p != null; p = p.Tiep)
            {
                int v = p.GiaTri;
                if (v > max) max = v;
                tong += v;
                if (LaNguyenTo(v)) snt++;
                if (v < 0) am++; else if (v > 0) duong++; else khong++;
                if (v == x) bangX++;
                if (v > 0 && v < minDuong) minDuong = v;
            }
            Console.WriteLine("a. Lớn nhất: " + (dau == null ? "Không có" : max.ToString()));
            Console.WriteLine("b. Tổng: " + tong);
            Console.WriteLine("c. Số nguyên tố: " + snt);
            Console.WriteLine("d. Âm: " + am + ", Dương: " + duong + ", Bằng 0: " + khong);
            Console.WriteLine("e. Số phần tử bằng x: " + bangX);
            Console.WriteLine("f. Dương nhỏ nhất: " + (minDuong == int.MaxValue ? "Không có" : minDuong.ToString()));
        }

        // ===== CHƯƠNG 5 =====
        static void Bai1_Chuong5()
        {
            Console.Write("Nhập biểu thức: "); string s = Console.ReadLine() ?? "";
            Stack<char> st = new Stack<char>(); bool dung = true;
            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{') st.Push(c);
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (st.Count == 0) { dung = false; break; }
                    char mo = st.Pop();
                    if ((c == ')' && mo != '(') || (c == ']' && mo != '[') || (c == '}' && mo != '{'))
                    { dung = false; break; }
                }
            }
            Console.WriteLine(dung && st.Count == 0 ? "Dấu ngoặc hợp lệ" : "Dấu ngoặc không hợp lệ");
        }

        static void Bai2_Chuong5()
        {
            Stack<string> back = new Stack<string>(), forward = new Stack<string>();
            string hienTai = "Trang chủ";
            while (true)
            {
                Console.WriteLine("Trang hiện tại: " + hienTai);
                Console.WriteLine("1. Truy cập trang | 2. Back | 3. Forward | 0. Thoát");
                string chon = Console.ReadLine();
                if (chon == "0") break;
                if (chon == "1")
                {
                    Console.Write("Tên trang: "); string trang = Console.ReadLine();
                    back.Push(hienTai); hienTai = trang; forward.Clear();
                }
                else if (chon == "2")
                {
                    if (back.Count > 0) { forward.Push(hienTai); hienTai = back.Pop(); }
                    else Console.WriteLine("Không thể Back");
                }
                else if (chon == "3")
                {
                    if (forward.Count > 0) { back.Push(hienTai); hienTai = forward.Pop(); }
                    else Console.WriteLine("Không thể Forward");
                }
            }
        }

        static void Bai3_Chuong5()
        {
            Stack<string> ham = new Stack<string>();
            while (true)
            {
                Console.WriteLine("1. Gọi hàm | 2. Kết thúc hàm | 3. Xem Stack | 0. Thoát");
                string chon = Console.ReadLine();
                if (chon == "0") break;
                if (chon == "1") { Console.Write("Tên hàm: "); ham.Push(Console.ReadLine()); }
                else if (chon == "2") Console.WriteLine(ham.Count > 0 ? "Trả về từ " + ham.Pop() : "Stack rỗng");
                else if (chon == "3") foreach (string h in ham) Console.WriteLine(h);
            }
        }

        static void Bai4_Chuong5()
        {
            Queue<string> q = new Queue<string>();
            while (true)
            {
                Console.WriteLine("1. Thêm yêu cầu in | 2. In tài liệu | 3. Xem hàng đợi | 0. Thoát");
                string chon = Console.ReadLine(); if (chon == "0") break;
                if (chon == "1") { Console.Write("Tên tài liệu: "); q.Enqueue(Console.ReadLine()); }
                else if (chon == "2") Console.WriteLine(q.Count > 0 ? "Đang in: " + q.Dequeue() : "Hàng đợi rỗng");
                else if (chon == "3") foreach (string s in q) Console.WriteLine(s);
            }
        }

        static void Bai5_Chuong5()
        {
            Queue<string> q = new Queue<string>();
            while (true)
            {
                Console.WriteLine("1. Gửi gói tin | 2. Xử lý gói tin | 3. Xem hàng đợi | 0. Thoát");
                string chon = Console.ReadLine(); if (chon == "0") break;
                if (chon == "1") { Console.Write("Nội dung gói tin: "); q.Enqueue(Console.ReadLine()); }
                else if (chon == "2") Console.WriteLine(q.Count > 0 ? "Đã xử lý: " + q.Dequeue() : "Không có gói tin");
                else if (chon == "3") foreach (string s in q) Console.WriteLine(s);
            }
        }

        static void Bai6_Chuong5()
        {
            Queue<string> q = new Queue<string>();
            while (true)
            {
                Console.WriteLine("1. Khách đến | 2. Phục vụ khách | 3. Xem hàng đợi | 0. Thoát");
                string chon = Console.ReadLine(); if (chon == "0") break;
                if (chon == "1") { Console.Write("Tên khách: "); q.Enqueue(Console.ReadLine()); }
                else if (chon == "2") Console.WriteLine(q.Count > 0 ? "Đang phục vụ: " + q.Dequeue() : "Không có khách");
                else if (chon == "3") foreach (string s in q) Console.WriteLine(s);
            }
        }

        // ===== CHƯƠNG 6 =====
        class NutCay
        {
            public int GiaTri;
            public NutCay Trai, Phai;
            public NutCay(int x) { GiaTri = x; }
        }

        static NutCay NhapCay()
        {
            Console.Write("Nhập giá trị nút (-1 để bỏ qua): ");
            int x = int.Parse(Console.ReadLine());
            if (x == -1) return null;
            NutCay p = new NutCay(x);
            Console.WriteLine("Nhập con trái của " + x); p.Trai = NhapCay();
            Console.WriteLine("Nhập con phải của " + x); p.Phai = NhapCay();
            return p;
        }

        static int DemNut(NutCay p)
        {
            if (p == null) return 0;
            return 1 + DemNut(p.Trai) + DemNut(p.Phai);
        }

        static long TongNut(NutCay p)
        {
            if (p == null) return 0;
            return p.GiaTri + TongNut(p.Trai) + TongNut(p.Phai);
        }

        static void DuyetNLR(NutCay p)
        {
            if (p == null) return;
            Console.Write(p.GiaTri + " "); DuyetNLR(p.Trai); DuyetNLR(p.Phai);
        }

        static void DuyetLNR(NutCay p)
        {
            if (p == null) return;
            DuyetLNR(p.Trai); Console.Write(p.GiaTri + " "); DuyetLNR(p.Phai);
        }

        static void DuyetLRN(NutCay p)
        {
            if (p == null) return;
            DuyetLRN(p.Trai); DuyetLRN(p.Phai); Console.Write(p.GiaTri + " ");
        }

        static void InNutChan(NutCay p)
        {
            if (p == null) return;
            if (p.GiaTri % 2 == 0) Console.Write(p.GiaTri + " ");
            InNutChan(p.Trai); InNutChan(p.Phai);
        }

        static int DemNutChan(NutCay p)
        {
            if (p == null) return 0;
            return (p.GiaTri % 2 == 0 ? 1 : 0) + DemNutChan(p.Trai) + DemNutChan(p.Phai);
        }

        static NutCay TimNut(NutCay p, int x)
        {
            if (p == null || p.GiaTri == x) return p;
            NutCay kq = TimNut(p.Trai, x);
            return kq != null ? kq : TimNut(p.Phai, x);
        }

        static void Bai1_Chuong6() { NutCay p = NhapCay(); Console.WriteLine("Số nút: " + DemNut(p)); }
        static void Bai2_Chuong6() { NutCay p = NhapCay(); Console.WriteLine("Tổng: " + TongNut(p)); }
        static void Bai3_Chuong6() { NutCay p = NhapCay(); Console.Write("Các nút: "); DuyetNLR(p); Console.WriteLine(); }
        static void Bai4_Chuong6() { NutCay p = NhapCay(); Console.Write("Các nút chẵn: "); InNutChan(p); Console.WriteLine(); }
        static void Bai5_Chuong6() { NutCay p = NhapCay(); Console.WriteLine("Số nút chẵn: " + DemNutChan(p)); }

        static void Bai6_Chuong6()
        {
            NutCay p = NhapCay(); Console.Write("Giá trị nút cần tìm: "); int x = int.Parse(Console.ReadLine());
            NutCay q = TimNut(p, x);
            if (q == null) Console.WriteLine("Không tìm thấy nút");
            else Console.WriteLine("Số con trực tiếp: " + ((q.Trai != null ? 1 : 0) + (q.Phai != null ? 1 : 0)));
        }

        static void Bai7_Chuong6()
        {
            NutCay p = NhapCay(); Console.Write("Cây con trái: ");
            if (p != null) DuyetNLR(p.Trai);
            Console.WriteLine();
        }

        static void Bai8_Chuong6()
        {
            NutCay p = NhapCay();
            Console.Write("Tiền thứ tự (NLR): "); DuyetNLR(p); Console.WriteLine();
            Console.Write("Trung thứ tự (LNR): "); DuyetLNR(p); Console.WriteLine();
            Console.Write("Hậu thứ tự (LRN): "); DuyetLRN(p); Console.WriteLine();
        }
    }
}