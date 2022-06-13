---
title: "TP2 - Base de données"
author:
  - Solène CAGNOLATI
date: 22/02/2022
keywords:
  - SLAM
  - Vivet
  - TP
  - Base de données
  - PostgreSQL

...

# TP2 - Base de données

![0ccdaf3002a1f2a863278b70254bc572.png](0ccdaf3002a1f2a863278b70254bc572.png)

## Requêtes.
- **Liste des secteurs triés par odre alphabétique** :
    - SELECT secteur.libelle_secteur FROM secteur ORDER BY secteur.libelle_secteur ASC;

- **Liste des clients par secteur triée par secteur et par client** :
    - SELECT secteur.libelle_secteur, client.raison_sociale_client FROM secteur, client, exercer WHERE exercer.code_client = client.code_client AND exercer.code_secteur = secteur.code_secteur GROUP BY secteur.libelle_secteur, client.raison_sociale_client ORDER BY secteur.libelle_secteur, client.raison_sociale_client; 

- **Liste des appels au mois de juillet 2013 triée par date et interlocuteur** :
    - SELECT contacter.date, interlocuteur.nom_interlocuteur, bureau.ville_bureau FROM contacter, interlocuteur, bureau WHERE contacter.code_interlocuteur = interlocuteur.code_interlocuteur AND contacter.code_bureau = bureau.code_bureau AND contacter.date BETWEEN '01/07/2013' AND '31/07/2013' ORDER BY contacter.date, interlocuteur.nom_interlocuteur;

- **Nombres d’appels en janvier 2012** :
    - SELECT COUNT(contacter.date) FROM contacter WHERE contacter.date BETWEEN '01/01/2012' AND '31/12/2012';

- **Nombre de clients par secteur** :
    - SELECT COUNT(client.code_client) as nombre, secteur.libelle_secteur FROM client, secteur, exercer WHERE exercer.code_client = client.code_client AND exercer.code_secteur = secteur.code_secteur GROUP BY secteur.libelle_secteur ORDER BY nombre, secteur.libelle_secteur; 

- **Le montant total des contrats dont s’occupe Mr.MARTIN** :
    - SELECT SUM(contrat.montant_contrat) FROM contrat LEFT JOIN interlocuteur ON (interlocuteur.code_interlocuteur = contrat.code_interlocuteur) WHERE interlocuteur.nom_interlocuteur = 'MARTIN'; 

- **Le contrat ayant le plus grand montant** :
    - SELECT MAX(contrat.montant_contrat) as montant, contrat.ref_contrat, client.raison_sociale_client FROM contrat, client WHERE client.code_client = contrat.code_client GROUP BY contrat.ref_contrat, client.raison_sociale_client ORDER BY montant DESC LIMIT 1;

- **Quel est le montant total des contrats conclus par le bureau de la ville de Bakou ?** :
    - SELECT SUM(contrat.montant_contrat) as montant FROM contrat LEFT JOIN bureau ON (bureau.code_bureau = contrat.code_bureau) WHERE bureau.ville_bureau = 'Bakou';

- **Combien de contrats ont été signés avec l’Azerbaïdjan en 2006 ?** : 
    - SELECT COUNT(contrat.ref_contrat) FROM contrat LEFT JOIN bureau ON (bureau.code_bureau = contrat.code_bureau) WHERE bureau.pays = 'Azerbaïdjan' AND contrat.date_contrat BETWEEN '01/01/2006' AND '31/12/2006';

- **Quel est le montant moyen des contrats par secteur en précisant le libellé du secteur et la moyenne du montant ?** :
    - SELECT ROUND(AVG(montant_contrat),2) as montantmoyen, secteur.libelle_secteur FROM contrat, secteur LEFT JOIN exercer ON (exercer.code_secteur = secteur.code_secteur) LEFT JOIN client ON (client.code_client = exercer.code_client) WHERE contrat.code_client = client.code_client GROUP BY secteur.libelle_secteur;

- **Quels sont les bureaux qui n’ont pas signés de contrat durant le mois de décembre 2006 ?**
    - SELECT CONCAT(bureau.ville_bureau, ', ', bureau.pays) as bureau FROM bureau LEFT JOIN contrat ON (contrat.code_bureau = bureau.code_bureau) WHERE contrat.ref_contrat NOT IN (SELECT contrat.ref_contrat FROM contrat WHERE contrat.date_contrat BETWEEN '01/12/2006' AND '31/12/2006') GROUP BY bureau ORDER BY bureau ASC;