-- Active: 1729062427921@@127.0.0.1@3306@ayam
create database ayam;
use ayam;
create table anggota(
    id_anggota bigint AUTO_INCREMENT primary key,
    kode_anggota char(10),
    nama_langkap varchar(50),
    alamat text,
    no_telpon varchar(13),
    jenis_kelamin enum ("L","P")
);
create table pengembalian(
    id_pengembalian int AUTO_INCREMENT primary key,
    tanggal_kembali date,
    jumlah_kembali TINYINT,
    id_buku int,
    id_anggota int,
    demda BIGINT,
    id_peminjaman BIGINT
);
create table buku(
    id_buku int AUTO_INCREMENT primary key,
    kode_buku char(5),
    judul_buku varchar(50),
    penulis_buku varchar(50),
    penerbit_buku varchar(50),
    tahun_terbit year,
    stok TINYINT
);
create table peminjaman(
    id_peminjaman int AUTO_INCREMENT primary key,
    tanggal_pinjam date,
    tanggal_kembali date,
    id_buku int,
    id_anggota int,
    jumlah_buku tinyint
);

insert into anggota(kode_anggota,nama_langkap,alamat,no_telpon,jenis_kelamin)VALUES
("KD1","Abdul Shalih","Bekasi",0812345678,"L"),
("KD2","Mira shaliha","Karawang",0887654321,"P");

insert into buku(kode_buku,judul_buku,penulis_buku,penerbit_buku,tahun_terbit,stok)VALUES
("KB01","Orang berharga","Bahirul","ShareBrain","2025-4-13",25),
("KB02","Satu Nama Yang sulit Dihapus","Darman","Gramedia","2025-5-22",30);


DELIMITER;

create trigger cek_peminjaman_buku
BEFORE INSERT
on peminjaman
FOR EACH ROW
BEGIN
    DECLARE jumlah_stok int;
    SET jumlah_stok = (SELECT stok FROM buku WHERE id_buku = NEW.id_buku);
    if jumlah_stok < new.jumlah_buku THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT ="stok buku tidak cukup";
    end if;

END&&

insert into peminjaman(tanggal_pinjam,tanggal_kembali,id_buku,id_anggota,jumlah_buku)VALUES
("2025-2-13","2025-2-18",1,001,30);


DELIMITER;

create trigger cek_buku
AFTER INSERT
ON peminjaman
FOR EACH ROW
BEGIN
    UPDATE buku set stok = stok -1 where id_buku = new.id_buku;
END&&

SELECT * FROM peminjaman;
