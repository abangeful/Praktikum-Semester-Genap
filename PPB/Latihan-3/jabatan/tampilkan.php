<?php
$con = new mysqli("localhost","root","","db_karyawan");

$tampil = "SELECT * FROM jabatan";

$hasil = $con->query($tampil);
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
    <br>
    <br>

    <div class="container">

        <form action="" method="POST">
            <table class="table">
                <thead class="table-dark">
                    <tr>
                        <th scope="col">ID Jabatan</th>
                        <th scope="col">Nama Jabatan</th>
                        <th scope="col">Gaji Pokok</th>
                    </tr>
                </thead>
                <tbody>
                    <?php while ($item = $hasil->fetch_assoc()): ?>

                            <tr>
                                <td> <?php echo $item['id_jabatan'] ?> </td>
                                <td> <?= $item['nama_jabatan'] ?> </td>
                                <td> <?= $item['gaji_pokok'] ?> </td>
                            </tr>

                    <?php endwhile; ?>
                </tbody>
            </table>
        </form>
    </div>

    <script src="../assets/bootstrap.js"></script>
</body>

</html>