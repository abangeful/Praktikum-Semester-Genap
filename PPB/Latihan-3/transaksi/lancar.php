<?php

$koneksi = new mysqli("localhost","root","","tokoapp");
$query = "select * from books";
$buku = $koneksi->query($query);

$isibuku =[];
while ($data = $buku->fetch_assoc()){
    $isibuku[] = $data;
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <div class="container">
        <table class="table table-sm table-bordered">
            <thead>
                <tr>
                    <th>kode buku</th>
                    <th>judul</th>
                    <th>penerbit</th>
                    <th>harga</th>
                    <th>jumlah</th>
                    <th>subtotal</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td><input type="text" name="" id="kode_buku" class="form-control form-control-sm"
                            list="list_kode_buku">
                        <datalist id="list_kode_buku">
                            
                        </datalist>
                    </td>
                    <td><input type="text" name="" id="judul" class="form-control form-control-sm" disabled></td>
                    <td><input type="text" name="" id="penerbit" class="form-control form-control-sm" disabled></td>
                    <td><input type="text" name="" id="harga" class="form-control form-control-sm" disabled></td>
                    <td><input type="text" name="" id="jumlah" class="form-control form-control-sm"></td>
                    <td><input type="text" name="" id="subtotal" class="form-control form-control-sm" disabled></td>
                </tr>
            </tbody>
        </table>
    </div>
    <script>
        let daftar_buku = <?= json_encode($listbuku)?>;
        let bukudipilih = {}

        document.getElementById("kode_buku").oninput = function () {
            let kode_buku = document.getElementById("kode_buku").value
            let filterBuku = daftar_buku.filter()
        }
    </script>
</body>
</html>