<?php 

if ( isset($_FILES['image_file'])) {
	$img_name = $_FILES['image_file']['name'];
	$img_size = $_FILES['image_file']['size'];
	$tmp_name = $_FILES['image_file']['tmp_name'];
	$error = $_FILES['image_file']['error'];

	if ($error === 0) {
		$img_ex = pathinfo($img_name, PATHINFO_EXTENSION);
			$img_ex_lc = strtolower($img_ex);

			$allowed_exs = array("jpg", "jpeg", "png"); 

			if (in_array($img_ex_lc, $allowed_exs)) {
				$new_img_name = uniqid("IMG-", true).'.'.$img_ex_lc;
				$img_upload_path = 'upload/'.$new_img_name;
				move_uploaded_file($tmp_name, $img_upload_path);

                echo $img_upload_path;
			}else {
                
			}
	}else {
        $em = "error!";
        echo $em;        
	}

}else {
    $em = "No image!";
    echo $em;        
}