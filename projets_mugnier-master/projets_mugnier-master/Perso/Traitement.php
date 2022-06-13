<?php
    $Erreur='';
    //print_r($_POST);
    if($_POST['username']=='deathmugnier@gmail.com' && $_POST['password']=='123456')
    {
        include('Index.php');
    }
    else
    {
        $Erreur="le login est erronné";
        include('Login.php');
    }



?>