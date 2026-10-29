# Demo EFCore 02
Application ASP.Net MVC	avec EFCore

## Choix technologique pour la démo
- Monolithe en couche (WebApp + DAL)
- Utilisation de EFCore en Code First

### Package installés

#### Web App
- Microsoft.EntityFrameworkCore.Design (Tools)

#### DAL
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.SqlServer

## Migrations avec EFCore

### Solutions possibles
- Utilise le « .NET CLI ».
	- Fonctionne partout
	- Necessite de config : `startup-project` et `project`

- Tools dans le « Package Manager Console » _(VS)_.
	- Simple a configuré

### Utilisation du .Net CLI

#### Installation de l'outils pour EFCore
```
dotnet tool install --global dotnet-ef
```

#### Ajouter une migration
Créer une nouvelle migration avec la méthode « Up » et « Down ».
```
dotnet ef migrations add <MigrationName>
```

Exemple depuis le dossier de la solution
```
dotnet ef migrations add --project "Demo_EFCore_02.DAL" --startup-project "Demo_EFCore_02" ExampleMigration
```

#### Supprimer une migration
Supprime la derniere migration.  \
Attention, celle-ci doit être retiré de la DB avant d'être faite !
```
dotnet ef migrations remove
```

#### Mettre à jour la base de donnée
Modifie la base de donnée en utilisation les méthodes « Up » et « Down ».  \
Si aucunne migration n'est précisé, elle cible la derniere créé. 
```
dotnet ef database update
dotnet ef database update <MigrationName>
```

## Documentation
- EFCore : https://learn.microsoft.com/en-us/ef/core/
- Migrations : https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli
