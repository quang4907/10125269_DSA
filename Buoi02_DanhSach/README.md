# Buổi 02 – Danh sách

Họ tên: Giang Anh Quang · MSV: 10125269

## Bài đã làm
Bài 1, 2, 3, 4, 5, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18

## Cách chạy
~~~
dotnet run --project Buoi02_DanhSach
~~~

## Kết quả chạy
~~~
=== Bài 1: Mảng 1 chiều ===
Danh sách hiện tại: 10 20 30 40 50 
Nhập giá trị x cần chèn: 25
Nhập vị trí k (0 -> 5): 2
Đã chèn 25 vào vị trí 2.
Danh sách hiện tại: 10 20 25 30 40 50 

=== Bài 2: Quản lý nhân viên ===
Tổng thực lĩnh: 43,700,000 VNĐ
Lương CB thấp nhất (8,000,000 VNĐ):
 - NV03 | Trần Thị Mai | Kế toán
 - NV02 | Lê Minh Tuấn | IT
Số NV thưởng >= 1.200.000: 3
Sắp xếp theo phòng ban và mã NV:
 - IT	| NV02 | Lê Minh Tuấn
 - IT	| NV01 | Nguyễn Văn Hùng
 - Kế toán	| NV03 | Trần Thị Mai
 - Nhân sự	| NV04 | Phạm Thu Hà

=== Bài 3: Ma trận vuông ===
Tổng: 37
Dương nhỏ nhất: 1
Tổng đường chéo phụ: 22
Đường chéo chính tăng dần: Đúng

=== Bài 4: DSLK đơn (Dương) ===
Danh sách: 5 -> 12 -> 3 -> 12 -> 8 -> 20 -> Rỗng
Số lượng bằng 12: 2
Dương nhỏ nhất: 3
Đã xóa 12 đầu tiên.
Danh sách sau xóa: 5 -> 3 -> 12 -> 8 -> 20 -> Rỗng

=== Bài 5: DSLK đơn (Số nguyên) ===
Danh sách: -5 -> 7 -> 0 -> 12 -> -3 -> 7 -> 2 -> 15 -> Rỗng
Max: 15
Tổng: 35
Số nguyên tố: 3
Âm: 2, Dương: 5, Số 0: 1
Dương nhỏ nhất: 2

=== Bài 7: Quản lý nhiệt độ ===
Dữ liệu nhiệt độ: 28.5  30  32.2  29.8  27  31.5  33  
- Ngày nhiệt độ cao nhất: Ngày 7 (33°C)
- Ngày nhiệt độ thấp nhất: Ngày 5 (27°C)
- Nhiệt độ trung bình: 30.29°C

=== Bài 8: Thống kê từ ===
Văn bản: "Học cấu trúc dữ liệu và giải thuật, học lập trình C# rất thú vị!"
Tần suất xuất hiện của từng từ:
 - học	: 2 lần
 - cấu	: 1 lần
 - trúc	: 1 lần
 - dữ	: 1 lần
 - liệu	: 1 lần
 - và	: 1 lần
 - giải	: 1 lần
 - thuật	: 1 lần
 - lập	: 1 lần
 - trình	: 1 lần
 - c	: 1 lần
 - rất	: 1 lần
 - thú	: 1 lần
 - vị	: 1 lần

=== Bài 9: Xử lý số nguyên ===
Dãy số: 2 6 7 10 13 28 15 4 29 
- Các số nguyên tố: 2 7 13 29 
- Các số chẵn: 2 6 10 28 4 
- Các số hoàn hảo: 6 28 

=== Bài 10: Ma trận xoắn ốc ===
Ma trận gốc 4x4:
1	2	3	4	
5	6	7	8	
9	10	11	12	
13	14	15	16	
Duyệt xoắn ốc: 1 2 3 4 8 12 16 15 14 13 9 5 6 7 11 10 

=== Bài 11: Ma trận đặc biệt ===
Ma trận 1 -> Đơn vị: True, Đối xứng: True
Ma trận 2 -> Đơn vị: False, Đối xứng: True

=== Bài 12: Game Minesweeper ===
Bảng Minesweeper 5x5 (5 mìn):
 1  1  1  0  0 
 1  *  1  0  0 
 2  2  2  1  1 
 1  *  2  *  1 
 1  1  2  1  1 

=== Bài 13: Đảo ngược DSLK đơn ===
Ban đầu:   10 -> 20 -> 30 -> 40 -> 50 -> Rỗng
Đảo ngược: 50 -> 40 -> 30 -> 20 -> 10 -> Rỗng

=== Bài 14: Gộp hai DSLK đã sắp xếp ===
Danh sách 1: 1 -> 4 -> 7 -> 10 -> Rỗng
Danh sách 2: 2 -> 3 -> 6 -> 8 -> 12 -> Rỗng
Sau khi gộp: 1 -> 2 -> 3 -> 4 -> 6 -> 7 -> 8 -> 10 -> 12 -> Rỗng

=== Bài 15: Phát hiện chu trình (Floyd) ===
Danh sách 1 (2->3->4->5->6->2) có chu trình: True
Danh sách 2 (1->2->3->4->Rỗng) có chu trình: False

=== Bài 16: Lịch sử duyệt web ===
Truy cập: youtube.com
Truy cập: utehy.edu.vn
Trang hiện tại: [utehy.edu.vn]
Back -> youtube.com
Trang hiện tại: [youtube.com]

=== Bài 17: Playlist nhạc ===
Đang phát: Lạc Trôi - Sơn Tùng M-TP
Next
Đang phát: Nàng Thơ - Hoàng Dũng

=== Bài 18: Hệ thống đặt hàng ===
Đơn hàng [DH2026_01] - Trạng thái hiện tại: >>> Chờ xử lý <<<
Chuyển trạng thái tiếp theo -> Trạng thái hiện tại: >>> Đang giao <<<
~~~
