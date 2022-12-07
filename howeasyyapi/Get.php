<?php
include_once('./config/config.php');

$sql = "SELECT * FROM users";
if(isset($_GET['sql'])) {
    $sql = $_GET['sql'];
} 

$result = $conn->query($sql);
$output = array();
 while($row = $result->fetch_assoc()) {
  $output[] = $row;
  }

echo json_encode($output);

?>