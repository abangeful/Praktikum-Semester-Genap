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
    <link rel="stylesheet" href="../assets/bootstrap.js">
</head>

<body>
    <div class="form-floating mb-3">
        <input type="email" class="form-control" id="floatingInput" placeholder="name@example.com">
        <label for="floatingInput">kode buku</label>
    </div>
    <div class="form-floating">
        <input type="password" class="form-control" id="floatingPassword" placeholder="Password">
        <label for="floatingPassword">judul</label>
    </div>
    <div class="form-floating mb-3">
        <input type="email" class="form-control" id="floatingInput" placeholder="name@example.com">
        <label for="floatingInput">pengarang</label>
    </div>
    <div class="form-floating">
        <input type="password" class="form-control" id="floatingPassword" placeholder="Password">
        <label for="floatingPassword">penerbit</label>
    </div>
    <div class="form-floating mb-3">
        <input type="email" class="form-control" id="floatingInput" placeholder="name@example.com">
        <label for="floatingInput">harga</label>
    </div>
    <div class="form-floating">
        <input type="password" class="form-control" id="floatingPassword" placeholder="Password">
        <label for="floatingPassword">stok</label>
    </div>
</body>

</html>