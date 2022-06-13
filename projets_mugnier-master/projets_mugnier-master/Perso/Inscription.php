<?php
  $ErreurAAfficher='';
  if(isset($Erreur))
  {
    $ErreurAAfficher=" ".$Erreur." ";
  }

?><!doctype html>
<html>
<html>
<head>
	<meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
  <meta name="description" content="">
  <meta name="author" content="">

  <title>Apache2 Ubuntu Default Page</title>
  <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">

  <link href="vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css">
  <link href='https://fonts.googleapis.com/css?family=Lora:400,700,400italic,700italic' rel='stylesheet' type='text/css'>
  <link href='https://fonts.googleapis.com/css?family=Open+Sans:300italic,400italic,600italic,700italic,800italic,400,300,600,700,800' rel='stylesheet' type='text/css'>

  <link href="css/clean-blog.min.css" rel="stylesheet">

  <title>Apache2 Ubuntu Default Page</title>
  <link rel="stylesheet" type="text/css" href="css/CCS.css">
<div id="bandeau">
	<div id="site"></div>
	<div id="sitehidden"></div>
	<a href="Index.php"><div id="home"><g> Home </g></div></a>
	<a href="Vente.html"><div id="vente"><g> Vente </g></div></a>
	<a href="Gallery.html"><div id="gallery"><g> Gallery </g></div></a>
	<a href="Login.php"><div id="login"><g> Login </g></div></a>
	</div>
<meta charset="utf-8">
</head>
<body>
<div class="wrapper">
<div id="background1">
  <section class="login-container">
    <div>
      <header>
        <h2>Inscripton</h2>
      </header>
      <form action="TraitementInscription.php" method="POST">
          <br>
          <input type="text" name="username" placeholder="Nom d'utilisateur" required="required" />
          <input type="text" name="adressemail" placeholder="Adresse mail" required="required" />
		  <input type="text" name="prenom" placeholder="Prénom" required="required" />
          <input type="text" name="nom" placeholder="Nom" required="required" />
          <input type="text" name="datedenaissance" placeholder="Date de naissance" required="required" />
          <input type="text" name="age" placeholder="Age" required="required" />
          <input type="password" name="password" placeholder="Mot de passe" required="required" />
          <input type="password" name="password2" placeholder="Confirmation du mot de passe" required="required" /><br><?php  echo($ErreurAAfficher)?><br>
          <button type="submit">Inscription</button>
          <a href="Index.php">Connection</a>
      </form>
    </div>
	  
  </section>
</div>
</div>
</body>
</html>
