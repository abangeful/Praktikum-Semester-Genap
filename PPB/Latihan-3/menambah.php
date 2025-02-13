<?php
$nek = new mysqli(hostname: 'localhost', username: 'root', password: '', database: 'db_tokoBuku');

if ($nek->connect_error) {
    die("koneksi gagal:" . $conn->connect_error);
}

if (isset($_POST['kode_buku'])) {
    $kode_buku = $_POST['kode_buku'];
    $judul = $_POST['judul'];
    $pengarang = $_POST['pengarang'];
    $penerbit = $_POST['penerbit'];
    $harga = $_POST['harga'];
    $stok = $_POST['stok'];

    $hasil = $nek->query("insert into books(kode_buku,judul,pengarang,penerbit,harga,stok)values('$kode_buku','$judul','$pengarang','$penerbit',$harga,'$stok')");
}
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="./assets/bootstrap.css">
</head>

<body>
    <div class="form-floating mb-3">
        <input type="text" class="form-control" id="kode_buku" placeholder="">
        <label for="kodebook">kode buku</label>
    </div>
    <div class="form-floating">
        <input type="text" class="form-control" id="judul" placeholder="">
        <label for="judulbuku">judul</label>
    </div>
    <div class="form-floating">
        <input type="text" class="form-control" id="pengarang" placeholder="">
        <label for="ngarang">pengarang</label>
    </div>
    <div class="form-floating">
        <input type="text" class="form-control" id="penerbit" placeholder="">
        <label for="terbit">penerbit</label>
    </div>
    <div class="form-floating">
        <input type="number" class="form-control" id="harga" placeholder="">
        <label for="harga">harga</label>
    </div>
    <div class="form-floating">
        <input type="text" class="form-control" id="stok" placeholder="">
        <label for="stok">stok</label>
    </div>
    <button type="button" class="btn btn-info">Simpan</button>
    <script src="./assets/bootstrap.js"></script>
</body>

</html>