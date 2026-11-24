using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi02_DanhSach
{
    struct NhanVien
    {
        public string MaNV = "";
        public string Hoten = "";
        public int Namsinh = 0;
        public string Phongban = "";
        public int LuongCB = 0;
        public int Thuong = 0;

        public NhanVien() { }

        public int ThucLinh
        {
            get { return LuongCB + Thuong; }
        }
    }

    class Node
    {
        public static Node Rong = new Node();
        public int Info;
        public Node Link;

        private Node()
        {
            Info = 0;
            Link = this;
        }

        public Node(int x)
        {
            Info = x;
            Link = Rong;
        }
    }

    class DNode
    {
        public static DNode Rong = new DNode();
        public string Data;
        public DNode Prev;
        public DNode Next;

        private DNode()
        {
            Data = "";
            Prev = this;
            Next = this;
        }

        public DNode(string s)
        {
            Data = s;
            Prev = Rong;
            Next = Rong;
        }
    }

    class Bai1
    {
        static int[] a = { 10, 20, 30, 40, 50 };

        static void Nhap()
        {
            Console.Write("Nhập số phần tử n: ");
            int n = Program.DocSo();
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "] = ");
                a[i] = Program.DocSo();
            }
            Console.WriteLine("Đã nhập xong mảng.");
        }

        static void Xuat()
        {
            Console.Write("Danh sách hiện tại: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        static void Chen()
        {
            Console.Write("Nhập giá trị x cần chèn: ");
            int x = Program.DocSo();
            Console.Write("Nhập vị trí k (0 -> " + a.Length + "): ");
            int k = Program.DocSo();

            if (k < 0 || k > a.Length)
            {
                Console.WriteLine("Vị trí k không hợp lệ!");
                return;
            }

            int[] b = new int[a.Length + 1];
            for (int i = 0; i < k; i++)
            {
                b[i] = a[i];
            }
            b[k] = x;
            for (int i = k; i < a.Length; i++)
            {
                b[i + 1] = a[i];
            }
            a = b;
            Console.WriteLine("Đã chèn " + x + " vào vị trí " + k + ".");
            Xuat();
        }

        public static void Run()
        {
            while (true)
            {
                Console.WriteLine("\n--- Bài 1: Mảng 1 chiều ---");
                Console.WriteLine("a. Nhập danh sách | b. Hiển thị | c. Chèn x vào vị trí k | 0. Quay lại");
                Console.Write("Chọn: ");
                string chon = Program.DocChuoi().ToLower();

                if (chon == "a") Nhap();
                else if (chon == "b") Xuat();
                else if (chon == "c") Chen();
                else if (chon == "0") return;
            }
        }
    }

    class Bai2
    {
        static NhanVien[] ds = new NhanVien[]
        {
            new NhanVien { MaNV = "NV01", Hoten = "Nguyễn Văn Hùng", Namsinh = 1997, Phongban = "IT", LuongCB = 12000000, Thuong = 1500000 },
            new NhanVien { MaNV = "NV03", Hoten = "Trần Thị Mai", Namsinh = 1999, Phongban = "Kế toán", LuongCB = 8000000, Thuong = 1000000 },
            new NhanVien { MaNV = "NV02", Hoten = "Lê Minh Tuấn", Namsinh = 1996, Phongban = "IT", LuongCB = 8000000, Thuong = 2000000 },
            new NhanVien { MaNV = "NV04", Hoten = "Phạm Thu Hà", Namsinh = 2000, Phongban = "Nhân sự", LuongCB = 10000000, Thuong = 1200000 }
        };

        static int ThucLinh(int i)
        {
            return ds[i].LuongCB + ds[i].Thuong;
        }

        public static void Run()
        {
            while (true)
            {
                Console.WriteLine("\n--- Bài 2: Quản lý nhân viên ---");
                Console.WriteLine("a. Tổng thực lĩnh | b. Lương CB thấp nhất | c. Đếm thưởng >= 1.2tr | d. Sắp xếp | e. Tăng lương 5% | 0. Quay lại");
                Console.Write("Chọn: ");
                string chon = Program.DocChuoi().ToLower();

                if (chon == "a")
                {
                    long tong = 0;
                    for (int i = 0; i < ds.Length; i++)
                    {
                        tong += ThucLinh(i);
                    }
                    Console.WriteLine("Tổng thực lĩnh: " + tong.ToString("N0") + " VNĐ");
                }
                else if (chon == "b")
                {
                    int minL = ds[0].LuongCB;
                    for (int i = 1; i < ds.Length; i++)
                    {
                        if (ds[i].LuongCB < minL) minL = ds[i].LuongCB;
                    }
                    Console.WriteLine("Lương CB thấp nhất (" + minL.ToString("N0") + " VNĐ):");
                    for (int i = 0; i < ds.Length; i++)
                    {
                        if (ds[i].LuongCB == minL)
                        {
                            Console.WriteLine(" - " + ds[i].MaNV + " | " + ds[i].Hoten + " | " + ds[i].Phongban);
                        }
                    }
                }
                else if (chon == "c")
                {
                    int dem = 0;
                    for (int i = 0; i < ds.Length; i++)
                    {
                        if (ds[i].Thuong >= 1200000) dem++;
                    }
                    Console.WriteLine("Số NV thưởng >= 1.200.000: " + dem);
                }
                else if (chon == "d")
                {
                    NhanVien[] sx = new NhanVien[ds.Length];
                    for (int i = 0; i < ds.Length; i++) sx[i] = ds[i];

                    for (int i = 0; i < sx.Length - 1; i++)
                    {
                        for (int j = i + 1; j < sx.Length; j++)
                        {
                            int cmp = string.Compare(sx[i].Phongban, sx[j].Phongban);
                            if (cmp > 0 || (cmp == 0 && string.Compare(sx[i].MaNV, sx[j].MaNV) < 0))
                            {
                                NhanVien t = sx[i];
                                sx[i] = sx[j];
                                sx[j] = t;
                            }
                        }
                    }
                    for (int i = 0; i < sx.Length; i++)
                    {
                        Console.WriteLine(" - " + sx[i].Phongban + "\t| " + sx[i].MaNV + " | " + sx[i].Hoten);
                    }
                }
                else if (chon == "e")
                {
                    for (int i = 0; i < ds.Length; i++)
                    {
                        ds[i].LuongCB = ds[i].LuongCB + ds[i].LuongCB * 5 / 100;
                        Console.WriteLine(" - " + ds[i].MaNV + " | " + ds[i].Hoten + " | Lương CB mới: " + ds[i].LuongCB.ToString("N0"));
                    }
                }
                else if (chon == "0") return;
            }
        }
    }

    class Bai3
    {
        static int[,] a = {
            { 2, -4, 7 },
            { 5,  6, 1 },
            { 9,  3, 8 }
        };

        public static void Run()
        {
            int n = a.GetLength(0);
            while (true)
            {
                Console.WriteLine("\n--- Bài 3: Ma trận vuông ---");
                Console.WriteLine("a. Tổng phần tử | b. Dương nhỏ nhất | c. Tổng chéo phụ | d. Chéo chính tăng dần | 0. Quay lại");
                Console.Write("Chọn: ");
                string chon = Program.DocChuoi().ToLower();

                if (chon == "a")
                {
                    int s = 0;
                    for (int i = 0; i < n; i++)
                        for (int j = 0; j < n; j++)
                            s += a[i, j];
                    Console.WriteLine("Tổng: " + s);
                }
                else if (chon == "b")
                {
                    int minD = int.MaxValue;
                    for (int i = 0; i < n; i++)
                        for (int j = 0; j < n; j++)
                            if (a[i, j] > 0 && a[i, j] < minD) minD = a[i, j];
                    Console.WriteLine("Dương nhỏ nhất: " + minD);
                }
                else if (chon == "c")
                {
                    int cp = 0;
                    for (int i = 0; i < n; i++)
                        cp += a[i, n - 1 - i];
                    Console.WriteLine("Tổng đường chéo phụ: " + cp);
                }
                else if (chon == "d")
                {
                    bool tang = true;
                    for (int i = 0; i < n - 1; i++)
                    {
                        if (a[i, i] >= a[i + 1, i + 1])
                        {
                            tang = false;
                            break;
                        }
                    }
                    if (tang) Console.WriteLine("Đường chéo chính tăng dần: Đúng");
                    else Console.WriteLine("Đường chéo chính tăng dần: Sai");
                }
                else if (chon == "0") return;
            }
        }
    }

    class Bai4
    {
        public static void ThemCuoi(ref Node head, int val)
        {
            Node nodeMoi = new Node(val);
            if (head == Node.Rong)
            {
                head = nodeMoi;
                return;
            }
            Node p = head;
            while (p.Link != Node.Rong)
            {
                p = p.Link;
            }
            p.Link = nodeMoi;
        }

        public static void InDSLK(Node head)
        {
            Node p = head;
            while (p != Node.Rong)
            {
                Console.Write(p.Info + " -> ");
                p = p.Link;
            }
            Console.WriteLine("Rỗng");
        }

        public static void Run()
        {
            Node pHead = Node.Rong;
            int[] mau = { 5, 12, 3, 12, 8, 20 };
            for (int i = 0; i < mau.Length; i++) ThemCuoi(ref pHead, mau[i]);

            while (true)
            {
                Console.Write("\n--- Bài 4: DSLK đơn (Dương) --- Danh sách: ");
                InDSLK(pHead);
                Console.WriteLine("a. Đếm số bằng x | b. Dương nhỏ nhất | c. Xóa x đầu tiên | 0. Quay lại");
                Console.Write("Chọn: ");
                string chon = Program.DocChuoi().ToLower();

                if (chon == "a")
                {
                    Console.Write("Nhập x: ");
                    int x1 = Program.DocSo();
                    int d = 0;
                    for (Node p = pHead; p != Node.Rong; p = p.Link)
                        if (p.Info == x1) d++;
                    Console.WriteLine("Số lượng bằng " + x1 + ": " + d);
                }
                else if (chon == "b")
                {
                    int minD = int.MaxValue;
                    for (Node p = pHead; p != Node.Rong; p = p.Link)
                        if (p.Info > 0 && p.Info < minD) minD = p.Info;
                    Console.WriteLine("Dương nhỏ nhất: " + minD);
                }
                else if (chon == "c")
                {
                    Console.Write("Nhập x cần xóa: ");
                    int x2 = Program.DocSo();
                    Node curr = pHead;
                    Node prev = Node.Rong;

                    while (curr != Node.Rong && curr.Info != x2)
                    {
                        prev = curr;
                        curr = curr.Link;
                    }
                    if (curr != Node.Rong)
                    {
                        if (prev == Node.Rong) pHead = curr.Link;
                        else prev.Link = curr.Link;
                        Console.WriteLine("Đã xóa " + x2 + " đầu tiên.");
                    }
                    else
                    {
                        Console.WriteLine("Không tìm thấy " + x2);
                    }
                }
                else if (chon == "0") return;
            }
        }
    }

    class Bai5
    {
        static bool KTNT(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0) return false;
            return true;
        }

        public static void Run()
        {
            Node l = Node.Rong;
            int[] mau = { -5, 7, 0, 12, -3, 7, 2, 15 };
            for (int i = 0; i < mau.Length; i++) Bai4.ThemCuoi(ref l, mau[i]);

            while (true)
            {
                Console.Write("\n--- Bài 5: DSLK đơn (Số nguyên) --- Danh sách: ");
                Bai4.InDSLK(l);
                Console.WriteLine("a. Max | b. Tổng | c. Đếm SNT | d. Âm/Dương/0 | e. Đếm x | f. Dương min | 0. Quay lại");
                Console.Write("Chọn: ");
                string chon = Program.DocChuoi().ToLower();

                if (chon == "a")
                {
                    int max = int.MinValue;
                    for (Node p = l; p != Node.Rong; p = p.Link)
                        if (p.Info > max) max = p.Info;
                    Console.WriteLine("Max: " + max);
                }
                else if (chon == "b")
                {
                    int sum = 0;
                    for (Node p = l; p != Node.Rong; p = p.Link) sum += p.Info;
                    Console.WriteLine("Tổng: " + sum);
                }
                else if (chon == "c")
                {
                    int nt = 0;
                    for (Node p = l; p != Node.Rong; p = p.Link)
                        if (KTNT(p.Info)) nt++;
                    Console.WriteLine("Số nguyên tố: " + nt);
                }
                else if (chon == "d")
                {
                    int am = 0, duong = 0, khong = 0;
                    for (Node p = l; p != Node.Rong; p = p.Link)
                    {
                        if (p.Info < 0) am++;
                        else if (p.Info > 0) duong++;
                        else khong++;
                    }
                    Console.WriteLine("Âm: " + am + ", Dương: " + duong + ", Số 0: " + khong);
                }
                else if (chon == "e")
                {
                    Console.Write("Nhập x: ");
                    int x = Program.DocSo();
                    int dx = 0;
                    for (Node p = l; p != Node.Rong; p = p.Link)
                        if (p.Info == x) dx++;
                    Console.WriteLine("Số lượng bằng " + x + ": " + dx);
                }
                else if (chon == "f")
                {
                    int minD = int.MaxValue;
                    for (Node p = l; p != Node.Rong; p = p.Link)
                        if (p.Info > 0 && p.Info < minD) minD = p.Info;
                    Console.WriteLine("Dương nhỏ nhất: " + minD);
                }
                else if (chon == "0") return;
            }
        }
    }

    class Bai7
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Bài 7: Quản lý nhiệt độ ---");
            Console.Write("Nhập số ngày n (Enter dùng mẫu 7 ngày): ");
            string inp = Program.DocChuoi();
            double[] temps;

            if (inp.Trim() == "")
            {
                temps = new double[] { 28.5, 30.0, 32.2, 29.8, 27.0, 31.5, 33.0 };
            }
            else
            {
                int n = int.Parse(inp);
                temps = new double[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Nhiệt độ ngày " + (i + 1) + ": ");
                    double.TryParse(Program.DocChuoi(), out temps[i]);
                }
            }

            double max = temps[0], min = temps[0], tong = 0;
            int ngayMax = 1, ngayMin = 1;
            for (int i = 0; i < temps.Length; i++)
            {
                tong += temps[i];
                if (temps[i] > max) { max = temps[i]; ngayMax = i + 1; }
                if (temps[i] < min) { min = temps[i]; ngayMin = i + 1; }
            }

            Console.Write("Dữ liệu nhiệt độ: ");
            for (int i = 0; i < temps.Length; i++) Console.Write(temps[i] + "  ");
            Console.WriteLine();
            Console.WriteLine("- Ngày nhiệt độ cao nhất: Ngày " + ngayMax + " (" + max + "°C)");
            Console.WriteLine("- Ngày nhiệt độ thấp nhất: Ngày " + ngayMin + " (" + min + "°C)");
            Console.WriteLine("- Nhiệt độ trung bình: " + (tong / temps.Length).ToString("F2") + "°C");
        }
    }

    class Bai8
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Bài 8: Thống kê từ ---");
            Console.Write("Nhập chuỗi văn bản (Enter dùng mẫu): ");
            string text = Program.DocChuoi();
            if (text.Trim() == "")
                text = "Học cấu trúc dữ liệu và giải thuật, học lập trình C# rất thú vị!";

            string sach = "";
            string chuThuong = text.ToLower();
            for (int i = 0; i < chuThuong.Length; i++)
            {
                char c = chuThuong[i];
                if (char.IsLetterOrDigit(c) || c == ' ') sach += c;
            }

            string[] words = sach.Split(' ');
            Dictionary<string, int> freq = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                string w = words[i];
                if (w == "") continue;
                if (freq.ContainsKey(w)) freq[w]++;
                else freq[w] = 1;
            }

            Console.WriteLine("Văn bản: \"" + text + "\"");
            Console.WriteLine("Tần suất xuất hiện của từng từ:");
            foreach (KeyValuePair<string, int> item in freq)
            {
                Console.WriteLine(" - " + item.Key + "\t: " + item.Value + " lần");
            }
        }
    }

    class Bai9
    {
        static bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0) return false;
            return true;
        }

        static bool LaSoHoanHao(int n)
        {
            if (n <= 1) return false;
            int sum = 1;
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0) sum += i;
            return sum == n;
        }

        public static void Run()
        {
            Console.WriteLine("\n--- Bài 9: Xử lý số nguyên ---");
            Console.Write("Nhập dãy số cách nhau dấu cách (Enter dùng mẫu): ");
            string inp = Program.DocChuoi().Trim();
            int[] arr;

            if (inp == "")
            {
                arr = new int[] { 2, 6, 7, 10, 13, 28, 15, 4, 29 };
            }
            else
            {
                string[] tach = inp.Split(' ');
                List<int> listSo = new List<int>();
                for (int i = 0; i < tach.Length; i++)
                {
                    if (tach[i] != "") listSo.Add(int.Parse(tach[i]));
                }
                arr = listSo.ToArray();
            }

            Console.Write("Dãy số: ");
            for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");
            Console.WriteLine();

            Console.Write("- Các số nguyên tố: ");
            for (int i = 0; i < arr.Length; i++)
                if (LaSoNguyenTo(arr[i])) Console.Write(arr[i] + " ");
            Console.WriteLine();

            Console.Write("- Các số chẵn: ");
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] % 2 == 0) Console.Write(arr[i] + " ");
            Console.WriteLine();

            Console.Write("- Các số hoàn hảo: ");
            for (int i = 0; i < arr.Length; i++)
                if (LaSoHoanHao(arr[i])) Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }

    class Bai10
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Bài 10: Ma trận xoắn ốc ---");
            int[,] mat = {
                {  1,  2,  3,  4 },
                {  5,  6,  7,  8 },
                {  9, 10, 11, 12 },
                { 13, 14, 15, 16 }
            };

            int m = mat.GetLength(0), n = mat.GetLength(1);
            Console.WriteLine("Ma trận gốc 4x4:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++) Console.Write(mat[i, j] + "\t");
                Console.WriteLine();
            }

            int top = 0, bottom = m - 1, left = 0, right = n - 1;
            Console.Write("Duyệt xoắn ốc: ");
            while (top <= bottom && left <= right)
            {
                for (int i = left; i <= right; i++) Console.Write(mat[top, i] + " ");
                top++;

                for (int i = top; i <= bottom; i++) Console.Write(mat[i, right] + " ");
                right--;

                if (top <= bottom)
                {
                    for (int i = right; i >= left; i--) Console.Write(mat[bottom, i] + " ");
                    bottom--;
                }

                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--) Console.Write(mat[i, left] + " ");
                    left++;
                }
            }
            Console.WriteLine();
        }
    }

    class Bai11
    {
        static bool LaMaTranDonVi(int[,] a)
        {
            int n = a.GetLength(0);
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if ((i == j && a[i, j] != 1) || (i != j && a[i, j] != 0)) return false;
            return true;
        }

        static bool LaMaTranDoiXung(int[,] a)
        {
            int n = a.GetLength(0);
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    if (a[i, j] != a[j, i]) return false;
            return true;
        }

        public static void Run()
        {
            Console.WriteLine("\n--- Bài 11: Ma trận đặc biệt ---");
            int[,] m1 = { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
            int[,] m2 = { { 1, 2, 3 }, { 2, 4, 5 }, { 3, 5, 6 } };

            Console.WriteLine("Ma trận 1 -> Đơn vị: " + LaMaTranDonVi(m1) + ", Đối xứng: " + LaMaTranDoiXung(m1));
            Console.WriteLine("Ma trận 2 -> Đơn vị: " + LaMaTranDonVi(m2) + ", Đối xứng: " + LaMaTranDoiXung(m2));
        }
    }

    class Bai12
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Bài 12: Game Minesweeper ---");
            Console.Write("Nhập số dòng m (mặc định 5): ");
            string sm = Program.DocChuoi().Trim();
            int m = 5;
            if (sm != "") m = int.Parse(sm);

            Console.Write("Nhập số cột n (mặc định 5): ");
            string sn = Program.DocChuoi().Trim();
            int n = 5;
            if (sn != "") n = int.Parse(sn);

            int soMin = (m * n) / 5;
            char[,] board = new char[m, n];
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++) board[i, j] = '.';

            Random rnd = new Random();
            int placed = 0;
            while (placed < soMin)
            {
                int r = rnd.Next(m), c = rnd.Next(n);
                if (board[r, c] != '*')
                {
                    board[r, c] = '*';
                    placed++;
                }
            }

            int[] dx = { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] dy = { -1, 0, 1, -1, 1, -1, 0, 1 };

            Console.WriteLine("Bảng Minesweeper " + m + "x" + n + " (" + soMin + " mìn):");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (board[i, j] == '*') Console.Write(" * ");
                    else
                    {
                        int count = 0;
                        for (int k = 0; k < 8; k++)
                        {
                            int ni = i + dx[k], nj = j + dy[k];
                            if (ni >= 0 && ni < m && nj >= 0 && nj < n && board[ni, nj] == '*') count++;
                        }
                        Console.Write(" " + count + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }

    class Bai13
    {
        static Node DaoNguoc(Node head)
        {
            Node prev = Node.Rong;
            Node current = head;
            Node next = Node.Rong;
            while (current != Node.Rong)
            {
                next = current.Link;
                current.Link = prev;
                prev = current;
                current = next;
            }
            return prev;
        }

        public static void Run()
        {
            Console.WriteLine("\n--- Bài 13: Đảo ngược DSLK đơn ---");
            Node head = Node.Rong;
            int[] mau = { 10, 20, 30, 40, 50 };
            for (int i = 0; i < mau.Length; i++) Bai4.ThemCuoi(ref head, mau[i]);

            Console.Write("Ban đầu:   "); Bai4.InDSLK(head);
            head = DaoNguoc(head);
            Console.Write("Đảo ngược: "); Bai4.InDSLK(head);
        }
    }

    class Bai14
    {
        static Node GopHaiDSLK(Node l1, Node l2)
        {
            Node dummy = new Node(0);
            Node tail = dummy;

            while (l1 != Node.Rong && l2 != Node.Rong)
            {
                if (l1.Info <= l2.Info)
                {
                    tail.Link = l1;
                    l1 = l1.Link;
                }
                else
                {
                    tail.Link = l2;
                    l2 = l2.Link;
                }
                tail = tail.Link;
            }
            if (l1 != Node.Rong) tail.Link = l1;
            else tail.Link = l2;

            return dummy.Link;
        }

        public static void Run()
        {
            Console.WriteLine("\n--- Bài 14: Gộp hai DSLK đã sắp xếp ---");
            Node l1 = Node.Rong, l2 = Node.Rong;
            int[] m1 = { 1, 4, 7, 10 };
            int[] m2 = { 2, 3, 6, 8, 12 };
            for (int i = 0; i < m1.Length; i++) Bai4.ThemCuoi(ref l1, m1[i]);
            for (int i = 0; i < m2.Length; i++) Bai4.ThemCuoi(ref l2, m2[i]);

            Console.Write("Danh sách 1: "); Bai4.InDSLK(l1);
            Console.Write("Danh sách 2: "); Bai4.InDSLK(l2);
            Node merged = GopHaiDSLK(l1, l2);
            Console.Write("Sau khi gộp: "); Bai4.InDSLK(merged);
        }
    }

    class Bai15
    {
        static bool CoChuTrinh(Node head)
        {
            Node slow = head, fast = head;
            while (fast != Node.Rong && fast.Link != Node.Rong)
            {
                slow = slow.Link;
                fast = fast.Link.Link;
                if (slow == fast) return true;
            }
            return false;
        }

        public static void Run()
        {
            Console.WriteLine("\n--- Bài 15: Phát hiện chu trình (Floyd) ---");
            Node n2 = new Node(2), n3 = new Node(3), n4 = new Node(4), n5 = new Node(5), n6 = new Node(6);
            n2.Link = n3; n3.Link = n4; n4.Link = n5; n5.Link = n6; n6.Link = n2;

            Node listThuong = Node.Rong;
            int[] mau = { 1, 2, 3, 4 };
            for (int i = 0; i < mau.Length; i++) Bai4.ThemCuoi(ref listThuong, mau[i]);

            Console.WriteLine("Danh sách 1 (2->3->4->5->6->2) có chu trình: " + CoChuTrinh(n2));
            Console.WriteLine("Danh sách 2 (1->2->3->4->Rỗng) có chu trình: " + CoChuTrinh(listThuong));
        }
    }

    class Bai16
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Bài 16: Lịch sử duyệt web ---");
            DNode current = new DNode("google.com");

            void Visit(string url)
            {
                DNode newNode = new DNode(url);
                current.Next = newNode;
                newNode.Prev = current;
                current = newNode;
                Console.WriteLine("Truy cập: " + current.Data);
            }

            Visit("youtube.com");
            Visit("utehy.edu.vn");

            while (true)
            {
                Console.WriteLine("\nTrang hiện tại: [" + current.Data + "]");
                Console.WriteLine("1. Truy cập trang mới | 2. Back | 3. Forward | 0. Quay lại");
                Console.Write("Chọn: ");
                string c = Program.DocChuoi();

                if (c == "1")
                {
                    Console.Write("Nhập URL: ");
                    Visit(Program.DocChuoi());
                }
                else if (c == "2")
                {
                    if (current.Prev != DNode.Rong)
                    {
                        current = current.Prev;
                        Console.WriteLine("Back -> " + current.Data);
                    }
                    else Console.WriteLine("Không thể Back thêm!");
                }
                else if (c == "3")
                {
                    if (current.Next != DNode.Rong)
                    {
                        current = current.Next;
                        Console.WriteLine("Forward -> " + current.Data);
                    }
                    else Console.WriteLine("Không thể Forward thêm!");
                }
                else if (c == "0") return;
            }
        }
    }

    class Bai17
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Bài 17: Playlist nhạc ---");
            DNode head = DNode.Rong, tail = DNode.Rong, current = DNode.Rong;

            void ThemBai(string ten)
            {
                DNode node = new DNode(ten);
                if (head == DNode.Rong)
                {
                    head = tail = current = node;
                }
                else
                {
                    tail.Next = node;
                    node.Prev = tail;
                    tail = node;
                }
            }

            ThemBai("Lạc Trôi - Sơn Tùng M-TP");
            ThemBai("Nàng Thơ - Hoàng Dũng");
            ThemBai("Cắt Đôi Nỗi Sầu - Tăng Duy Tân");

            while (true)
            {
                string tenDangPhat = "Trống";
                if (current != DNode.Rong) tenDangPhat = current.Data;

                Console.WriteLine("\nĐang phát: " + tenDangPhat);
                Console.WriteLine("1. Next | 2. Previous | 3. Thêm bài | 4. Xóa bài đang phát | 0. Quay lại");
                Console.Write("Chọn: ");
                string c = Program.DocChuoi();

                if (c == "1")
                {
                    if (current != DNode.Rong && current.Next != DNode.Rong) current = current.Next;
                    else Console.WriteLine("Đã ở cuối playlist!");
                }
                else if (c == "2")
                {
                    if (current != DNode.Rong && current.Prev != DNode.Rong) current = current.Prev;
                    else Console.WriteLine("Đã ở đầu playlist!");
                }
                else if (c == "3")
                {
                    Console.Write("Tên bài hát: ");
                    ThemBai(Program.DocChuoi());
                    Console.WriteLine("Đã thêm vào cuối playlist!");
                }
                else if (c == "4" && current != DNode.Rong)
                {
                    Console.WriteLine("Đã xóa: " + current.Data);
                    if (current.Prev != DNode.Rong) current.Prev.Next = current.Next;
                    else head = current.Next;

                    if (current.Next != DNode.Rong) current.Next.Prev = current.Prev;
                    else tail = current.Prev;

                    if (current.Next != DNode.Rong) current = current.Next;
                    else current = current.Prev;
                }
                else if (c == "0") return;
            }
        }
    }

    class Bai18
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Bài 18: Hệ thống đặt hàng ---");
            DNode s1 = new DNode("Chờ xử lý");
            DNode s2 = new DNode("Đang giao");
            DNode s3 = new DNode("Hoàn thành");
            s1.Next = s2; s2.Prev = s1;
            s2.Next = s3; s3.Prev = s2;

            DNode trangThaiHienTai = s1;
            string maDon = "DH2026_01";

            while (true)
            {
                Console.WriteLine("\nĐơn hàng [" + maDon + "] - Trạng thái hiện tại: >>> " + trangThaiHienTai.Data + " <<<");
                Console.WriteLine("1. Chuyển trạng thái tiếp theo | 2. Lùi lại trạng thái trước | 0. Quay lại");
                Console.Write("Chọn: ");
                string c = Program.DocChuoi();

                if (c == "1")
                {
                    if (trangThaiHienTai.Next != DNode.Rong) trangThaiHienTai = trangThaiHienTai.Next;
                    else Console.WriteLine("Đơn hàng đã hoàn thành!");
                }
                else if (c == "2")
                {
                    if (trangThaiHienTai.Prev != DNode.Rong) trangThaiHienTai = trangThaiHienTai.Prev;
                    else Console.WriteLine("Đơn hàng đang ở trạng thái ban đầu!");
                }
                else if (c == "0") return;
            }
        }
    }

    class Program
    {
        public static string DocChuoi()
        {
            return "" + Console.ReadLine();
        }

        public static int DocSo()
        {
            int kq;
            int.TryParse(Console.ReadLine(), out kq);
            return kq;
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("\n================ Buổi 02: Mảng & Danh sách liên kết ================");
                Console.WriteLine("   1. Bài 1 : Mảng 1 chiều (Nhập, hiển thị, chèn x)");
                Console.WriteLine("   2. Bài 2 : Quản lý nhân viên (Struct)");
                Console.WriteLine("   3. Bài 3 : Ma trận vuông");
                Console.WriteLine("   4. Bài 4 : DSLK đơn số nguyên dương");
                Console.WriteLine("   5. Bài 5 : DSLK đơn số nguyên");
                Console.WriteLine("   7. Bài 7 : Quản lý nhiệt độ");
                Console.WriteLine("   8. Bài 8 : Thống kê tần suất từ");
                Console.WriteLine("   9. Bài 9 : Xử lý số nguyên (SNT, Chẵn, Hoàn hảo)");
                Console.WriteLine("  10. Bài 10: Ma trận xoắn ốc");
                Console.WriteLine("  11. Bài 11: Ma trận đặc biệt (Đơn vị & Đối xứng)");
                Console.WriteLine("  12. Bài 12: Game Minesweeper");
                Console.WriteLine("  13. Bài 13: Đảo ngược danh sách liên kết đơn");
                Console.WriteLine("  14. Bài 14: Gộp hai danh sách liên kết đã sắp xếp");
                Console.WriteLine("  15. Bài 15: Phát hiện chu trình (Floyd Rùa & Thỏ)");
                Console.WriteLine("  16. Bài 16: Hệ thống lịch sử duyệt web (DSLK kép)");
                Console.WriteLine("  17. Bài 17: Playlist nhạc (DSLK kép)");
                Console.WriteLine("  18. Bài 18: Hệ thống đặt hàng (DSLK kép)");
                Console.WriteLine("   0. Thoát");
                Console.Write("Chọn số thứ tự bài muốn chạy: ");

                switch (DocChuoi())
                {
                    case "1": Bai1.Run(); break;
                    case "2": Bai2.Run(); break;
                    case "3": Bai3.Run(); break;
                    case "4": Bai4.Run(); break;
                    case "5": Bai5.Run(); break;
                    case "7": Bai7.Run(); break;
                    case "8": Bai8.Run(); break;
                    case "9": Bai9.Run(); break;
                    case "10": Bai10.Run(); break;
                    case "11": Bai11.Run(); break;
                    case "12": Bai12.Run(); break;
                    case "13": Bai13.Run(); break;
                    case "14": Bai14.Run(); break;
                    case "15": Bai15.Run(); break;
                    case "16": Bai16.Run(); break;
                    case "17": Bai17.Run(); break;
                    case "18": Bai18.Run(); break;
                    case "0": return;
                    default: Console.WriteLine("Lựa chọn không hợp lệ!"); break;
                }
            }
        }
    }
}