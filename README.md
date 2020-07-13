# Repertoire-client

Le répertoire client est une interface qui permet de mettre en forme les données CSV d'un document.

L'application à été développé pour Gefco, mais peut être réutiliser dans d'autres environnements

## Guide d'installation

 - Téléchargez le document `./RepertoireClient/Publication`

 - Renseignez le document cible dans `./Publication/properties.xml`, entre les balises `<file>` et `</file>`
 
 > faites attention, le document cible doit exister et doit contenir les balises `<ENTREPRISES>` et `<CONTACTS>`

 - Exécutez le programme `./Publication/RepertoireClient.exe`

 - Accédez à la page web `http://localhost:5000`

### Démarrage automatique

Le démarrage automatique peut être utile si ça ne vous dérange pas d'avoir un service qui tourne en arrière plan.
L'application sera à tout moment accessible (pas de programme à exécuter)

Si vous voulez effectuer cette manip, rien de plus simple :

 - Dans le menu `Démarrage` gestionnaire des tâches, ajoutez le programme que vous avez téléchargé.

## Guide d'utilisation

### Accédez à l'application

 - Ça se passe toujours au même endroit : http://localhost:5000

### Changer l'emplacement du document source

 - Renseignez le nouveau document source dans le document de paramètres `./properties.xml`

 - Pensez à bien remettre les balises `<ENTREPRISES>` et `<CONTACTS>``

### Ajouter une entreprise

 - Allez dans l'onglet 'Nouvelle Entreprises'

### Voir toutes les entreprises enregistrées

 - Allez dans l'onglet 'Entreprises'

## Évolution

Veuillez garder vos idées d'évolution pour vous. J'ai pas que ça à faire.

L'application ne sera donc pas maintenue, libre à vous de reprendre mon code et de continuer :p

## Bugs majeurs

Passez voir la page 'issues' sur cette page (github.com/QuentinDPT/Repertoire-Client/issues)
Si vous êtes victime d'un vilain crash ou d'une erreur que vous ne comprenez pas, veuillez créer une issue.
Je ne promet pas de développer un patch, mais j'essayerai de vous donner une correction pour éviter le problème.
