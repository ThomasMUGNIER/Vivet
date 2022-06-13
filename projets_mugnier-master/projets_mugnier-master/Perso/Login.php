<?php
  $ErreurAAfficher='';
  if(isset($Erreur))
  {
    $ErreurAAfficher=" ".$Erreur." ";
  }

?>
<html>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">
    <link href="css/clean-blog.min.css" rel="stylesheet">
    <link rel="stylesheet" type="text/css" href="css/CCS.css">
    <div id=bandeau>
        <class =image></class>
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
                        <h2>Connection</h2><?php  echo($ErreurAAfficher)?>
                    </header>
                    <form action="Traitement.php" method="post">
                        <br>
                        <input type="text" name="username" placeholder="Nom d'utilisateur" required="required" />
                        <input type="password" name="password" placeholder="Mot de passe" required="required" /><br><br>
                        <button type="submit">Connection</button>
                        <a href="Inscription.php">Inscription</a>
                    </form>
                </div>

            </section>
        </div>
    </div>
</body>
</html>