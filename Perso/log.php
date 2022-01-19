<?php 
$ERREUR='';
if(isset($ERREURCONNECTION)){
    $ERREUR='<p class="warning">'.$ERREURCONNECTION.'</p>';
}
?>
<?php
if($_POST['username']=='deathmugnier@gmail.com' && $_POST['password']=='Wardeathstrifefury1')
{
include('index.html');
}
else
{
    $ERREURCONNECTION='Login ou Mot de passe incorrect';
	include('Login.php');
}
?>

