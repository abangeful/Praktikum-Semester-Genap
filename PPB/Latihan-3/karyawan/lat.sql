create database caca;
use caca;
create table karyawan(
    id_karyawan int primary key,
    nama varchar(100),
    tanggal_lahir date,
    jenis_kelamin enum("L", "P"),
    id_jabatan int
)

create table jabatan(
    id_jabatan int primary key auto_increment,
    nama_jabatan varchar(50),
    gaji_pokok decimal(10,2)
)

create table gaji(
    id_gaji int primary key,
    id_karyawan int,
    FOREIGN KEY (id_karyawan) REFERENCES karyawan(id_karyawan),
    bulan int,
    tahun year,
    jumlah_absensi int,
    tunjangan decimal(10,2),
    total_gaji decimal(10,2)
)

create table absensi(
    id_absensi int primary key,
    id_karyawan int,
    FOREIGN KEY (id_karyawan) REFERENCES karyawan(id_karyawan),
    tanggal date,
    jam_masuk time,
    jam_keluar time
)

drop table jabatan;