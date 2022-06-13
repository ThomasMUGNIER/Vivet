-- Permet d'ajouter des valeurs à la table interlocuteur --

/*INSERT INTO interlocuteur (code_interlocuteur, nom_interlocuteur)
VALUES
(@code_syndicat, @nom_syndicat);*/

-- Initialise la boucle --
DO $$
	-- Déclare les variables --
	DECLARE v_max integer := 10;
			v_counter integer := 0;
			code integer := 0;
			interlocuteur char(100);

	-- Commence la boucle --
	BEGIN
	WHILE v_counter < v_max LOOP
		-- Défini les variables en fonction de v_counter --
		code := (v_counter + 1);
		interlocuteur := CONCAT('Interlocuteur ', CAST((v_counter + 1) AS CHAR(100)));
		-- Insère les valeurs dans la table --
		INSERT INTO interlocuteur (code_interlocuteur, nom_interlocuteur)
		VALUES
		(
			code,
			interlocuteur
		);
		-- Ajoute un tour au compteur --
		v_counter = (v_counter + 1);
	END LOOP;
END $$;


-- Permet d'ajouter des valeurs à la table bureau --

/*INSERT INTO bureau (code_bureau, ville_bureau, pays)
VALUES
(@code_bureau, @ville_bureau, @pays);*/

-- Initialise la boucle --
DO $$
	-- Déclare les variables --
	DECLARE v_max integer := 5;
			v_counter integer := 0;
			code integer := 0;
			ville char(100);
			pays_bureau char(100);

	-- Commence la boucle --
	BEGIN
	WHILE v_counter < v_max LOOP
		-- Défini les variables en fonction de v_counter --
		code := (v_counter + 1);
		ville := CONCAT('Ville ', CAST((v_counter + 1) AS CHAR(100)));
		pays_bureau := CONCAT('Pays ', CAST((v_counter + 1) AS CHAR(100)));
		-- Insère les valeurs dans la table --
		INSERT INTO bureau (code_bureau, ville_bureau, pays)
		VALUES
		(
			code,
			ville,
			pays_bureau
		);
		-- Ajoute un tour au compteur --
		v_counter = (v_counter + 1);
	END LOOP;
END $$;


-- Permet d'ajouter des valeurs à la table contacter --

/*INSERT INTO contacter (code_bureau, code_interlocuteur, date, commentaire)
VALUES
(@code_bureau, @code_interlocuteur, @date, @commentaire);*/

-- Initialise la boucle --
DO $$
	-- Déclare les variables --
	DECLARE v_max integer := 50;
			v_counter integer := 0;
			code_b integer := 0;
			code_i integer := 0;
			date_contacter date;
			commentaire_contacter varchar(255);

	-- Commence la boucle --
	BEGIN
	WHILE v_counter < v_max LOOP
		-- Défini les variables en fonction de v_counter --
		code_b := ROUND ( RANDOM() * 4 ) + 1;
		code_i := ROUND ( RANDOM() * 9 ) + 1;
		date_contacter := CURRENT_DATE; -- N'arrive pas à insérer les valeurs si la date est identique // Modifier pour mettre une date aléatoire --
		commentaire_contacter := CONCAT('Commentaire ', CAST((v_counter + 1) AS CHAR(255)));
		-- Insère les valeurs dans la table --
		INSERT INTO contacter (code_bureau, code_interlocuteur, date, commentaire)
		VALUES
		(
			code_b,
			code_i,
			date_contacter,
			commentaire_contacter
		);
		-- Ajoute un tour au compteur --
		v_counter = (v_counter + 1);
	END LOOP;
END $$;


-- Permet d'ajouter des valeurs à la table secteur --

/*INSERT INTO secteur (code_secteur, libelle_secteur)
VALUES
(@code_secteur, @libelle_secteur);*/

-- Initialise la boucle --
DO $$
	-- Déclare les variables --
	DECLARE v_max integer := 4;
			v_counter integer := 0;
			code integer := 0;
			secteur char(100);

	-- Commence la boucle --
	BEGIN
	WHILE v_counter < v_max LOOP
		-- Défini les variables en fonction de v_counter --
		code := (v_counter + 1);
		secteur := CONCAT('Secteur ', CAST((v_counter + 1) AS CHAR(100)));
		-- Insère les valeurs dans la table --
		INSERT INTO secteur (code_secteur, libelle_secteur)
		VALUES
		(
			code,
			secteur
		);
		-- Ajoute un tour au compteur --
		v_counter = (v_counter + 1);
	END LOOP;
END $$;


-- Permet d'ajouter des valeurs à la table client --

/*INSERT INTO client (code_client, raison_sociale_client, adresse_client)
VALUES
(@code_client, @raison_sociale_client, adresse_client);*/

-- Initialise la boucle --
DO $$
	-- Déclare les variables --
	DECLARE v_max integer := 20;
			v_counter integer := 0;
			code integer := 0;
			raison_sociale char(100);
			adresse char(255);

	-- Commence la boucle --
	BEGIN
	WHILE v_counter < v_max LOOP
		-- Défini les variables en fonction de v_counter --
		code := (v_counter + 1);
		raison_sociale := CONCAT('Raison Sociale ', CAST((v_counter + 1) AS CHAR(100)));
		adresse := CONCAT('Adresse ', CAST((v_counter + 1) AS CHAR(255)));
		-- Insère les valeurs dans la table --
		INSERT INTO client (code_client, raison_sociale_client, adresse_client)
		VALUES
		(
			code,
			raison_sociale,
			adresse
		);
		-- Ajoute un tour au compteur --
		v_counter = (v_counter + 1);
	END LOOP;
END $$;


-- Permet d'ajouter des valeurs à la table exercer --

/*INSERT INTO exercer (code_client, code_secteur)
VALUES
(@code_client, @code_secteur);*/

-- Initialise la boucle --
DO $$
	-- Déclare les variables --
	DECLARE v_max integer := 30;
			v_counter integer := 0;
			code_c integer := 0;
			code_s integer := 0;

	-- Commence la boucle --
	BEGIN
	WHILE v_counter < v_max LOOP
		-- Défini les variables en fonction de v_counter --
		code_c := ROUND ( RANDOM() * 19 ) + 1;
		code_s := ROUND ( RANDOM() * 3 ) + 1;
		-- Insère les valeurs dans la table --
		INSERT INTO exercer (code_client, code_secteur)
		VALUES
		(
			code_c,
			code_s
		);
		-- Ajoute un tour au compteur --
		v_counter = (v_counter + 1);
	END LOOP;
END $$;


-- Permet d'ajouter des valeurs à la table contrat --

/*INSERT INTO contrat (ref_contrat, objet_contrat, date_contrat, taux_commission, montant_contrat, code_bureau, code_client, code_interlocuteur)
VALUES
(@ref_contrat, @objet_contrat, @date_contrat, @taux_commission, @montant_contrat, @code_bureau, @code_client, @code_interlocuteur);*/

-- Initialise la boucle --
DO $$
	-- Déclare les variables --
	DECLARE v_max integer := 30;
			v_counter integer := 0;
			ref integer := 0;
			objet char(255);
			date_c date;
			taux numeric := 0;
			montant integer := 0;
			code_b integer := 0;
			code_c integer := 0;
			code_i integer := 0;

	-- Commence la boucle --
	BEGIN
	WHILE v_counter < v_max LOOP
		-- Défini les variables en fonction de v_counter --
		ref := (v_counter + 1);
		objet := CONCAT('Objet ', CAST((v_counter + 1) AS CHAR(255)));
		date_c := CURRENT_DATE;
		taux := (RANDOM() * 19 ) + 1;
		montant := (RANDOM() * 9999 ) + 1;
		code_b := ROUND ( RANDOM() * 4 ) + 1;
		code_c := ROUND ( RANDOM() * 19 ) + 1;
		code_i := ROUND ( RANDOM() * 9 ) + 1;
		-- Insère les valeurs dans la table --
		INSERT INTO contrat (ref_contrat, objet_contrat, date_contrat, taux_commission, montant_contrat, code_bureau, code_client, code_interlocuteur)
		VALUES
		(
			ref,
			objet,
			date_c,
			taux,
			montant,
			code_b,
			code_c,
			code_i

		);
		-- Ajoute un tour au compteur --
		v_counter = (v_counter + 1);
	END LOOP;
END $$;