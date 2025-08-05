---
title: "Dự án Website Bán Sách Trực Tuyến (ASP.NET MVC + AWS)"
date: 2025-08-05
weight: 3
chapter: false
pre: "<b> 3. </b>"
---

## 🌐 Giới thiệu

**Blue Bookstore** là hệ thống website bán sách trực tuyến được xây dựng bằng C# – ASP.NET MVC, triển khai trên hạ tầng AWS và tích hợp cổng thanh toán **VNPAY**. Hệ thống hỗ trợ người dùng tìm kiếm, đặt mua và thanh toán sách một cách tiện lợi, đồng thời giúp quản trị viên dễ dàng theo dõi và quản lý sản phẩm, đơn hàng.

---

## ✅ Các chức năng chính

| Chức năng             | Mô tả |
|-----------------------|-------|
| Đăng ký / Đăng nhập   | Xác thực người dùng bằng token JWT |
| Quản lý người dùng    | CRUD tài khoản, phân quyền admin / user |
| Quản lý sản phẩm (sách) | Thêm, sửa, xóa, phân loại, tìm kiếm sách |
| Quản lý đơn hàng      | Theo dõi trạng thái đơn hàng, cập nhật và gửi thông báo |
| Giỏ hàng              | Thêm/xóa sản phẩm, cập nhật số lượng, thanh toán |
| Gửi thông báo         | Gửi email khi đơn hàng được xác nhận, giao hàng,... |
| Ghi log hệ thống      | Theo dõi thao tác người dùng, log lỗi, log hoạt động hệ thống |
| Bảo mật và chống tấn công | Sử dụng AWS WAF bảo vệ khỏi DDoS, SQLi, XSS, bot |
| Triển khai cloud      | Deploy toàn bộ hệ thống trên AWS |
| Gợi ý sách            | Dùng Graph Neural Networks với Neptune ML |
| Thanh toán VNPAY      | Tích hợp thanh toán trực tuyến qua VNPAY |

---

## 💻 Công nghệ & Dịch vụ sử dụng

| Công nghệ / Dịch vụ | Vai trò |
|---------------------|--------|
| ASP.NET MVC         | Giao diện web và xử lý logic |
| Entity Framework    | ORM làm việc với cơ sở dữ liệu |
| SQL Server          | Lưu trữ sách, người dùng, đơn hàng |
| AWS EC2             | Triển khai ứng dụng web |
| AWS RDS             | SQL Server chạy trên cloud |
| AWS S3              | Lưu trữ ảnh bìa sách, file đính kèm |
| AWS SNS             | Gửi thông báo email |
| AWS IAM             | Phân quyền tài nguyên AWS |
| AWS CloudWatch      | Ghi log, giám sát hiệu suất hệ thống |
| AWS WAF             | Bảo vệ website khỏi tấn công |
| Neptune ML          | Gợi ý sách bằng Graph Neural Networks |
| VNPAY               | Cổng thanh toán online |

---

## ⚙️ Hướng dẫn cài đặt và triển khai

### 1. Cài đặt môi trường phát triển

- Visual Studio 2022
- SQL Server hoặc sử dụng RDS trên AWS
- .NET Framework 4.8 trở lên
- Tạo project ASP.NET MVC, cài Entity Framework qua NuGet

### 2. Cấu hình cơ sở dữ liệu

- Tạo database trên SQL Server (cục bộ hoặc RDS)
- Cấu hình chuỗi kết nối trong `web.config`
- Sử dụng Code First hoặc Database First với EF

### 3. Tích hợp VNPAY

- Đăng ký merchant tại https://vnpay.vn
- Lấy `vnp_TmnCode`, `vnp_HashSecret`
- Thêm file `vnpay.config` để lưu thông tin cấu hình
- Tạo form thanh toán và xử lý callback kết quả thanh toán từ VNPAY

### 4. Triển khai lên AWS

- Tạo EC2 instance (Windows Server + IIS)
- Deploy project bằng Web Deploy hoặc FTP
- Tạo RDS SQL Server và kết nối từ ứng dụng
- Tạo bucket S3 để lưu ảnh sản phẩm
- Cấu hình AWS WAF để chặn tấn công
- Cấu hình SNS gửi email khi đơn hàng thay đổi trạng thái
- Gắn IAM Role cho EC2 để truy cập tài nguyên AWS

### 5. Cài đặt log và giám sát

- Sử dụng `AWS CloudWatch Agent` để thu thập log hệ thống
- Ghi log người dùng và lỗi vào file, hoặc gửi log đến CloudWatch

---

## 📈 Tính năng nâng cao

- Gợi ý sách bằng mô hình **Graph Neural Networks**
- Dữ liệu người dùng, review, thể loại → nhập vào Neptune DB
- Dùng **Neptune ML** để huấn luyện và gợi ý sách phù hợp

---

## 📦 Kết luận

Dự án này giúp bạn làm chủ quy trình xây dựng một website thương mại điện tử hoàn chỉnh, tích hợp cổng thanh toán và triển khai trên AWS. Đây là một sản phẩm tốt để đưa vào CV nếu bạn đang tìm cơ hội thực tập hoặc việc làm trong mảng backend, cloud hoặc fullstack.
