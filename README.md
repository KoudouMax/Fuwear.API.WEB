# Fuwear.API.WEB
[Test technique] Projet API web

Pour ce test vous devez créer un projet API web ASP.NET Core / .NET 7.0 avec 2 endpoints,

Une fois le projet fini, vous devez publier le code dans Github et nous envoyer le lien,

 
# Fibonacci
 

Le endpoint /fibonacci/{n} retourne la valeur de la suite de Fibonacci pour le rang n.

Pour rappel, la suite de Fibonacci est définie ainsi (https://en.wikipedia.org/wiki/Fibonacci_sequence) :

F(0) = 0, F(1) = 1
Et pour n > 1 : F(n) = F(n-1) + F(n-2)
 
Calculer la valeur de la suite pour n respectant la condition suivante 1 <= n <= 100, sinon retourner -1.

 
# Actions
 

Le endpoint /action retourne l’action ayant le prix moyen le plus élevé.
Voici les données à mettre en dur dans le projet :

var actions = new[] { "AMZN", "CACC", "EQIX", "GOOG", "ORLY", "ULTA" };

var prices = new[,]{
    { 12.81, 11.09, 12.11, 10.93, 9.83, 8.14 },
    { 10.34, 10.56, 10.14, 12.17, 13.1, 11.22 },
    { 11.53, 10.67, 10.42, 11.88, 11.77, 10.21 }
};


actions est un tableau de chaînes de caractères, représentant les actions considérées.
prices est un tableau de 2 dimensions, représentant les prix des actions (listes intérieures) pour chaque jour (liste extérieure)

Vous devez renvoyer le résultat sous forme d’un objet Action ayant 2 propriétés :

Name
AvgPrice
