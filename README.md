# Refuge Animaux — Application Console C# / PostgreSQL

Application de gestion d’un refuge animalier réalisée dans le cadre d’un projet de développement SGBD.

Cette partie du projet propose une **interface Console en C#/.NET 8** connectée à une base **PostgreSQL** via **Npgsql**. Elle met en pratique la modélisation de données, l’architecture en couches, les règles métier, les transactions et la validation des données.

> La version graphique WPF/MVVM du même projet est disponible dans le dépôt `ProjetSGDB_RefugeAnimauxWPF`.

## Fonctionnalités principales

- gestion des animaux et de leurs fiches détaillées ;
- gestion des contacts ;
- entrées et sorties du refuge ;
- adoptions ;
- familles d’accueil ;
- vaccins et vaccinations ;
- couleurs, rôles et compatibilités ;
- statistiques ;
- diagnostic de cohérence des données.

## Stack technique

- C#
- .NET 8
- PostgreSQL
- SQL
- Npgsql
- Visual Studio
- Git / GitHub

## Architecture

```text
RefugeAnimaux/
├── Program.cs
├── classesMetier/
├── coucheAccesBD/
└── couchePresentation/
```

### Couche métier

Contient les principales classes du domaine ainsi que les validations métier et de dates.

### Couche accès aux données

Centralise les opérations PostgreSQL avec Npgsql. La connexion est configurée via variables d’environnement afin qu’aucun secret ne soit stocké dans le code source.

### Couche présentation

Gère les menus Console, les saisies utilisateur, les affichages et les messages d’erreur.

## Configuration PostgreSQL

La base utilisée s’appelle :

```text
refuge_animaux
```

La connexion peut être fournie directement avec :

```text
REFUGE_ANIMAUX_DB
```

Exemple :

```text
Host=localhost;Database=refuge_animaux;Username=postgres;Password=VOTRE_MOT_DE_PASSE
```

Ou avec les variables séparées :

```text
REFUGE_DB_HOST
REFUGE_DB_NAME
REFUGE_DB_USER
REFUGE_DB_PASSWORD
```

`REFUGE_DB_PASSWORD` est obligatoire si `REFUGE_ANIMAUX_DB` n’est pas définie.

## Points techniques mis en pratique

- architecture en couches ;
- accès à PostgreSQL avec Npgsql ;
- requêtes SQL paramétrées ;
- transaction pour certaines opérations liées ;
- règles métier et validations ;
- gestion de données relationnelles complexes ;
- séparation des responsabilités ;
- configuration sensible externalisée.

## Exécution

Depuis Visual Studio :

```text
F5
```

Ou depuis le terminal :

```bash
dotnet run --project RefugeAnimaux
```

## Améliorations possibles

- séparer davantage la couche d’accès aux données en repositories spécialisés ;
- découper la classe de présentation en plusieurs composants ;
- ajouter des tests unitaires ;
- enrichir les comportements des classes métier.

## Contexte

Projet réalisé par **Harlem Kponve Alofa**, étudiant en **Bachelier en Informatique — orientation Développement d’applications**.

Ce dépôt met principalement en évidence des compétences en **C#, .NET, PostgreSQL, SQL, architecture logicielle et développement d’applications métier**.
