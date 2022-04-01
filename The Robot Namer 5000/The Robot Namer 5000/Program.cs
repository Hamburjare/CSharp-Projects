using System;
Console.WriteLine("What kind of robot are we talking about?");
string a = Console.ReadLine();
//Muuttuja a varastoi käyttäjän kirjoittaman merkkijonon
Console.WriteLine("How would you describe it? Incredible? Green? Strong?");
string b = Console.ReadLine();
string c = "of Destruction";
string d = "5000";
/*Muuttuja b varastoi käyttäjän kirjoittaman merkkijonon
Muuttuja c varastoi siihen määrätyn merkkijonon eli of Destruction
Muuttuja d varastoi siihen määrätyn merkkijonon eli 5000 */
Console.WriteLine("The " + b + " " + a + " Bot " + c + " " + d + "!");

