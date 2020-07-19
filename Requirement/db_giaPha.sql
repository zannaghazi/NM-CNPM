/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     7/19/2020 12:58:24 PM                        */
/*==============================================================*/


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
   MADD                 INT NOT NULL,
   TENDIADIEMMAITANG    VARCHAR(50),
   DAXOA                BOOL,
   PRIMARY KEY (MADD)
);

ALTER TABLE DIADIEMMAITANG COMMENT 'Dia Diem Mai Tang';

/*==============================================================*/
/* Table: LOAIQUANHE                                            */
/*==============================================================*/
CREATE TABLE LOAIQUANHE
(
   MALOAIQUANHE         INT NOT NULL,
   TENLOAIQUANHE        VARCHAR(50),
   DAXOA                BOOL,
   PRIMARY KEY (MALOAIQUANHE)
);

ALTER TABLE LOAIQUANHE COMMENT 'Loai Quan He';

/*==============================================================*/
/* Table: LOAITHANHTICH                                         */
/*==============================================================*/
CREATE TABLE LOAITHANHTICH
(
   MALOAITHANHTICH      INT NOT NULL,
   TENLOAITHANHTICH     VARCHAR(50),
   DAXOA                BOOL,
   PRIMARY KEY (MALOAITHANHTICH)
);

ALTER TABLE LOAITHANHTICH COMMENT 'Loai Thanh Tich';

/*==============================================================*/
/* Table: NGHENGHIEP                                            */
/*==============================================================*/
CREATE TABLE NGHENGHIEP
(
   MANGHENGHIEP         INT NOT NULL,
   TENNGHENGHIEP        VARCHAR(50),
   DAXOA                BOOL,
   PRIMARY KEY (MANGHENGHIEP)
);

ALTER TABLE NGHENGHIEP COMMENT 'Nghe Nghiep';

/*==============================================================*/
/* Table: NGUYENNHANMAT                                         */
/*==============================================================*/
CREATE TABLE NGUYENNHANMAT
(
   MANGUYENNHANMAT      INT NOT NULL,
   TENNGUYENNHANMAT     VARCHAR(50),
   DAXOA                BOOL,
   PRIMARY KEY (MANGUYENNHANMAT)
);

ALTER TABLE NGUYENNHANMAT COMMENT 'Nguyen Nhan Mat';

/*==============================================================*/
/* Table: QUEQUAN                                               */
/*==============================================================*/
CREATE TABLE QUEQUAN
(
   MAQUEQUAN            INT NOT NULL,
   TENQUEQUAN           VARCHAR(50),
   DAXOA                BOOL,
   PRIMARY KEY (MAQUEQUAN)
);

ALTER TABLE QUEQUAN COMMENT 'Que Quan';

/*==============================================================*/
/* Table: THANHVIEN                                             */
/*==============================================================*/
CREATE TABLE THANHVIEN
(
   MATHANHVIEN          INT NOT NULL,
   MAQUEQUAN            INT NOT NULL,
   MALOAIQUANHE         INT NOT NULL,
   MANGHENGHIEP         INT,
   TENTHANHVIEN         VARCHAR(50) NOT NULL,
   THANHVIENCU          VARCHAR(50),
   NGAYPHATSINH         DATE NOT NULL,
   GIOITINH             BOOL NOT NULL,
   DIACHI               VARCHAR(50) NOT NULL,
   NGAYGIOSINH          DATETIME NOT NULL,
   TRANGTHAIMAT         BOOL,
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
   MADD                 INT,
   NGAYGIOMAT           DATETIME,
   PRIMARY KEY (MATHANHVIEN)
);

ALTER TABLE THANHVIENMAT COMMENT 'Thanh Vien Mat';

ALTER TABLE CHITIETTHANHTICH ADD CONSTRAINT FK_REFERENCE_1 FOREIGN KEY (MATHANHVIEN)
      REFERENCES THANHVIEN (MATHANHVIEN) ON DELETE RESTRICT ON UPDATE RESTRICT;

ALTER TABLE CHITIETTHANHTICH ADD CONSTRAINT FK_REFERENCE_2 FOREIGN KEY (MALOAITHANHTICH)
      REFERENCES LOAITHANHTICH (MALOAITHANHTICH) ON DELETE RESTRICT ON UPDATE RESTRICT;

ALTER TABLE THANHVIEN ADD CONSTRAINT FK_REFERENCE_3 FOREIGN KEY (MAQUEQUAN)
      REFERENCES QUEQUAN (MAQUEQUAN) ON DELETE RESTRICT ON UPDATE RESTRICT;

ALTER TABLE THANHVIEN ADD CONSTRAINT FK_REFERENCE_4 FOREIGN KEY (MALOAIQUANHE)
      REFERENCES LOAIQUANHE (MALOAIQUANHE) ON DELETE RESTRICT ON UPDATE RESTRICT;

ALTER TABLE THANHVIEN ADD CONSTRAINT FK_REFERENCE_5 FOREIGN KEY (MANGHENGHIEP)
      REFERENCES NGHENGHIEP (MANGHENGHIEP) ON DELETE RESTRICT ON UPDATE RESTRICT;

ALTER TABLE THANHVIENMAT ADD CONSTRAINT FK_REFERENCE_10 FOREIGN KEY (MADD)
      REFERENCES DIADIEMMAITANG (MADD) ON DELETE RESTRICT ON UPDATE RESTRICT;

ALTER TABLE THANHVIENMAT ADD CONSTRAINT FK_REFERENCE_8 FOREIGN KEY (MATHANHVIEN)
      REFERENCES THANHVIEN (MATHANHVIEN) ON DELETE RESTRICT ON UPDATE RESTRICT;

ALTER TABLE THANHVIENMAT ADD CONSTRAINT FK_REFERENCE_9 FOREIGN KEY (MANGUYENNHANMAT)
      REFERENCES NGUYENNHANMAT (MANGUYENNHANMAT) ON DELETE RESTRICT ON UPDATE RESTRICT;

