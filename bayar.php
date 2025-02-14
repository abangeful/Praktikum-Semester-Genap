<?php
$koneksi = new mysqli("localhost","root","","db_tokoBuku");

$query = "SELECT * FROM books";
$buku = $koneksi->query($query);
$listbuku =[];
while($data = $buku->fetch_assoc()){
    $listbuku[] = $data;
}
?>


<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="../assets/bootstrap.css">
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
                    <td><input type="text" name="" id="kode_buku" class="form-control form-control-sm" list="list_kode_buku">
                    <datalist id="list_kode_buku">
                        <option value="KB001">KB001 - struktur basis data</option>
                        <option value="KB002">KB002 - PBO</option>
                        <option value="KB003">KB003 - WEB</option>
                        
                    </datalist>
                </td>
                    <td><input type="text" name="" id="judul" class="form-control form-control-sm"></td>
                    <td><input type="text" name="" id="penerbit" class="form-control form-control-sm"></td>
                    <td><input type="text" name="" id="harga" class="form-control form-control-sm"></td>
                    <td><input type="text" name="" id="jumlah" class="form-control form-control-sm"></td>
                    <td><input type="text" name="" id="subtotal" class="form-control form-control-sm"></td>
                </tr>
            </tbody>
        </table>
    </div>

<script>
    let daftar_buku = <?= json_encode($listbuku)?>
    document.getElementById("kode_buku") oninput= function(){
        let kode_buku = this.value
        let filterBuku = daftar_buku.filter(buku=>buku.kode_buku.includes(kode))
        if(filterBuku.length >0){
            filterBuku = filterBuku.slice(0,5)
            document.getElementById("list_kode_buku").innerHTML=filterBuku.map(buku=>'<option value="${buku.kode_buku}">${buku.kode_buku}-${buku.judul}</option>').join("")
        }
    }
</script>
</body>
</html>