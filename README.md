# Refuge Animaux — Application Console

Projet réalisé par **Harlem Alofa** dans le cadre du projet de développement SGBD.

Ce dépôt contient la **partie Console** du projet Refuge Animaux.  
La partie WPF se trouve dans un dépôt séparé : `ProjetSGDB_RefugeAnimauxWPF`.

---

## Objectif

L’application permet de gérer les données principales d’un refuge pour animaux depuis une interface Console :

```text
- animaux
- contacts
- entrées et sorties du refuge
- adoptions
- familles d’accueil
- vaccins et vaccinations
- couleurs
- rôles
- compatibilités
- statistiques
- diagnostic de cohérence
```

---

## Technologies utilisées

```text
- C#
- .NET 8
- PostgreSQL
- Npgsql
- SQL
- Visual Studio
- Git / GitHub
```

---

## Architecture

L’application est organisée en couches :

```text
RefugeAnimaux/
├── Program.cs
├── classesMetier/
├── coucheAccesBD/
└── couchePresentation/
```

### Couche métier

Le dossier `classesMetier` contient les classes principales du domaine :

```text
Animal
Contact
Adoption
FamilleAccueil
Vaccin
Vaccination
Couleur
Role
Compatibilite
AniEntree
AniSortie
```

Il contient aussi les classes de validation :

```text
ValidationDates
ValidationExistence
ValidationMetier
```

### Couche accès aux données

Le dossier `coucheAccesBD` contient l’accès à PostgreSQL avec Npgsql.

La classe `AccesBD.cs` contient les opérations SQL.  
La classe `ConfigurationConnexion.cs` centralise la configuration de connexion et lit les identifiants depuis des variables d’environnement.

### Couche présentation

Le dossier `couchePresentation` contient la classe `Presentation.cs`, qui gère les menus, les saisies, les affichages et les messages d’erreur.

---

## Configuration PostgreSQL

La base utilisée s’appelle :

```text
refuge_animaux
```

Aucun mot de passe n’est stocké dans le dépôt.

La façon la plus simple consiste à définir une chaîne complète dans :

```text
REFUGE_ANIMAUX_DB
```

Exemple :

```text
Host=localhost;Database=refuge_animaux;Username=postgres;Password=VOTRE_MOT_DE_PASSE
```

Il est également possible d’utiliser les variables séparées suivantes :

```text
REFUGE_DB_HOST
REFUGE_DB_NAME
REFUGE_DB_USER
REFUGE_DB_PASSWORD
```

Par défaut, l’hôte, le nom de la base et l’utilisateur valent respectivement `localhost`, `refuge_animaux` et `postgres`. La variable `REFUGE_DB_PASSWORD` est obligatoire si `REFUGE_ANIMAUX_DB` n’est pas définie.

---

## Fonctionnalités principales

### Animaux

```text
- ajouter un animal avec son entrée au refuge dans une transaction
- consulter les animaux
- rechercher un animal par identifiant ou par nom
- afficher une fiche animal détaillée
- supprimer un animal si les règles le permettent
```

### Contacts

```text
- ajouter un contact
- modifier un contact
- consulter les contacts
- consulter les données liées à un contact
- supprimer un contact si les règles le permettent
```

### Refuge

```text
- gérer les entrées
- gérer les sorties
- afficher les animaux présents au refuge
```

### Adoptions et familles d’accueil

```text
- ajouter une adoption
- modifier le statut d’une adoption
- placer un animal en famille d’accueil
- clôturer une famille d’accueil
```

### Vaccins, couleurs, rôles et compatibilités

```text
- ajouter un vaccin
- vacciner un animal
- ajouter une couleur
- associer une couleur à un animal
- ajouter un rôle
- associer un rôle à un contact
- gérer les compatibilités
```

### Diagnostic

```text
- statistiques
- cohérence du refuge
- diagnostic des anomalies possibles
```

---

## Améliorations apportées

Cette version corrige plusieurs points techniques :

```text
- connexion PostgreSQL centralisée dans ConfigurationConnexion
- aucun secret stocké dans le code source
- connexion recréée proprement par opération
- ajout animal + entrée dans une transaction
- lecture des dates rendue plus robuste
- contrôles de cohérence renforcés
- .gitignore propre
```

---

## Lancement

Depuis Visual Studio :

```text
F5
```

Depuis le terminal :

```bash
dotnet run --project RefugeAnimaux
```

---

## Limites restantes

Le projet est fonctionnel, mais certaines améliorations resteraient possibles :

```text
- séparer AccesBD.cs en plusieurs repositories
- diviser Presentation.cs en plusieurs classes
- ajouter des tests unitaires
- ajouter davantage de comportements dans les classes métier
```

Ces limites sont documentées, mais elles ne bloquent pas le fonctionnement du projet.
