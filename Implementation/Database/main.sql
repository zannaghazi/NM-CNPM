/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     7/17/2020 3:41:50 PM                         */
/*==============================================================*/
DROP DATABASE IF EXISTS QUANLYCAYGIAPHA;
CREATE DATABASE QUANLYCAYGIAPHA;
USE QUANLYCAYGIAPHA;

DROP TABLE IF EXISTS CHITIETTHANHTICH;

DROP TABLE IF EXISTS DIADIEMMAITANG;

DROP TABLE IF EXISTS LOAIQUANHE;

DROP TABLE IF EXISTS LOAITHANHTICH;

DROP TABLE IF EXISTS NGHENGHIEP;

DROP TABLE IF EXISTS NGUYENNHANMAT;

DROP TABLE IF EXISTS QUEQUAN;

DROP TABLE IF EXISTS THANHVIEN;

DROP TABLE IF EXISTS THANHVIENMAT;

/*==============================================================*/
/* Table: CHITIETTHANHTICH                                      */
/*==============================================================*/
CREATE TABLE CHITIETTHANHTICH
(
   MACHITIETTHANHTICH   INT NOT NULL,
   MATHANHVIEN          INT NOT NULL,
   MALOAITHANHTICH      INT NOT NULL,
   NGAYPHATSINH         DATE,
   TENTHANHTICH         VARCHAR(50),
   PRIMARY KEY (MACHITIETTHANHTICH)
);

ALTER TABLE CHITIETTHANHTICH COMMENT 'Chi Tiet Thanh Tich';

/*==============================================================*/
/* Table: DIADIEMMAITANG                                        */
/*==============================================================*/
CREATE TABLE DIADIEMMAITANG
(
   MADIADIEM            INT AUTO_INCREMENT,
   TENDIADIEM		    VARCHAR(50),
   DAXOA				BOOL,
   PRIMARY KEY (MADIADIEM)
);

ALTER TABLE DIADIEMMAITANG COMMENT 'Dia Diem Mai Tang';

INSERT INTO DIADIEMMAITANG(TENDIADIEM, DAXOA)
	VALUES ('Nghĩa trang cán bộ', FALSE);
INSERT INTO DIADIEMMAITANG(TENDIADIEM, DAXOA)
	VALUES ('Lò hỏa thiêu KFC', FALSE);
INSERT INTO DIADIEMMAITANG(TENDIADIEM, DAXOA)
	VALUES ('Nghĩa địa thiên đường', FALSE);

/*==============================================================*/
/* Table: LOAIQUANHE                                            */
/*==============================================================*/
CREATE TABLE LOAIQUANHE
(
   MALOAIQUANHE         INT AUTO_INCREMENT,
   TENLOAIQUANHE        VARCHAR(50),
   DAXOA				BOOL,
   PRIMARY KEY (MALOAIQUANHE)
);

ALTER TABLE LOAIQUANHE COMMENT 'Loai Quan He';

INSERT INTO LOAIQUANHE(TENLOAIQUANHE, DAXOA)
	VALUES ('Con', FALSE);
INSERT INTO LOAIQUANHE(TENLOAIQUANHE, DAXOA)
	VALUES ('Cha/Mẹ', FALSE);

/*==============================================================*/
/* Table: LOAITHANHTICH                                         */
/*==============================================================*/
CREATE TABLE LOAITHANHTICH
(
   MALOAITHANHTICH      INT AUTO_INCREMENT,
   TENLOAITHANHTICH     VARCHAR(50),
   DAXOA				BOOL,
   PRIMARY KEY (MALOAITHANHTICH)
);

ALTER TABLE LOAITHANHTICH COMMENT 'Loai Thanh Tich';

/*==============================================================*/
/* Table: NGHENGHIEP                                            */
/*==============================================================*/
CREATE TABLE NGHENGHIEP
(
   MANGHENGHIEP         INT AUTO_INCREMENT,
   TENNGHENGHIEP        VARCHAR(50),
   DAXOA				BOOL,
   PRIMARY KEY (MANGHENGHIEP)
);

ALTER TABLE NGHENGHIEP COMMENT 'Nghe Nghiep';

INSERT INTO NGHENGHIEP(TENNGHENGHIEP, DAXOA)
	VALUES ('Lập trình viên', FALSE);
INSERT INTO NGHENGHIEP(TENNGHENGHIEP, DAXOA)
	VALUES ('Quản trị kinh doanh', FALSE);
INSERT INTO NGHENGHIEP(TENNGHENGHIEP, DAXOA)
	VALUES ('Công nhân', FALSE);
INSERT INTO NGHENGHIEP(TENNGHENGHIEP, DAXOA)
	VALUES ('Kỹ sư xây dựng', FALSE);
INSERT INTO NGHENGHIEP(TENNGHENGHIEP, DAXOA)
	VALUES ('Nội trợ', FALSE);
INSERT INTO NGHENGHIEP(TENNGHENGHIEP, DAXOA)
	VALUES ('Hướng dẫn viên du lịch', FALSE);
INSERT INTO NGHENGHIEP(TENNGHENGHIEP, DAXOA)
	VALUES ('Phi công', FALSE);
INSERT INTO NGHENGHIEP(TENNGHENGHIEP, DAXOA)
	VALUES ('Kế toán', FALSE);
INSERT INTO NGHENGHIEP(TENNGHENGHIEP, DAXOA)
	VALUES ('Phiên dịch viên', FALSE);
INSERT INTO NGHENGHIEP(TENNGHENGHIEP, DAXOA)
	VALUES ('Thủ thư', FALSE);
INSERT INTO NGHENGHIEP(TENNGHENGHIEP, DAXOA)
	VALUES ('Giáo viên', FALSE);
INSERT INTO NGHENGHIEP(TENNGHENGHIEP, DAXOA)
	VALUES ('Bộ đội', FALSE);
INSERT INTO NGHENGHIEP(TENNGHENGHIEP, DAXOA)
	VALUES ('Công an', FALSE);
INSERT INTO NGHENGHIEP(TENNGHENGHIEP, DAXOA)
	VALUES ('Chăm nuôi gia súc', FALSE);
INSERT INTO NGHENGHIEP(TENNGHENGHIEP, DAXOA)
	VALUES ('Bác sĩ', FALSE);

/*==============================================================*/
/* Table: NGUYENNHANMAT                                         */
/*==============================================================*/
CREATE TABLE NGUYENNHANMAT
(
   MANGUYENNHANMAT      INT AUTO_INCREMENT,
   TENNGUYENNHANMAT     VARCHAR(50),
   DAXOA				BOOL,
   PRIMARY KEY (MANGUYENNHANMAT)
);

ALTER TABLE NGUYENNHANMAT COMMENT 'Nguyen Nhan Mat';

INSERT INTO NGUYENNHANMAT(TENNGUYENNHANMAT, DAXOA)
	VALUES ('Tai nạn giao thông', FALSE);
INSERT INTO NGUYENNHANMAT(TENNGUYENNHANMAT, DAXOA)
	VALUES ('Bệnh tật', FALSE);
INSERT INTO NGUYENNHANMAT(TENNGUYENNHANMAT, DAXOA)
	VALUES ('Tai nạn lao động', FALSE);
INSERT INTO NGUYENNHANMAT(TENNGUYENNHANMAT, DAXOA)
	VALUES ('Tự sát', FALSE);
INSERT INTO NGUYENNHANMAT(TENNGUYENNHANMAT, DAXOA)
	VALUES ('Ngộ độc', FALSE);
INSERT INTO NGUYENNHANMAT(TENNGUYENNHANMAT, DAXOA)
	VALUES ('Bị ám sát', FALSE);
INSERT INTO NGUYENNHANMAT(TENNGUYENNHANMAT, DAXOA)
	VALUES ('Do tuổi già', FALSE);
INSERT INTO NGUYENNHANMAT(TENNGUYENNHANMAT, DAXOA)
	VALUES ('Chiến tranh', FALSE);
INSERT INTO NGUYENNHANMAT(TENNGUYENNHANMAT, DAXOA)
	VALUES ('Đột quỵ', FALSE);
INSERT INTO NGUYENNHANMAT(TENNGUYENNHANMAT, DAXOA)
	VALUES ('Chết đói/khát', FALSE);
INSERT INTO NGUYENNHANMAT(TENNGUYENNHANMAT, DAXOA)
	VALUES ('Chết đuối', FALSE);
INSERT INTO NGUYENNHANMAT(TENNGUYENNHANMAT, DAXOA)
	VALUES ('Chết ngạt', FALSE);
/*==============================================================*/
/* Table: QUEQUAN                                               */
/*==============================================================*/
CREATE TABLE QUEQUAN
(
   MAQUEQUAN            INT AUTO_INCREMENT,
   TENQUEQUAN           VARCHAR(50),
   DAXOA				BOOL,
   PRIMARY KEY (MAQUEQUAN)
);

ALTER TABLE QUEQUAN COMMENT 'Que Quan';

INSERT INTO QUEQUAN(TENQUEQUAN, DAXOA)
	VALUES ('Hà Nội', FALSE);
INSERT INTO QUEQUAN(TENQUEQUAN, DAXOA)
	VALUES ('Hồ Chí Minh', FALSE);
INSERT INTO QUEQUAN(TENQUEQUAN, DAXOA)
	VALUES ('Đà Nẵng', FALSE);
INSERT INTO QUEQUAN(TENQUEQUAN, DAXOA)
	VALUES ('Đà Lạt', FALSE);
	
/*==============================================================*/
/* Table: THANHVIEN                                             */
/*==============================================================*/
CREATE TABLE THANHVIEN
(
   MATHANHVIEN          INT AUTO_INCREMENT,
   MAQUEQUAN            INT NOT NULL,
   MALOAIQUANHE         INT,
   MANGHENGHIEP         INT,
   TENTHANHVIEN         VARCHAR(50) NOT NULL,
   THANHVIENCU          VARCHAR(50),
   NGAYPHATSINH         DATE NOT NULL,
   GIOITINH             BOOL NOT NULL,
   DIACHI               VARCHAR(50) NOT NULL,
   NGAYGIOSINH          DATE NOT NULL,
   TRANGTHAIMAT         BOOL,
   DOI                  BIGINT,
   PRIMARY KEY (MATHANHVIEN)
);

ALTER TABLE THANHVIEN COMMENT 'Thanh Vien';

/*==============================================================*/
/* Table: THANHVIENMAT                                          */
/*==============================================================*/
CREATE TABLE THANHVIENMAT
(
   MATHANHVIEN          INT NOT NULL,
   MANGUYENNHANMAT      INT,
   MADIADIEM            INT,
   NGAYGIOMAT           DATETIME,
   PRIMARY KEY (MATHANHVIEN)
);

ALTER TABLE THANHVIENMAT COMMENT 'Thanh Vien Mat';

INSERT INTO THANHVIEN(MAQUEQUAN, MALOAIQUANHE, MANGHENGHIEP, TENTHANHVIEN, THANHVIENCU, NGAYPHATSINH, GIOITINH, DIACHI, NGAYGIOSINH, TRANGTHAIMAT, DOI)
	VALUES (4, -1, 1, 'Võ Thanh Hiếu', '', '2020/07/17', TRUE, 'Đà Lạt', '1996/07/13', FALSE, 1);
INSERT INTO THANHVIEN(MAQUEQUAN, MALOAIQUANHE, MANGHENGHIEP, TENTHANHVIEN, THANHVIENCU, NGAYPHATSINH, GIOITINH, DIACHI, NGAYGIOSINH, TRANGTHAIMAT, DOI)
	VALUES (4, 1, 2, 'Võ Thanh Game Thủ', 'Võ Thanh Hiếu', '2020/07/17', TRUE, 'Đà Lạt', '2010/07/13', FALSE, 2);
INSERT INTO THANHVIEN(MAQUEQUAN, MALOAIQUANHE, MANGHENGHIEP, TENTHANHVIEN, THANHVIENCU, NGAYPHATSINH, GIOITINH, DIACHI, NGAYGIOSINH, TRANGTHAIMAT, DOI)
	VALUES (4, 1, 3, 'Võ Thanh Bờ Rồ', 'Võ Thanh Hiếu', '2020/07/17', TRUE, 'Đà Lạt', '2010/07/13', FALSE, 2);