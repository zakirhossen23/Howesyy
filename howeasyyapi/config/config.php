<?php
$servername = "localhost";
$username = "howeasyy_howeasyy";
$password = "Glashen2023!";
$database = "howeasyy_howeasyy";

// Create connection
$conn = new mysqli($servername, $username, $password,$database);

// Check connection
if ($conn->connect_error) {
  die("Connection failed: " . $conn->connect_error);
}
?>