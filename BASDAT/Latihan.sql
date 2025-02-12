-- Active: 1729062427921@@127.0.0.1@3306@am
create database lat;
use lat;
CREATE Table tabel_barang (
    id_barang VARCHAR(10) PRIMARY KEY,
    nama_barang VARCHAR(50),
    stok INT
);

ALTER TABLE tabel_barang ADD COLUMN harga INT NOT NULL DEFAULT 0;


CREATE TABLE tabel_pembelian (
    id_pembelian INT PRIMARY KEY,
    id_barang VARCHAR(10),
    jumlah_beli INT,
    Foreign Key (id_barang) REFERENCES tabel_barang (id_barang)
);

CREATE TABLE pembayaran(
    id_pembayaran int PRIMARY KEY AUTO_INCREMENT,
    jumlah int,
    id_pembelian INT,
    Foreign Key (id_pembelian) REFERENCES tabel_pembelian(id_pembelian)
);

CREATE TABLE log_pembelian(
    id_log int AUTO_INCREMENT PRIMARY KEY,
    waktu TIMESTAMP,
    operasi VARCHAR(255)
);

INSERT INTO
    tabel_barang (id_barang, nama_barang, stok)
VALUES ("A10", "Mouse", 10),
    ("A11", "Keyboard", 15),
    ("A12", "DVD-RW", 19);


DELIMITER &&
create trigger cek_stok_barang
before INSERT
on tabel_pembelian
for each row
BEGIN
    -- siapkan variabel jumlah stok untuk menyimpan jumlah stok barang
    DECLARE jumlah_stok int;
    -- ambil jumlah stok barang dari tabel_barang
    -- cara 1 : menggunakan set
    SET jumlah_stok = (SELECT stok FROM tabel_barang WHERE id_barang = NEW.id_barang);
    -- cara 2 : menggunakan select into
    -- SELECT stok INTO jumlah_stok FROM tabel_barang WHERE id_barang = NEW.id_barang;
    -- cek apakah jumlah stok barang cukup
    IF jumlah_stok < new.jumlah_beli then
        -- jika tidak cukup, maka batalkan INSERT
        signal sqlstate '45000'
        -- kirim pesan
        SET message_text ="stok barang tidak cukup";
    end if;
END&&

DELIMITER ;
insert into tabel_pembelian(id_pembelian,id_barang,jumlah_beli)
values (1,"A10",20);