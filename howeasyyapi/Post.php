<?php
include_once('./config/config.php');

$sql = "SELECT * FROM users";
if(isset($_GET['sql'])) {
    $sql = $_GET['sql'];
} 

if ($conn->query($sql) === TRUE) {
  echo "Success";
} else {
  echo "Error: " . $sql .  $conn->error;
}
$conn->close();
exit();
?>