<?php

$conn = new mysqli(hostname: 'localhost', username: 'root', password: '', database: 'db_tokoBuku');

if ($conn->connect_error) {
    die("koneksi gagal:" . $conn->connect_error);
}

$query = "select * from books";

$hasil = $conn->query($query);

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
        <form action="" method="POST">
            <table class="table table-hover">
                <thead>
                    <tr>
                        <th>kode buku</th>
                        <th>judul</th>
                        <th>pengarang</th>
                        <th>penerbit</th>
                        <th>harga</th>
                        <th>stok</th>
                        <th>#</th>
                    </tr>
                </thead>
                <tbody>
                    <?php while ($item = $hasil->fetch_assoc()): ?>

                        <tr>
                            <td> <?php echo $item['kode_buku'] ?></td>
                            <td> <?php echo $item['judul'] ?></td>
                            <td> <?php echo $item['pengarang'] ?></td>
                            <td> <?php echo $item['penerbit'] ?></td>
                            <td> <?php echo $item['harga'] ?></td>
                            <td> <?php echo $item['stok'] ?></td>
                        </tr>

                    <?php endwhile; ?>
                </tbody>
            </table>
        </form>
    </div>
</body>

</html>