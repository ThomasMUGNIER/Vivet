<!doctype html>
<html>
<head>
<?php
$Host    = "127.0.0.1";
$user    = "root";
$pass    = "1234";
$db_name = "seraphin";

//create connection
$connection = mysqli_connect($Host, $user, $pass, $db_name);

//test if connection failed
if(mysqli_connect_errno()){
    die("connection failed: "
        . mysqli_connect_error()
        . " (" . mysqli_connect_errno()
        . ")");
}
?>
	<meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
  <meta name="description" content="">
  <meta name="author" content="">
  <link href="css/clean-blog.min.css" rel="stylesheet">
  <link rel="stylesheet" type="text/css" href="css/CCS.css">
	<div id=bandeau>
    <class =image></class>
	<a href="Index.html"><div id="home"><g> Home </g></div></a>
	<a href="Vente.html"><div id="vente"><g> Vente </g></div></a>
	<a href="Gallery.html"><div id="gallery"><g> Gallery </g></div></a>
	<a href="Login.html"><div id="login"><g> Login </g></div></a>
	</div>
<meta charset="utf-8">
</head>
<body>
<div class="wrapper">
<div id="background1">
  <section class="login-container">
    <div>
      <header>
        <h2>Connection</h2>
      </header>
      <form action="log.php" method="post"><br>
        <input type="text" name="username" placeholder="Nom d'utilisateur" required="required" />
        <input type="password" name="password" placeholder="Mot de passe" required="required" /><br><br>
        <button type="submit">Connection</button>
		<a href="Inscription.html">Inscription</a>
      </form>
    </div>
	  
  </section>
</div>
</div>
</body>
</html>
