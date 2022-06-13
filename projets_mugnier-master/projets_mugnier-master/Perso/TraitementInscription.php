<?php
    $Erreur='';
    //print_r($_POST);
    if($_POST['password2']==$_POST['password'])
    {
        include('Index.php');
    }
    else
    {
        $Erreur="Veuillez retaper votre mot de passe il ne sont pas identique";
        include('Inscription.php');
    }



?>