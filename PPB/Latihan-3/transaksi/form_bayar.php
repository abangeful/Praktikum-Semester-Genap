<?php
$koneksi = new mysqli("localhost", "root", "", "tokoapp");

$query = "SELECT * FROM books";
$buku = $koneksi->query($query);
$listbuku = [];
while ($data = $buku->fetch_assoc()) {
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
                    <th></th>
                </tr>
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
                    <td>
                        <button id="tambah-item" class="btn btn-primary btn-sm">+</button>
                    </td>
                </tr>
            </thead>
            <tbody id="list-item">
                
            </tbody>
        </table>
    </div>

    <script>
        let daftar_buku = <?= json_encode($listbuku) ?>;
        let bukudipilih = {}
        let itembuku = []
        // MENAMBAHKAN LIST BUKU PADA DATA LIST
        document.getElementById("kode_buku").oninput = function () {
            let kode_buku = document.getElementById("kode_buku").value
            let filterBuku = daftar_buku.filter(buku => buku.kode_buku.includes(kode_buku))
            if (filterBuku.length > 0) {
                filterBuku = filterBuku.slice(0, 5)
                document.getElementById("list_kode_buku").innerHTML = filterBuku.map(buku => `<option value="${buku.kode_buku}">${buku.kode_buku}-${buku.judul}</option>`).join("")
            }
        }
        // event textbox jumlah
        document.getElementById("jumlah").onfocus = ()=>{
            let kode_buku = document.getElementById("kode_buku").value
            bukudipilih = daftar_buku.find(ikan => ikan.kode_buku === kode_buku)
            // isi textbox judul,penerbit dan harga
            document.getElementById("judul").value = bukudipilih.judul
            document.getElementById("penerbit").value = bukudipilih.penerbit
            document.getElementById("harga").value = parseInt(bukudipilih.harga).toLocaleString()
        }
        document.getElementById("jumlah").oninput=()=>{
            let jumlah = document.getElementById("jumlah").value
            let subtotal = jumlah * bukudipilih.harga
            document.getElementById("subtotal").value = parseInt(subtotal).toLocaleString()
        }

        document.getElementById("tambah-item").onclick = ()=>{
            itembuku.push(bukudipilih)
            // kosongkan tbody
            document.getElementById("list-item").innerHTML =""
            // siapkan iss list item buku
            let isi_buku =""
            itembuku.forEach(buku =>{
                isi_buku+=`
                    <tr>
                    <td><input type="text" name="" id="kode_buku" class="form-control form-control-sm" readonly value="${buku.kode_buku}">                                               
                    </td>
                    <td><input type="text" name="" id="judul" class="form-control form-control-sm" readonly value="${buku.judul}"></td>
                    <td><input type="text" name="" id="penerbit" class="form-control form-control-sm" readonly value="${buku.penerbit}"></td>
                    <td><input type="text" name="" id="harga" class="form-control form-control-sm" readonly value="${document.getElementById("harga").value}"></td>
                    <td><input type="text" name="" id="jumlah" class="form-control form-control-sm" value="${document.getElementById("jumlah").value}" readonly></td>
                    <td><input type="text" name="" id="subtotal" class="form-control form-control-sm" readonly value="${document.getElementById("subtotal").value}"></td>
                    <td>
                        <button id="tambah-item" class="btn btn-primary btn-sm">-</button>
                    </td>
                </tr>
                `
            })
            // isi tbody dengan list buku
            document.getElementById("list-item").innerHTML=isi_buku
            document.getElementById("kode_buku").value=""
            document.getElementById("judul").value=""
            document.getElementById("penerbit").value=""
            document.getElementById("harga").value=""
            document.getElementById("jumlah").value=""
            document.getElementById("subtotal").value=""

        }
    </script>
</body>

</html>